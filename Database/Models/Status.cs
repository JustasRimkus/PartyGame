using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class Status
    {
        public int Id { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public int WinningPrecentage { get; set; }
        public int AVGGameScore { get; set; }
        public int BestGame { get; set; }
        public int BestRound { get; set; }
        public User User { get; set; }
    }
}
