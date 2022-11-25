using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Models.Weapons
{
    using Enums;

    public class Knife : Weapon
    {
        private const int MaxDamage = 4;
        private const int MinDamage = 3;
        private const int GemSockets = 2;

        public Knife(string name, WeaponEnum rarity)
            : base(name, rarity, MaxDamage, MinDamage, GemSockets)
        {
        }
    }
}
