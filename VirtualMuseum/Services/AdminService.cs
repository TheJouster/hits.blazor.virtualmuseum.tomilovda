using VirtualMuseum.Data;

namespace VirtualMuseum.Services
{
    public class AdminService
    {
        private readonly ApplicationDbContext _db;
        public AdminService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task ClearDatabaseAsync()
        {
            _db.TourExhibits.RemoveRange(_db.TourExhibits);
            _db.ExhibitImages.RemoveRange(_db.ExhibitImages);
            _db.Feedbacks.RemoveRange(_db.Feedbacks);
            _db.Exhibits.RemoveRange(_db.Exhibits);
            _db.Tours.RemoveRange(_db.Tours);

            await _db.SaveChangesAsync();
        }
    }
}
