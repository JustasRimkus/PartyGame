using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Database
{
    public class PartyGameContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public PartyGameContext(DbContextOptions<PartyGameContext> options) : base(options)
        {

        }
    }
}
