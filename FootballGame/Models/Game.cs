using FootballGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame.Models
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public IReferee Referee { get; set; }
        public List<IReferee> AssistantReferees { get; set; }
        public List<Goal> Goals { get; set; }
        public string Result { get; set; }
        public Team Winner { get; set; }
        public AssistantReferee AssistantReferee1 { get; }
        public AssistantReferee AssistantReferee2 { get; }

        

        public Game(Team team1, Team team2, Referee referee, AssistantReferee assistantReferee1, AssistantReferee assistantReferee2)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferee1 = assistantReferee1;
            AssistantReferee2 = assistantReferee2;
        }

        public void AddGoal(int minute, IFootballPlayer player)
        {
            Goal goal = new Goal(minute, player);
            Goals.Add(goal);
        }
        public void SetResult(string result)
        {
            Result = result;
        }
    }
}
