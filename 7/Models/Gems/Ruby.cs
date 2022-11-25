using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Models.Gems
{
    using Enums;

    public class Ruby : Gem
    {
        private  const int Agility = 2;
        private  const int Strength = 7;
        private  const int Vitality = 5;

        public Ruby(GemEnum clarity)
            : base(clarity, Agility, Strength, Vitality)
        {
        }
    }
}
