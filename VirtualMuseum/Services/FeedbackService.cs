namespace VirtualMuseum.Services
{
    using Microsoft.EntityFrameworkCore;
    using VirtualMuseum.Components.Pages.Exhibits;
    using VirtualMuseum.Data;
    using VirtualMuseum.Models;
    public class FeedbackService
    {
        private readonly ApplicationDbContext _db;

        public FeedbackService(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<List<Feedback>> GetByTourAsync(int tourId)
        {
            return await _db.Feedbacks
                .Where(f => f.TourId == tourId)
                .OrderByDescending(f => f.CreatedAt).ToListAsync();
        }

        public async Task AddAsync(Feedback feedback)
        {
            feedback.Id = 0;
            _db.Feedbacks.Add(feedback);
            await _db.SaveChangesAsync();
        }
    }
}
