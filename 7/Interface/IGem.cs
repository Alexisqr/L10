using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Interface
{
    using Enums;

    public interface IGem
    {
        GemEnum Clarity { get; }

        int Agility { get; }

        int Strength { get; }

        int Vitality { get; }
    }
}
