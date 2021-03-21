using System;
using System.Collections.Generic;
using System.Text;

namespace PartyGame
{
    public static class UniqGenerator
    {
        static public string GenerateKey()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            const string pool = "QWERTYUIOPASDFGHJKLZXCVBNM0123456789";
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < 6; i++)
            {
                var ch = pool[random.Next(0, pool.Length)];
                builder.Append(ch);
            }
            return builder.ToString();
        }

        static public string GenerateName() 
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            const string pool = "0123456789";
            StringBuilder builder = new StringBuilder("CoolName");
            for (int i = 0; i < 3; i++)
            {
                var ch = pool[random.Next(0, pool.Length)];
                builder.Append(ch);
            }
            return builder.ToString();
        }
    }
}