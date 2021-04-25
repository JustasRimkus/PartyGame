using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Repositories
{
    public class QuestionRepository
    {
        private readonly PartyGameContext dbContext;

        public QuestionRepository(PartyGameContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task SaveAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        public async Task AddAsync(Question question)
        {
            await dbContext.Questions.AddAsync(question);
        }

        public async Task<List<Question>> GetQuestionsAsync()
        {
            return await dbContext.Questions.ToListAsync();
        }

        public void Remove(Question question)
        {
            dbContext.Questions.Remove(question);
        }

        public void Update(Question question)
        {
            dbContext.Questions.Update(question);
        }
    }
}
