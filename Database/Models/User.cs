using Database.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Hash { get; set; }
        public Role Role { get; set; }
        public Status Status { get; set; }
        public int StatusId { get; set; }
    }
}
