namespace DogsAdoptionService.ViewModels
{
    public class DogDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cuteness { get; set; }
        public string Image { get; set; }
        public string FavFood { get; set; }
        public string FavToy { get; set; }
        public int Temperament { get; set; }
        public bool IsAdopted { get; set; }
    }
}