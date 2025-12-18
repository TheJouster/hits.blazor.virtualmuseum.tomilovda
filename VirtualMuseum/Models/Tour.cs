using Microsoft.AspNetCore.Identity;

namespace VirtualMuseum.Models
{
    public class Tour
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string OwnerId { get; set; }
        public List<Exhibit> Exhibits { get; set; } = new();

    }
}
