using Microsoft.EntityFrameworkCore;

namespace Workspace
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyDbContext).Assembly);

            modelBuilder.Entity<Customer>()
                        .Property(c => c.Name)
                        .HasMaxLength(50)
                        .IsRequired();
        }
    }
}
