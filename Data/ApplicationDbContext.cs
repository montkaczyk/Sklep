﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using sklep.Models;

namespace sklep.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserModel>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<ProductViewModel> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Relacja między Order a Product (wiele-do-wielu)
            modelBuilder.Entity<Order>()
                .HasMany(o => o.Products)
                .WithMany()
                .UsingEntity(j => j.ToTable("OrderProducts"));

            // Relacja między Product a Category (jeden-do-wielu)
            modelBuilder.Entity<ProductViewModel>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);
        }
    }
}
