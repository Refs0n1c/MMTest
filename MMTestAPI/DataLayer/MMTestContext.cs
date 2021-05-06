using Microsoft.EntityFrameworkCore;
using MMTestAPI.DataLayer.Entities;
 
namespace MMTestAPI.DataLayer
{
    public class MMTestContext : DbContext
    {
        public MMTestContext(DbContextOptions<MMTestContext> options)
            : base(options)
        {
        }
 
        public DbSet<Customer> Customer { get; set; }
 
        public DbSet<Address> Address { get; set; }
    }
}