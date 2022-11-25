using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Models.Gems
{
    using Enums;

    public class Amethyst : Gem
    {
        private  const int Agility = 8;
        private  const int Strength = 2;
        private  const int Vitality = 4;

        public Amethyst(GemEnum clarity)
            : base(clarity, Agility, Strength, Vitality)
        {
        }
    }
}
