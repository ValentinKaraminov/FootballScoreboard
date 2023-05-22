using FootballGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame.Models
{
    public class Referee : Person, IReferee
    {
        public Referee(string name, int age) : base(name, age)
        {
        }
    }
}
