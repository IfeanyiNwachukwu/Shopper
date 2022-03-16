using Ifeanyi.Services.productAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Ifeanyi.Services.productAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
