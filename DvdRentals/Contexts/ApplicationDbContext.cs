using DvdRentals.Helpers;
using DvdRentals.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DvdRentals.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<ConditionType> ConditionTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Distributor> Distributors { get; set; }
        public DbSet<Dvd> Dvds { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentStatus> PaymentStatuses { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<RentalDvd> RentalDvds { get; set; }
        public DbSet<RentalStatus> RentalStatuses { get; set; }
        public DbSet<Store> Stores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RentalDvd>().HasKey(m => new { m.DvdId, m.RentalId });


            modelBuilder.Entity<Payment>()
                .HasOne(m => m.Rental)
                .WithMany(m => m.Payments)
                .HasForeignKey(m => m.RentalId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<RentalDvd>()
                .HasOne(m => m.Rental)
                .WithMany(m => m.Dvds)
                .HasForeignKey(m => m.RentalId)
                .OnDelete(DeleteBehavior.NoAction);

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<BaseModel>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "System"; // To be fixed for current user context later
                        entry.Entity.CreatedAt = DateTime.UtcNow;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = "System"; // To be fixed for current user context later
                        entry.Entity.ModifiedAt = DateTime.UtcNow;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

    }
}
