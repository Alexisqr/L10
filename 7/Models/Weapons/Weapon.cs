using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Models.Weapons
{
    using System.Linq;
    using _7.Interface;
    using Enums;


    public abstract class Weapon : IWeapon
    {
        protected Weapon(string name, WeaponEnum rarity, int maxDamage, int minDamage, int NGemSockets)
        {
            this.Name = name;
            this.Rarity = rarity;
            this.MaxDamage = maxDamage * (int)rarity;
            this.MinDamage = minDamage * (int)rarity;
            this.GemSockets = new IGem[NGemSockets];
        }

        public string Name { get; }

        public int MaxDamage { get; private set; }

        public int MinDamage { get; private set; }

        public WeaponEnum Rarity { get; private set; }

        public IGem[] GemSockets { get; private set; }

        public void AddGem(IGem gem, int socketIndex)

        {
            Console.WriteLine("------");
            if (socketIndex < 0 || socketIndex >= this.GemSockets.Length)
            {
                return;
            }
          
            this.GemSockets[socketIndex] = gem;
        }

        public void RemoveGem(int socketIndex)
        {
            if (socketIndex < 0 || socketIndex >= this.GemSockets.Length)
            {
                return;
            }

            this.GemSockets[socketIndex] = null;
        }
        public override string ToString()
        {
            var strength = this.GemSockets.Where(g => g != null).Select(g => g.Strength).Sum();
            var agility = this.GemSockets.Where(g => g != null).Select(g => g.Agility).Sum();
            var vitality = this.GemSockets.Where(g => g != null).Select(g => g.Vitality).Sum();

            var minDamage = this.MinDamage + (strength * 2) + agility;
            var maxDamage = this.MaxDamage + (strength * 3) + (agility * 4);

            return $"{this.Name}: {minDamage}-{maxDamage} Damage, +{strength} Strength, +{agility} Agility, +{vitality} Vitality";
        }
    }
}