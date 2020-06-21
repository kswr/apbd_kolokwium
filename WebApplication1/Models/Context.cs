using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class Context : DbContext
    {
        public Context() { }

        public Context(DbContextOptions options) : base(options) { }
        public System.Data.Entity.DbSet<Artist> Artists { get; set; }
        public System.Data.Entity.DbSet<Organiser> Organisers { get; set; }
        public System.Data.Entity.DbSet<Event> Events { get; set; }
    }
}