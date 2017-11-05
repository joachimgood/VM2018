using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VM2018.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public int HomeResult { get; set; }
        public int AwayResult { get; set; }

    }
}
