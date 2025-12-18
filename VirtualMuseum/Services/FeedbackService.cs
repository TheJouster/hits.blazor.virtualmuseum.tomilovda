namespace VirtualMuseum.Services
{
    using VirtualMuseum.Models;
    public class FeedbackService
    {
        private readonly List<Feedback> _feedbacks = new();
        public void AddFeedback(Feedback feedback)
        {
            _feedbacks.Add(feedback);
        }
        public List<Feedback> GetAll() => _feedbacks;
        
        public List<Feedback> GetByTour(int tourId)
        {
            return _feedbacks
                .Where(f => f.TourId == tourId)
                .OrderByDescending(f => f.CreatedAt)
                .ToList();
        }
    }
}
