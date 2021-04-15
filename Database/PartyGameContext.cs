using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Database.Enums;

namespace Database
{
    public class PartyGameContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Status> Status { get; set; }
        
        public PartyGameContext(DbContextOptions<PartyGameContext> options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var pass = Cryptography.Encrypt("admin");

            var user = new User { Id = 1, Username = "Maintainer", Email="maintianer@partygame.com", Hash = pass, Role = Role.Admin };

            modelBuilder.Entity<User>().HasData(user);
            base.OnModelCreating(modelBuilder);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<User>()
                .HasOne(b => b.Status)
                .WithOne(b => b.User)
                .HasForeignKey<User>(b => b.StatusId);
        }
    }
}
