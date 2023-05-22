using FootballGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame.Models
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<IFootballPlayer> Players { get; }
        public double AverageAge => CalculateAverageAge();

        public Team(Coach coach)
        {
            Coach = coach;
            Players = new List<IFootballPlayer>();
        }

        public void AddPlayer(IFootballPlayer player)
        {
            Players.Add(player);
        }

        private double CalculateAverageAge()
        {
            if (Players.Count == 0)
                return 0;

            int totalAge = 0;
            foreach (var player in Players)
            {
                totalAge += player.Age;
            }

            return (double)totalAge / Players.Count;
        }
    }
}
