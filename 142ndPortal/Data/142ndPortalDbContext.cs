using _142ndPortal.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace _142ndPortal.Data
{
    public class _142ndPortalDbContext : DbContext
    {
        public _142ndPortalDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<RSVP> RSVP { get; set; }
        
    }
}
