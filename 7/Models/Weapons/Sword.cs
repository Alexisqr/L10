using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Models.Weapons
{

    using Enums;

    public class Sword : Weapon
    {
        private  const int MaxDamage = 6;
        private  const int MinDamage = 4;
        private  const int GemSockets = 3;

        public Sword(string name, WeaponEnum rarity)
            : base(name, rarity, MaxDamage, MinDamage, GemSockets)
        {
        }
    }
}
