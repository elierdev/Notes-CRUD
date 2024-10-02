using CRUD_ASPNET.Models;
using Microsoft.EntityFrameworkCore;


namespace CRUD_ASPNET.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Nota> Notas { get; set; }
    }
}
