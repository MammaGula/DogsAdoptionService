using DogsAdoptionService.Models;
using Microsoft.EntityFrameworkCore;

namespace DogsAdoptionService.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DogModel> Dogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed initial data
            modelBuilder.Entity<DogModel>().HasData(
                new DogModel { Id = 1, Name = "Bark Twain", Cuteness = 10, Image = "BarkTwain1.jpg", FavFood = "Barkoni", FavToy = "Barkle", Temperament = 7, IsAdopted = false },
                new DogModel { Id = 2, Name = "Sir Waggington", Cuteness = 10, Image = "SirWaggington2.jpg", FavFood = "Pawsta", FavToy = "Fetch Stick", Temperament = 6, IsAdopted = false },
                new DogModel { Id = 3, Name = "Furball", Cuteness = 10, Image = "Furball3.jpg", FavFood = "Bone Appetit", FavToy = "Squeaky Ball", Temperament = 8, IsAdopted = false },
                new DogModel { Id = 4, Name = "Princess Paws", Cuteness = 10, Image = "PrincessPaws4.jpg", FavFood = "Royal Canin", FavToy = "Diamond Collar", Temperament = 6, IsAdopted = false },
                new DogModel { Id = 5, Name = "Biscuit", Cuteness = 10, Image = "Biscuit5.jpg", FavFood = "Pupcakes", FavToy = "Chewy Bone", Temperament = 9, IsAdopted = false },
                new DogModel { Id = 6, Name = "Daisy", Cuteness = 10, Image = "Daisy6.jpg", FavFood = "Doggie Delight", FavToy = "Plush Squirrel", Temperament = 6, IsAdopted = false },
                new DogModel { Id = 7, Name = "Captain Woof", Cuteness = 10, Image = "CaptainWoof7.jpg", FavFood = "Fish 'n Chips", FavToy = "Nautical Rope", Temperament = 8, IsAdopted = false },
                new DogModel { Id = 8, Name = "Snuggle Paws", Cuteness = 10, Image = "SnugglePaws8.jpg", FavFood = "Cuddle Crunchies", FavToy = "Soft Blanket", Temperament = 7, IsAdopted = false },
                new DogModel { Id = 9, Name = "Rocky", Cuteness = 10, Image = "Rocky9.jpg", FavFood = "Steak Bites", FavToy = "Tennis Ball", Temperament = 7, IsAdopted = false },
                new DogModel { Id = 10, Name = "Lola", Cuteness = 10, Image = "Lola10.jpg", FavFood = "Treat Tower", FavToy = "Squeaky Duck", Temperament = 6, IsAdopted = false },
                new DogModel { Id = 11, Name = "Maximus", Cuteness = 10, Image = "Maximus11.jpg", FavFood = "Beefy Bites", FavToy = "Tug Rope", Temperament = 9, IsAdopted = false },
                new DogModel { Id = 12, Name = "Roxy", Cuteness = 10, Image = "Roxy12.jpg", FavFood = "Chicken Chewies", FavToy = "Frisbee", Temperament = 7, IsAdopted = false },
                new DogModel { Id = 13, Name = "Teddy", Cuteness = 10, Image = "Teddy13.jpg", FavFood = "Carrot Crunch", FavToy = "Plush Bunny", Temperament = 6, IsAdopted = false },
                new DogModel { Id = 14, Name = "Coco", Cuteness = 10, Image = "Coco14.jpg", FavFood = "Coconut Chew", FavToy = "Ball Launcher", Temperament = 8, IsAdopted = false }
            );
        }
    }
}