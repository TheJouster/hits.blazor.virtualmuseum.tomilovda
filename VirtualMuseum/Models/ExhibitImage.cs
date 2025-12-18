namespace VirtualMuseum.Models
{
    public class ExhibitImage
    {
        public int Id { get; set; }
        public int ExhibitId { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}
