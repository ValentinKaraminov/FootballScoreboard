using FootballGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame.Models
{
    public class AssistantReferee : Person, IReferee
    {
        public AssistantReferee(string name, int age) : base(name, age)
        {
        }
    }
}
