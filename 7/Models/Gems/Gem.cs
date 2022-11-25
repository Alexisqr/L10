using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Models
{
    using Enums;
    using Interface;

    public abstract class Gem : IGem
    {
        public Gem(GemEnum clarity, int agility, int strength, int vitality)
        {
            this.Clarity = clarity;
            this.Agility = agility + (int)clarity;
          
            this.Strength = strength + (int)clarity;
            this.Vitality = vitality + (int)clarity;
        }

        public GemEnum Clarity { get; private set; }

        public int Agility { get; private set; }

        public int Strength { get; private set; }

        public int Vitality { get; private set; }
    }
}
