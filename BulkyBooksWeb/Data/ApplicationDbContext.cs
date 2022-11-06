using BulkyBooksWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BulkyBooksWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
