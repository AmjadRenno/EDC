using EDC.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace EDC.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly string _dataPath;
        private List<Property> _properties = new();

        public PropertyService()
        {
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var edcPath = Path.Combine(appDataPath, "EDC");
            
            if (!Directory.Exists(edcPath))
                Directory.CreateDirectory(edcPath);
                
            _dataPath = Path.Combine(edcPath, "properties.json");
        }

        public async Task<List<Property>> GetAllPropertiesAsync()
        {
            try
            {
                if (File.Exists(_dataPath))
                {
                    var json = await File.ReadAllTextAsync(_dataPath);
                    if (!string.IsNullOrEmpty(json))
                    {
                        _properties = JsonSerializer.Deserialize<List<Property>>(json) ?? new List<Property>();
                    }
                }
                return _properties;
            }
            catch (Exception)
            {
                return new List<Property>();
            }
        }

        public async Task<Property?> GetPropertyByIdAsync(int id)
        {
            var properties = await GetAllPropertiesAsync();
            return properties.FirstOrDefault(p => p.Id == id);
        }

        public async Task<Property> CreatePropertyAsync(Property property)
        {
            return await AddPropertyAsync(property);
        }

        public async Task<Property> AddPropertyAsync(Property property)
        {
            var properties = await GetAllPropertiesAsync();
            
            property.Id = properties.Any() ? properties.Max(p => p.Id) + 1 : 1;
            property.CreatedAt = DateTime.Now;
            property.UpdatedAt = DateTime.Now;
            
            properties.Add(property);
            await SavePropertiesAsync(properties);
            
            return property;
        }

        public async Task<Property> UpdatePropertyAsync(Property property)
        {
            var properties = await GetAllPropertiesAsync();
            var existingProperty = properties.FirstOrDefault(p => p.Id == property.Id);
            
            if (existingProperty != null)
            {
                existingProperty.Title = property.Title;
                existingProperty.Address = property.Address;
                existingProperty.PostalCode = property.PostalCode;
                existingProperty.City = property.City;
                existingProperty.Type = property.Type;
                existingProperty.SizeM2 = property.SizeM2;
                existingProperty.Rooms = property.Rooms;
                existingProperty.YearBuilt = property.YearBuilt;
                existingProperty.AskingPrice = property.AskingPrice;
                existingProperty.Description = property.Description;
                existingProperty.UpdatedAt = DateTime.Now;
                
                await SavePropertiesAsync(properties);
                return existingProperty;
            }
            
            throw new ArgumentException("Ejendom ikke fundet");
        }

        public async Task<bool> DeletePropertyAsync(int id)
        {
            var properties = await GetAllPropertiesAsync();
            var property = properties.FirstOrDefault(p => p.Id == id);
            
            if (property != null)
            {
                properties.Remove(property);
                await SavePropertiesAsync(properties);
                return true;
            }
            
            return false;
        }

        public async Task<List<Property>> SearchPropertiesAsync(string searchTerm)
        {
            var properties = await GetAllPropertiesAsync();
            
            if (string.IsNullOrWhiteSpace(searchTerm))
                return properties;
                
            return properties.Where(p =>
                p.Address.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                p.City.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                p.PostalCode.Contains(searchTerm)
            ).ToList();
        }

        public async Task<List<Property>> GetPropertiesByStatusAsync(PropertyStatus status)
        {
            var properties = await GetAllPropertiesAsync();
            return properties.Where(p => p.Status == status).ToList();
        }

        public async Task<List<Property>> GetPropertiesByTypeAsync(PropertyType type)
        {
            var properties = await GetAllPropertiesAsync();
            return properties.Where(p => p.Type == type).ToList();
        }

        public async Task<List<Property>> GetPropertiesByPostalCodeAsync(string postalCode)
        {
            var properties = await GetAllPropertiesAsync();
            return properties.Where(p => p.PostalCode == postalCode).ToList();
        }

        public async Task<List<Property>> GetPropertiesByPriceRangeAsync(decimal minPrice, decimal maxPrice)
        {
            var properties = await GetAllPropertiesAsync();
            return properties.Where(p => p.AskingPrice >= minPrice && p.AskingPrice <= maxPrice).ToList();
        }

        public async Task<List<Property>> GetSimilarPropertiesAsync(string postalCode, PropertyType type, int sizeM2, int tolerance = 15)
        {
            var properties = await GetAllPropertiesAsync();
            return properties.Where(p =>
                p.PostalCode == postalCode &&
                p.Type == type &&
                p.SizeM2 >= (sizeM2 - tolerance) &&
                p.SizeM2 <= (sizeM2 + tolerance) &&
                p.Status == PropertyStatus.Sold
            ).ToList();
        }

        public async Task<Property> MarkPropertyAsSoldAsync(int propertyId, int buyerId, decimal soldPrice)
        {
            var properties = await GetAllPropertiesAsync();
            var property = properties.FirstOrDefault(p => p.Id == propertyId);
            
            if (property != null)
            {
                property.Status = PropertyStatus.Sold;
                property.BuyerId = buyerId;
                property.SoldPrice = soldPrice;
                property.SoldDate = DateTime.Now;
                property.UpdatedAt = DateTime.Now;
                
                await SavePropertiesAsync(properties);
                return property;
            }
            
            throw new ArgumentException("Ejendom ikke fundet");
        }

        public async Task<decimal> GetAveragePricePerM2Async(List<Property> properties)
        {
            if (!properties.Any())
                return 0;
                
            var validProperties = properties.Where(p => p.SizeM2 > 0).ToList();
            if (!validProperties.Any())
                return 0;
                
            return validProperties.Average(p => p.PricePerM2);
        }

        private async Task SavePropertiesAsync(List<Property> properties)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                };
                
                var json = JsonSerializer.Serialize(properties, options);
                await File.WriteAllTextAsync(_dataPath, json);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Kunne ikke gemme ejendomme: {ex.Message}");
            }
        }
    }
}
