using DogsAdoptionService.Models;
using Microsoft.EntityFrameworkCore;

namespace DogsAdoptionService.Data
{
    public class DogRepository : IDogRepository
    {
        private readonly ApplicationDbContext _context;

        public DogRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DogModel>> GetAllAsync()
        {
            return await _context.Dogs.ToListAsync();
        }

        public async Task<DogModel?> GetByIdAsync(int id)
        {
            return await _context.Dogs.FindAsync(id);
        }

        public async Task UpdateAsync(DogModel dog)
        {
            _context.Dogs.Update(dog);
            await _context.SaveChangesAsync();
        }

        public async Task<DogModel> AddAsync(DogModel dog)
        {
            _context.Dogs.Add(dog);
            await _context.SaveChangesAsync();
            return dog;
        }

        public async Task DeleteAsync(int id)
        {
            var dog = await _context.Dogs.FindAsync(id);
            if (dog != null)
            {
                _context.Dogs.Remove(dog);
                await _context.SaveChangesAsync();
            }
        }
    }
}
