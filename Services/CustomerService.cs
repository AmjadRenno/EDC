using EDC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EDC.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly string _dataPath;
        private List<Customer> _customers = new();

        public CustomerService()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var edcPath = Path.Combine(appDataPath, "EDC");
            
            if (!Directory.Exists(edcPath))
                Directory.CreateDirectory(edcPath);
                
            _dataPath = Path.Combine(edcPath, "customers.json");
        }

        public async Task<List<Customer>> GetAllCustomersAsync()
        {
            try
            {
                if (File.Exists(_dataPath))
                {
                    var json = await File.ReadAllTextAsync(_dataPath);
                    if (!string.IsNullOrEmpty(json))
                    {
                        _customers = JsonSerializer.Deserialize<List<Customer>>(json) ?? new List<Customer>();
                    }
                }
                return _customers;
            }
            catch (Exception)
            {
                return new List<Customer>();
            }
        }

        public async Task<Customer?> GetCustomerByIdAsync(int id)
        {
            var customers = await GetAllCustomersAsync();
            return customers.FirstOrDefault(c => c.Id == id);
        }

        public async Task<Customer> CreateCustomerAsync(Customer customer)
        {
            return await AddCustomerAsync(customer);
        }

        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            var customers = await GetAllCustomersAsync();
            
            customer.Id = customers.Any() ? customers.Max(c => c.Id) + 1 : 1;
            customer.CreatedAt = DateTime.Now;
            customer.UpdatedAt = DateTime.Now;
            
            customers.Add(customer);
            await SaveCustomersAsync(customers);
            
            return customer;
        }

        public async Task<Customer> UpdateCustomerAsync(Customer customer)
        {
            var customers = await GetAllCustomersAsync();
            var existingCustomer = customers.FirstOrDefault(c => c.Id == customer.Id);
            
            if (existingCustomer != null)
            {
                existingCustomer.FirstName = customer.FirstName;
                existingCustomer.LastName = customer.LastName;
                existingCustomer.Email = customer.Email;
                existingCustomer.Phone = customer.Phone;
                existingCustomer.Address = customer.Address;
                existingCustomer.PostalCode = customer.PostalCode;
                existingCustomer.City = customer.City;
                existingCustomer.BirthDate = customer.BirthDate;
                existingCustomer.CustomerType = customer.CustomerType;
                existingCustomer.UpdatedAt = DateTime.Now;
                
                await SaveCustomersAsync(customers);
                return existingCustomer;
            }
            
            throw new ArgumentException("Kunde ikke fundet");
        }

        public async Task<bool> DeleteCustomerAsync(int id)
        {
            var customers = await GetAllCustomersAsync();
            var customer = customers.FirstOrDefault(c => c.Id == id);
            
            if (customer != null)
            {
                customers.Remove(customer);
                await SaveCustomersAsync(customers);
                return true;
            }
            
            return false;
        }

        public async Task<List<Customer>> SearchCustomersAsync(string searchTerm)
        {
            var customers = await GetAllCustomersAsync();
            
            if (string.IsNullOrWhiteSpace(searchTerm))
                return customers;
                
            return customers.Where(c =>
                c.FirstName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                c.LastName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                c.Email.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                c.Phone.Contains(searchTerm) ||
                c.City.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }

        public async Task<List<Customer>> GetCustomersByTypeAsync(CustomerType type)
        {
            var customers = await GetAllCustomersAsync();
            return customers.Where(c => c.CustomerType == type).ToList();
        }

        private async Task SaveCustomersAsync(List<Customer> customers)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                
                var json = JsonSerializer.Serialize(customers, options);
                await File.WriteAllTextAsync(_dataPath, json);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Kunne ikke gemme kunder: {ex.Message}");
            }
        }
    }
}
