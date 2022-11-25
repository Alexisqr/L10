using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Models.Weapons
{
    using Enums;

    public class Axe : Weapon
    {
        private  const int MaxDamage = 10;
        private  const int MinDamage = 5;
        private  const int GemSockets = 4;

        public Axe(string name, WeaponEnum rarity)
            : base(name, rarity, MaxDamage, MinDamage, GemSockets)
        {
        }
    }
}
