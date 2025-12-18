namespace VirtualMuseum.Models
{
    public class Exhibit
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<ExhibitImage> Images { get; set; } = new();
        public string Location { get; set; } = string.Empty;
    }
}
