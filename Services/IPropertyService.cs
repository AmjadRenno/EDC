using EDC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EDC.Services
{
    public interface IPropertyService
    {
        Task<List<Property>> GetAllPropertiesAsync();
        Task<Property?> GetPropertyByIdAsync(int id);
        Task<Property> CreatePropertyAsync(Property property);
        Task<Property> AddPropertyAsync(Property property);
        Task<Property> UpdatePropertyAsync(Property property);
        Task<bool> DeletePropertyAsync(int id);
        Task<List<Property>> SearchPropertiesAsync(string searchTerm);
        Task<List<Property>> GetPropertiesByStatusAsync(PropertyStatus status);
        Task<List<Property>> GetPropertiesByTypeAsync(PropertyType type);
        Task<List<Property>> GetPropertiesByPostalCodeAsync(string postalCode);
        Task<List<Property>> GetPropertiesByPriceRangeAsync(decimal minPrice, decimal maxPrice);
        Task<List<Property>> GetSimilarPropertiesAsync(string postalCode, PropertyType type, int sizeM2, int tolerance = 15);
        Task<Property> MarkPropertyAsSoldAsync(int propertyId, int buyerId, decimal soldPrice);
        Task<decimal> GetAveragePricePerM2Async(List<Property> properties);
    }
}
