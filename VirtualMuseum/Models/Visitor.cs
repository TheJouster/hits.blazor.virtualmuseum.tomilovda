namespace VirtualMuseum.Models
{
    public class Visitor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Feedback> Feedbacks { get; set; } = new();
    }
}
