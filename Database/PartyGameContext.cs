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
            Question[] question =new Question[] { new Question { Id = 1, Text = "Name a House You Never Want to Be In: " },
                                                   new Question { Id = 2, Text = "Name Something Associated with Vampires: " },
                                                   new Question { Id = 3, Text = "Name Something in a Bakery a Baker Might Call His Wife: " },
                                                   new Question { Id = 4, Text = "Tell Me A Word That Rhymes with “Election”: " },
                                                   new Question { Id = 5, Text = "Name Something Snowmen Might Have Nightmares About: " }
            };
            Answer[] anwers = new Answer[] { new Answer { QuestionId = 1, Popularity = 27, Text = "Haunted House", Id = 1 },
                                            new Answer { QuestionId = 1, Popularity = 11, Text = "Jail", Id = 2 },
                                            new Answer { QuestionId = 1, Popularity = 8, Text = "Doghouse", Id = 3 },
                                            new Answer { QuestionId = 1, Popularity = 7, Text = "Drug House", Id = 4 },
                                            new Answer { QuestionId = 1, Popularity = 7, Text = "Small House", Id = 5 },
                                            new Answer { QuestionId = 1, Popularity = 6, Text = "Glass House", Id = 6 },
                                            new Answer { QuestionId = 1, Popularity = 5, Text = "Cat House", Id = 7 },
                                            new Answer { QuestionId = 1, Popularity = 5, Text = "Outhouse", Id = 8 },

                                            new Answer { QuestionId = 2, Popularity = 33, Text = "Twilight", Id = 9 },
                                            new Answer { QuestionId = 2, Popularity = 29, Text = "Blood", Id = 10 },
                                            new Answer { QuestionId = 2, Popularity = 9, Text = "Garlic", Id = 11},
                                            new Answer { QuestionId = 2, Popularity = 7, Text = "Bat", Id = 12 },
                                            new Answer { QuestionId = 2, Popularity = 7, Text = "Cape", Id = 13 },
                                            new Answer { QuestionId = 2, Popularity = 5, Text = "Dracula", Id = 14 },
                                            new Answer { QuestionId = 2, Popularity = 4, Text = "Fangs", Id = 15 },
                                            new Answer { QuestionId = 2, Popularity = 4, Text = "Halloween", Id = 16 },

                                            new Answer { QuestionId = 3, Popularity = 32, Text = "Buns", Id = 17 },
                                            new Answer { QuestionId = 3, Popularity = 9, Text = "His Oven", Id = 18 },
                                            new Answer { QuestionId = 3, Popularity = 9, Text = "Sweetie", Id = 19},
                                            new Answer { QuestionId = 3, Popularity = 8, Text = "Cupcake", Id = 20 },
                                            new Answer { QuestionId = 3, Popularity = 7, Text = "Muffin", Id = 21 },
                                            new Answer { QuestionId = 3, Popularity = 5, Text = "Sugar", Id = 22 },
                                            new Answer { QuestionId = 3, Popularity = 5, Text = "Donut", Id = 23 },
                                            new Answer { QuestionId = 3, Popularity = 4, Text = "Doughy", Id = 24 },

                                            new Answer { QuestionId = 4, Popularity = 32, Text = "Selection", Id = 25 },
                                            new Answer { QuestionId = 4, Popularity = 23, Text = "Erection", Id = 26 },
                                            new Answer { QuestionId = 4, Popularity = 6, Text = "Perfection", Id = 27},
                                            new Answer { QuestionId = 4, Popularity = 6, Text = "Detection", Id = 28 },
                                            new Answer { QuestionId = 4, Popularity = 5, Text = "Protection", Id = 29 },
                                            new Answer { QuestionId = 4, Popularity = 4, Text = "Rejectionr", Id = 30 },
                                            new Answer { QuestionId = 4, Popularity = 4, Text = "Collection", Id = 31 },
                                            new Answer { QuestionId = 4, Popularity = 4, Text = "Section", Id = 32 },

                                            new Answer { QuestionId = 5, Popularity = 62, Text = "Sun", Id = 33 },
                                            new Answer { QuestionId = 5, Popularity = 14, Text = "Fire", Id = 34 },
                                            new Answer { QuestionId = 5, Popularity = 3, Text = "Blow Dryers", Id = 35},
                                            new Answer { QuestionId = 5, Popularity = 3, Text = "Rain", Id = 36 },
                                            new Answer { QuestionId = 5, Popularity = 3, Text = "Shovel", Id = 37 },
                                            new Answer { QuestionId = 5, Popularity = 2, Text = "Drought", Id = 38 },
                                            new Answer { QuestionId = 5, Popularity = 2, Text = "Snowballs", Id = 39 },
                                            new Answer { QuestionId = 5, Popularity = 2, Text = "Peeing Dogs", Id = 40 }

            };


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
            modelBuilder.Entity<Question>().HasData(question);
            modelBuilder.Entity<Answer>().HasData(anwers);
            base.OnModelCreating(modelBuilder);
        }
    }
}
