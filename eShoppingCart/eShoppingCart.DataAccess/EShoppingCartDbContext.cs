using eShoppingCart.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShoppingCart.DataAccess
{
    public class EShoppingCartDbContext : DbContext
    {
        public EShoppingCartDbContext(DbContextOptions<EShoppingCartDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable(nameof(Customer))
                        .HasKey(e => e.CustomerId).HasName("pk_customer_cutomerId").IsClustered(true);
            modelBuilder.Entity<Customer>().Property(x => x.CustomerId).UseIdentityColumn();
            modelBuilder.Entity<Customer>().HasMany(x => x.Orders).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId).HasConstraintName("fk_customer_customerid");
            modelBuilder.Entity<Customer>().HasMany(x => x.Addresses).WithOne(x => x.Customer).HasForeignKey(x => x.CustomerId).HasConstraintName("fk_customer_customerid");
            modelBuilder.Entity<Customer>().HasIndex(u => u.UserName).IsUnique(true).HasDatabaseName("uk_Customer_UserName");

            modelBuilder.Entity<Address>().ToTable(nameof(Address)).HasKey(x => x.AddressId).HasName("pk_Address_AddressId").IsClustered(true);
            modelBuilder.Entity<Address>().HasOne(a => a.Customer).WithMany(c => c.Addresses).OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
