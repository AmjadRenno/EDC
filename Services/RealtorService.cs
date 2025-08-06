using EDC.Models;
using System.Text.Json;

namespace EDC.Services
{
    public class RealtorService : IRealtorService
    {
        private readonly string _dataFilePath;
        private List<Realtor> _realtors;

        public RealtorService()
        {
            _dataFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "EDC", "realtors.json");
            Directory.CreateDirectory(Path.GetDirectoryName(_dataFilePath)!);
            _realtors = LoadRealtorsFromFile();
        }

        public async Task<List<Realtor>> GetAllRealtorsAsync()
        {
            return await Task.FromResult(_realtors.OrderBy(r => r.LastName).ThenBy(r => r.FirstName).ToList());
        }

        public async Task<Realtor?> GetRealtorByIdAsync(int id)
        {
            return await Task.FromResult(_realtors.FirstOrDefault(r => r.Id == id));
        }

        public async Task<bool> AddRealtorAsync(Realtor realtor)
        {
            try
            {
                realtor.Id = GetNextId();
                realtor.CreatedDate = DateTime.Now;
                _realtors.Add(realtor);
                await SaveRealtorsToFile();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> UpdateRealtorAsync(Realtor realtor)
        {
            try
            {
                var existingRealtor = _realtors.FirstOrDefault(r => r.Id == realtor.Id);
                if (existingRealtor == null) return false;

                existingRealtor.FirstName = realtor.FirstName;
                existingRealtor.LastName = realtor.LastName;
                existingRealtor.Phone = realtor.Phone;
                existingRealtor.Email = realtor.Email;
                existingRealtor.UpdatedDate = DateTime.Now;

                await SaveRealtorsToFile();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> DeleteRealtorAsync(int id)
        {
            try
            {
                var realtor = _realtors.FirstOrDefault(r => r.Id == id);
                if (realtor == null) return false;

                _realtors.Remove(realtor);
                await SaveRealtorsToFile();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<List<Realtor>> SearchRealtorsAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return await GetAllRealtorsAsync();

            var searchLower = searchTerm.ToLower();
            return await Task.FromResult(_realtors.Where(r =>
                r.FirstName.ToLower().Contains(searchLower) ||
                r.LastName.ToLower().Contains(searchLower) ||
                r.Email.ToLower().Contains(searchLower) ||
                r.Phone.Contains(searchTerm)
            ).ToList());
        }

        private int GetNextId()
        {
            return _realtors.Count == 0 ? 1 : _realtors.Max(r => r.Id) + 1;
        }

        private List<Realtor> LoadRealtorsFromFile()
        {
            try
            {
                if (File.Exists(_dataFilePath))
                {
                    var json = File.ReadAllText(_dataFilePath);
                    return JsonSerializer.Deserialize<List<Realtor>>(json) ?? new List<Realtor>();
                }
            }
            catch
            {
                // Log error in a real application
            }
            return new List<Realtor>();
        }

        private async Task SaveRealtorsToFile()
        {
            try
            {
                var json = JsonSerializer.Serialize(_realtors, new JsonSerializerOptions 
                { 
                    WriteIndented = true 
                });
                await File.WriteAllTextAsync(_dataFilePath, json);
            }
            catch
            {
                // Log error in a real application
                throw;
            }
        }
    }
}
