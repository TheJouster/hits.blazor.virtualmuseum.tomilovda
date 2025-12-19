using Microsoft.EntityFrameworkCore;
using VirtualMuseum.Data;
using VirtualMuseum.Models;


namespace VirtualMuseum.Services
{
    public class ExhibitService
    {
        private readonly ApplicationDbContext _db;
        public ExhibitService(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<List<Exhibit>> GetAllAsync() => await _db.Exhibits.ToListAsync();
        public async Task AddExhibitAsync(Exhibit exhibit)
        {
            exhibit.Id = 0;
            _db.Exhibits.Add(exhibit);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Exhibit exhibit)
        {
            _db.Exhibits.Update(exhibit);
            await _db.SaveChangesAsync();
        }

        public async void DeleteAsync(int id)
        {
            var exhibit = await _db.Exhibits.FindAsync(id);
            if (exhibit == null) return;

            _db.Exhibits.Remove(exhibit);
            await _db.SaveChangesAsync();
        }
    }
}
