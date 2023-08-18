using Microsoft.EntityFrameworkCore;
using MachineTestAssignment2.Models;

namespace MachineTestAssignment2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //put our configuration

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(a => a.Id);

                entity.Property(a => a.Name).IsRequired();

            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(a => a.ProductId);

                entity.Property(a => a.ProductName).IsRequired();

                entity.HasOne(a => a.Category).WithMany(p => p.Products)
                      .HasForeignKey(p => p.CategoryId)
                      .OnDelete(DeleteBehavior.NoAction);

            });
        }

    }
}
