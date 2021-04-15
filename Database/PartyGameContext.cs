using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;

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
            modelBuilder.Entity<User>()
                .HasOne(b => b.Status)
                .WithOne(b => b.User)
                .HasForeignKey<User>(b => b.StatusId);
        }
    }
}
