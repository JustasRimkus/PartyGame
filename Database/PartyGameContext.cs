using Database.Models;
using Microsoft.EntityFrameworkCore;
using Database.Enums;

namespace Database
{
    public class PartyGameContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Answer> Answers { get; set; }

        public PartyGameContext(DbContextOptions<PartyGameContext> options) : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var pass = HashInfrastructure.Hash("admin");

            var user = new User { Id = 1, Username = "Maintainer", Email = "maintianer@partygame.com", Hash = pass, Role = Role.Admin, StatusId = 1 };
            var status = new Status { Id = 1 };

            modelBuilder.Entity<User>()
                .HasOne(b => b.Status)
                .WithOne(b => b.User)
                .HasForeignKey<User>(b => b.StatusId);

            modelBuilder.Entity<Question>()
                .HasMany(q => q.Answers)
                .WithOne(q => q.Question)
                .HasForeignKey(q => q.QuestionId);

            modelBuilder.Entity<Status>().HasData(status);
            modelBuilder.Entity<User>().HasData(user);
            base.OnModelCreating(modelBuilder);
        }
    }
}
