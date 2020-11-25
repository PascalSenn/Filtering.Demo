using Microsoft.EntityFrameworkCore;

namespace Filtering.Demo
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; } = default!;

        public DbSet<Address> Addresses { get; set; } = default!;
    }
}