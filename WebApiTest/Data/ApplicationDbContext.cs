using Microsoft.EntityFrameworkCore;
using WebApiTest.Model;

namespace WebApiTest.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
