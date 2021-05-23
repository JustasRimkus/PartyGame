using System.Collections.Generic;
using System.Linq;
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

        public async Task<List<Answer>> GetAnswers(int questionId)
        {
            return await dbContext.Answers.Where(q => q.QuestionId == questionId).ToListAsync();
        }

        public async Task<Answer> GetAnswer(string answer)
        {
            return await dbContext.Answers.FirstOrDefaultAsync(q => q.Text == answer.Trim().ToLower());
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