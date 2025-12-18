namespace VirtualMuseum.Services
{
    using VirtualMuseum.Models;
    public class TourService
    {
        private readonly List<Tour> _tours = new();
        public List<Tour> GetTours() => _tours;
        public void AddTour(Tour tour)
        {
            _tours.Add(tour);
        }
    }
}
