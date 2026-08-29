using DogsAdoptionService.Data;
using DogsAdoptionService.ViewModels;
using System.Linq;

namespace DogsAdoptionService.Services
{
    public class DogService : IDogService
    {
        private readonly IDogRepository _repository;

        public DogService(IDogRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<DogListViewModel>> GetAllDogsAsync()
        {
            var dogs = await _repository.GetAllAsync();

            // Map the list of Dog entities to a list of DogListViewModel
            return dogs
                .OrderBy(d => d.Id)
                .Select(d => new DogListViewModel
                {
                    Id = d.Id,
                    Name = d.Name,
                    Cuteness = d.Cuteness,
                    Image = d.Image,
                    IsAdopted = d.IsAdopted
                })
                .ToList(); 
        }

        public async Task<DogDetailsViewModel?> GetDogByIdAsync(int id)
        {
            var dog = await _repository.GetByIdAsync(id);
            
            if (dog == null)
                return null;

            // If the dog is found, map it to DogDetailsViewModel and return
            return new DogDetailsViewModel
            {
                Id = dog.Id,
                Name = dog.Name,
                Cuteness = dog.Cuteness,
                Image = dog.Image,
                FavFood = dog.FavFood,
                FavToy = dog.FavToy,
                Temperament = dog.Temperament,
                IsAdopted = dog.IsAdopted
            };
        }

        // This method adopts a dog by its ID. If the dog is found and not already adopted,
        // it updates the IsAdopted property to true and returns the updated dog details.
        public async Task<DogDetailsViewModel?> AdoptDogAsync(int id)
        {
            var dog = await _repository.GetByIdAsync(id);
            
            if (dog == null || dog.IsAdopted)
                return null;

            dog.IsAdopted = true;
            await _repository.UpdateAsync(dog);

            return new DogDetailsViewModel
            {
                Id = dog.Id,
                Name = dog.Name,
                Cuteness = dog.Cuteness,
                Image = dog.Image,
                FavFood = dog.FavFood,
                FavToy = dog.FavToy,
                Temperament = dog.Temperament,
                IsAdopted = dog.IsAdopted
            };
        }
    }
}