using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VM2018.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Points { get; set; }
        public IEnumerable<Bet> Bets { get; set; }

    }
}
