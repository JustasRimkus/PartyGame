using System.Collections.Generic;
using System.Threading.Tasks;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories
{
    public class AnswerRepository
    {
        private readonly PartyGameContext dbContext;

        public AnswerRepository(PartyGameContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task SaveAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        public async Task AddAsync(Answer answer)
        {
            await dbContext.Answers.AddAsync(answer);
        }

        public void Remove(Answer answer)
        {
            dbContext.Answers.Remove(answer);
        }

        public void Update(Answer answer)
        {
            dbContext.Answers.Update(answer);
        }
    }
}