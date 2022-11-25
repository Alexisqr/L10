using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Models.Gems
{
    using Enums;

    public class Emerald : Gem
    {
        private  const int Agility = 4;
        private  const int Strength = 1;
        private  const int Vitality = 9;

        public Emerald(GemEnum clarity)
            : base(clarity, Agility, Strength, Vitality)
        {
        }
    }
}
