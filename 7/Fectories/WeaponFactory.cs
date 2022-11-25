using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Fectories
{
    using System;
    using _7.Interface;
    using Enums;
   
    using Models.Weapons;

    public class WeaponFactory
    {
        public IWeapon CreateWeapon(string weaponKind, string weaponName, string weaponRarity)
        {
            WeaponEnum rarity;
            var isRarityValid = Enum.TryParse(weaponRarity, out rarity);// перевірка чи успішне перетворення перетворення по типу

            if (!isRarityValid)
            {
                return null;
            }

            switch (weaponKind)
            {

                case "Axe":
                    return new Axe(weaponName, rarity);
                case "Sword":
                    return new Sword(weaponName, rarity);
                case "Knife":
                    return new Knife(weaponName, rarity);
                default:
                    return null;
            }
        }
    }
}
