using EDC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EDC.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAllCustomersAsync();
        Task<Customer?> GetCustomerByIdAsync(int id);
        Task<Customer> CreateCustomerAsync(Customer customer);
        Task<Customer> AddCustomerAsync(Customer customer);
        Task<Customer> UpdateCustomerAsync(Customer customer);
        Task<bool> DeleteCustomerAsync(int id);
        Task<List<Customer>> SearchCustomersAsync(string searchTerm);
        Task<List<Customer>> GetCustomersByTypeAsync(CustomerType type);
    }
}
