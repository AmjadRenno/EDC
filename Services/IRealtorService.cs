using EDC.Models;

namespace EDC.Services
{
    public interface IRealtorService
    {
        Task<List<Realtor>> GetAllRealtorsAsync();
        Task<Realtor?> GetRealtorByIdAsync(int id);
        Task<bool> AddRealtorAsync(Realtor realtor);
        Task<bool> UpdateRealtorAsync(Realtor realtor);
        Task<bool> DeleteRealtorAsync(int id);
        Task<List<Realtor>> SearchRealtorsAsync(string searchTerm);
    }
}
