using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards
{
    public class Creature : Card
    {
        public Creature(string name, Mana manaCost, Bitmap picture, bool isPermanent) : base(name, manaCost, picture, isPermanent)
        {

        }

        public static Creature CreerCarte(string name)
        {
            switch (name)
            {
                case "Savannah Lions":
                    return new Creature(name, new Mana(0, 0, 0, 0, 1, 0), Resource.savannah_lions, true);
                case "Scathe Zombies":
                    return new Creature(name, new Mana(1, 0, 0, 0, 0, 2), Resource.scathe_zombies, true);
                case "Spinned Karok":
                    return new Creature(name, new Mana(0, 0, 1, 0, 0, 2), Resource.spinned_karok, true);
                default:
                    return null;
            }
        }
    }
}
