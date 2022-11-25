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

    using Models.Gems;

    public class GemFactory
    {
        public IGem CreateGem(string kind, string clarity)
        {
            GemEnum Clarity;
            var isGemValid = Enum.TryParse(clarity, out Clarity);// перевірка чи успішне перетворення перетворення по типу

            if (!isGemValid)
            {
                return null;
            }

            switch (kind)
            {
                case "Ruby":
                    return new Ruby(Clarity);
                case "Emerald":
                    return new Emerald(Clarity);
                case "Amethyst":
                    return new Amethyst(Clarity);
                default:
                    return null;
            }
        }
    }
}
