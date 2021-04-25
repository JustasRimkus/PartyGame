using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories
{
    public class UserRepository
    {
        private readonly PartyGameContext dbContext;

        public UserRepository(PartyGameContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task SaveAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        public async Task AddAsync(User user)
        {
            await dbContext.Users.AddAsync(user);
        }

        public async Task<User> GetUserAsync(string email)
        {
            return await dbContext.Users.FirstOrDefaultAsync(q => EF.Functions.Like(q.Email, email));
        }

        public void Remove(User user)
        {
            dbContext.Users.Remove(user);
        }

        public void Update(User user)
        {
            dbContext.Users.Update(user);
        }
    }
}
