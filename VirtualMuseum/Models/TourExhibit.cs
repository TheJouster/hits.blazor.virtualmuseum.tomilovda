namespace VirtualMuseum.Models
{
    public class TourExhibit
    {
        public int TourId { get; set; }
        public Tour Tour { get; set; } = null!;
        public int ExhibitId { get; set; }
        public Exhibit Exhibit { get; set; } = null!;
        public int Order {  get; set; }
    }
}
