using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VirtualMuseum.Models;

namespace VirtualMuseum.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<Exhibit> Exhibits => Set<Exhibit>();
        public virtual DbSet<Tour> Tours => Set<Tour>();
        public virtual DbSet<ExhibitImage> ExhibitImages => Set<ExhibitImage>();
        public virtual DbSet<Feedback> Feedbacks => Set<Feedback>();
        public virtual DbSet<TourExhibit> TourExhibits => Set<TourExhibit>();


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TourExhibit>().HasKey(te => new { te.TourId, te.ExhibitId });
        }
    }
}
