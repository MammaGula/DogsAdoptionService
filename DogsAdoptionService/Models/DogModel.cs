namespace DogsAdoptionService.Models
{
    public class DogModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Cuteness { get; set; }
        public string Image { get; set; } = string.Empty;
        public string FavFood { get; set; } = string.Empty;
        public string FavToy { get; set; } = string.Empty;
        public int Temperament { get; set; }
        public bool IsAdopted { get; set; }
    }
}
