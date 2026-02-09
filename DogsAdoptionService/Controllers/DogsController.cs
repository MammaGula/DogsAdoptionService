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
            _dogService = dogService;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var dogs = await _dogService.GetAllDogsAsync();
            return View(dogs);
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            var dog = await _dogService.GetDogByIdAsync(id);
            
            if (dog == null)
            {
                return NotFound();
            }

            return View(dog);
        }

        public async Task<IActionResult> Adopt(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            _logger.LogInformation("Attempting to adopt dog with ID: {DogId}", id);

            var dog = await _dogService.AdoptDogAsync(id);
            
            if (dog == null)
            {
                _logger.LogWarning("Dog with ID {DogId} not found or already adopted", id);
                return NotFound();
            }

            _logger.LogInformation("Successfully adopted dog: {DogName}", dog.Name);
            return View("Adopt", dog);
        }
    }
}


