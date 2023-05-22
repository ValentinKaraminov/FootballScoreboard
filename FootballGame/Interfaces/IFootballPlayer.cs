using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame.Interfaces
{
    public interface IFootballPlayer
    {
        string Name { get; set; }
        int Number { get; set; }
        int Age { get; set; }
        double Height { get; set; }
    }
}
