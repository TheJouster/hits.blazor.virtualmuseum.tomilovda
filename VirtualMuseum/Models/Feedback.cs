namespace VirtualMuseum.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Message { get; set; } = string.Empty;
        public int Rating { get; set; } = 1;

        public int TourId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
