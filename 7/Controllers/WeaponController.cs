using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.NetworkInformation;
    using System.Text;
    using _7.Fectories;
    using _7.Interface;


    public class WeaponController
    {
        private IList<IWeapon> weapons;
        private WeaponFactory weaponFactory;

        public WeaponController()
        {
            this.weapons = new List<IWeapon>();
            this.weaponFactory = new WeaponFactory();
        }

        public void CreateWeapon(string weaponKind, string weaponName, string weaponRarity)
        {
            var weapon = this.weaponFactory.CreateWeapon(weaponKind, weaponName, weaponRarity);
           
            if (weapon != null)
            {
               
                this.weapons.Add(weapon);
            }
        }

        public string GetWeapons()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < weapons.Count; i++)
            {
                sb.AppendLine(weapons[i].ToString());
                
            }
           
            return sb.ToString();
        }

        public void AddGemToWeapon(string weaponName, int socketIndex, IGem gem)
        {
          

            if (this.GetWeapen(weaponName) != null)
            {
               


                this.GetWeapen(weaponName).AddGem(gem, socketIndex);
            }

        }


       public void RemoveGemFromWeapon(string weaponName, int socketIndex)
        {
            if (this.GetWeapen(weaponName) != null) {
                this.GetWeapen(weaponName).RemoveGem(socketIndex); 
        }
        }
        public IWeapon GetWeapen(string weaponName)
        { return this.weapons.FirstOrDefault(w => w.Name == weaponName);
        }

    }
}
