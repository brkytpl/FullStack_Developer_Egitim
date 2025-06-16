using coreuygulama.Models;
using Microsoft.EntityFrameworkCore;

namespace coreuygulama.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public virtual DbSet<Kitaplar>Kitaplars { get; set; }
        public virtual DbSet<Turler> Turlers { get; set; }
        public virtual DbSet<Yazarlar> Yazarlars { get; set; }

    }
}
