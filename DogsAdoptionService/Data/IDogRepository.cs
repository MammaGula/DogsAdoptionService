using DogsAdoptionService.Models;

namespace DogsAdoptionService.Data
{
    public interface IDogRepository
    {
        Task<IEnumerable<DogModel>> GetAllAsync();
        Task<DogModel?> GetByIdAsync(int id);
        Task<DogModel> AddAsync(DogModel dog);
        Task UpdateAsync(DogModel dog);
        Task DeleteAsync(int id);
    }
}