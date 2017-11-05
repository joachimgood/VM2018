using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VM2018.Models
{
    public class Bet
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int HomeResultBet { get; set; }
        public int AwayResultBet { get; set; }
        public int UserId { get; set; }

    }
}
