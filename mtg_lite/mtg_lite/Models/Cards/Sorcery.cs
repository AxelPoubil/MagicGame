using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards
{
    public class Sorcery : Card
    {
        public Sorcery(string name, Mana manaCost, Bitmap picture, bool isPermanent) : base(name, manaCost, picture, isPermanent)
        {
            
        }

        public static Sorcery CreerCarte(string name)
        {
            switch (name)
            {
                case "False Peace":
                    return new Sorcery(name, new Mana(0, 0, 0, 0, 1, 0), Resource.false_peace, false);
                case "Gaea's Blessing":
                    return new Sorcery(name, new Mana(0, 0, 1, 0, 0, 1), Resource.gaea_s_blessing, false);
                case "Glimpse The Unthinkable":
                    return new Sorcery(name, new Mana(1, 1, 0, 0, 0, 0), Resource.glimpse_the_unthinkable, false);
                default:
                    return null;
            }            
        }
    }
}
