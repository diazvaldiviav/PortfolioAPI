using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Clients> Clients { get; set; }
        public DbSet<GeneralInfo> Informations { get; set; }
        public DbSet<Contacto> contacto { get; set; }
        public DbSet<Projects> projects { get; set; }
        public DbSet<Users> users { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
