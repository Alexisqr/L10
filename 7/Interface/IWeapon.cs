using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Interface
{
    using Enums;

    public interface IWeapon
    {
        string Name { get; }

        int MaxDamage { get; }

        int MinDamage { get; }

        WeaponEnum Rarity { get; }

        IGem[] GemSockets { get; }

        void AddGem(IGem gem, int socketIndex);

        void RemoveGem(int socketIndex);
    }
}
