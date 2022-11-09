using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards
{
    public class Land : Card
    {
        public Land(string name, Mana manaCost, Bitmap picture, bool isPermanent) : base(name, manaCost, picture, isPermanent)
        {

        }

        public static Land CreerCarte(string name)
        {
            switch (name)
            {
                case "Swamp":
                    return new Land(name, new Mana(1, 0, 0, 0, 0, 0), Resource.swamp, true);
                case "Plains":
                    return new Land(name, new Mana(0, 0, 0, 0, 1, 0), Resource.plains, true);
                case "Mountain":
                    return new Land(name, new Mana(0, 0, 0, 1, 0, 0), Resource.mountain, true);
                default:
                    return null;
            }
        }
    }
}
