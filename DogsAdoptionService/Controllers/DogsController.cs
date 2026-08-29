using DogsAdoptionService.Services;
using Microsoft.AspNetCore.Mvc;

namespace DogsAdoptionService.Controllers
{
    
    public class DogsController : Controller
    {
       
        private readonly IDogService _dogService;
        private readonly ILogger<DogsController> _logger;

        public DogsController(IDogService dogService, ILogger<DogsController> logger)
        { 
            // Dependency injection for the dog service and logger
            _dogService = dogService;
            _logger = logger;
        }

        // 1. Index action to display a list of all dogs (first page)
        public async Task<IActionResult> Index()
        {
            var dogs = await _dogService.GetAllDogsAsync();
            return View(dogs);
        }

        // 2. Details action to display detailed information about a specific dog(DetailsPage)
        public async Task<IActionResult> Details(int id)
        {
            if (id <= 0)
            {
                return BadRequest(); // HTTP400
            }

            var dog = await _dogService.GetDogByIdAsync(id);
            
            if (dog == null)
            {
                return NotFound(); //HTTP404
            }

            return View(dog);
        }


        // 3. Adopt action to handle the adoption of a dog (AdoptPage)
        public async Task<IActionResult> Adopt(int id)
        {
            if (id <= 0)
            {
                return BadRequest(); // HTTP400
            }

            _logger.LogInformation("Attempting to adopt dog with ID: {DogId}", id);

            var dog = await _dogService.AdoptDogAsync(id);

            // Log a warning if the dog is not found or already adopted
            if (dog == null)
            {
                _logger.LogWarning("Dog with ID {DogId} not found or already adopted", id);
                return NotFound(); // HTTP404
            }

            // Log information about the successful adoption
            _logger.LogInformation("Successfully adopted dog: {DogName}", dog.Name);
            return View("Adopt", dog);
        }
    }
}


