namespace VirtualMuseum.Services
{
    using Microsoft.EntityFrameworkCore;
    using VirtualMuseum.Components.Pages.Exhibits;
    using VirtualMuseum.Data;
    using VirtualMuseum.Models;
    public class TourService
    {
        private readonly ApplicationDbContext _db;

        public TourService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<List<Tour>> GetAllAsync() => await _db.Tours.ToListAsync();

        public async Task AddTourAsync(Tour tour)
        {
            tour.Id = 0;
            _db.Tours.Add(tour);

            await _db.SaveChangesAsync();
        }

        public async Task<Tour?> GetByIdAsync(int id)
        {
            return await _db.Tours
                    .Include(e => e.Exhibits)
                        .ThenInclude(e => e.Images)
                .Include(t => t.Feedbacks)
                .FirstOrDefaultAsync(t => t.Id == id);
        }
        public async Task UpdateAsync(Tour tour)
        {
            _db.Tours.Update(tour);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var tour = await _db.Tours.FindAsync(id);
            if (tour == null) return;

            _db.Tours.Remove(tour);
            await _db.SaveChangesAsync();
        }
    }
}
