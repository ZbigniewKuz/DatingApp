using DatingAppp.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatingAppp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> users { get; set; }
    }
}
