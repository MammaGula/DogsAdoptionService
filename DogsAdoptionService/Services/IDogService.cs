using DogsAdoptionService.ViewModels;

namespace DogsAdoptionService.Services
{
    public interface IDogService
    {
        Task<IEnumerable<DogListViewModel>> GetAllDogsAsync();
        Task<DogDetailsViewModel?> GetDogByIdAsync(int id);
        Task<DogDetailsViewModel?> AdoptDogAsync(int id); // Return dog directly
    }
}