using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradeAPI.DataAccess.Models;

namespace TradeAPI.DataAccess.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users;
        public DbSet<Security> Securities;
        public DbSet<Trade> Trades;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Id).ValueGeneratedOnAdd();

                entity.HasData(
                    new User(1, "Alex"),
                    new User(2, "George")
                    );
            });

            modelBuilder.Entity<Security>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Id).ValueGeneratedOnAdd();
                entity.Property(u => u.SecurityCode).HasMaxLength(4);

                entity.HasData(
                    new Security(1, "MSFT", 10.0),
                    new Security(1, "AAPL", 12.0),
                    new Security(1, "GOOG", 15.0)
                    );
            });

            modelBuilder.Entity<Trade>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Id).ValueGeneratedOnAdd();

                entity.HasData(
                    new Trade(10.0, 3, new DateTime(2022, 03, 01), 1, 1),
                    new Trade(11.0, 1, new DateTime(2022, 03, 01), 2, 1),
                    new Trade(16.0, 2, new DateTime(2022, 03, 01), 3, 1),

                    new Trade(9.5, 2, new DateTime(2022, 02, 01), 1, 2),
                    new Trade(12.0, 2, new DateTime(2022, 02, 01), 2, 2),
                    new Trade(15.0, 3, new DateTime(2022, 02, 01), 3, 3)
                    );
            });
        }
    }
}
