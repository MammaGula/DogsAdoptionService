namespace DogsAdoptionService.ViewModels
{
    public class DogListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cuteness { get; set; }
        public string Image { get; set; }
        public bool IsAdopted { get; set; }
    }
}