using Database.Enums;
using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{

    public static class DbInitializer
    {
        public static void Initialize(PartyGameContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User { Username = "Maintainer", Email="maintianer@partygame.com", Hash="hash", Role = Role.Admin }
            };

            foreach (var user in users)
            {
                context.Users.Add(user);
            }
            context.SaveChanges();
        }
    }
}

