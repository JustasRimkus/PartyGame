using System;
using System.Collections.Generic;
using System.Text;

namespace PartyGame
{
    public class UniqKey
    {
        private static Random random = new Random();

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
    }
}