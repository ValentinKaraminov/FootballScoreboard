﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame.Models
{
    public class Defender : FootballPlayer
    {
        public Defender(string name, int age, int number, double height) : base(name, age, number, height)
        {
        }
    }
}
