using DogsAdoptionService.Data;
using DogsAdoptionService.ViewModels;

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
            
            return dogs.OrderBy(d => d.Id).Select(d => new DogListViewModel
            {
                Id = d.Id,
                Name = d.Name,
                Cuteness = d.Cuteness,
                Image = d.Image,
                IsAdopted = d.IsAdopted
            });
        }

        public async Task<DogDetailsViewModel?> GetDogByIdAsync(int id)
        {
            var dog = await _repository.GetByIdAsync(id);
            
            if (dog == null)
                return null;

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