using FootballGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame.Models
{
    public class Goal
    {
        public int Minute { get; set; }
        public IFootballPlayer Player { get; set; }

        public Goal(int minute, IFootballPlayer player)
        {
            Minute = minute;
            Player = player;
        }
    }
}
