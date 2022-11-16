using mtg_lite.Models.Cards;
using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    public static class LibraryManager
    {
        private static Dictionary<string, List<Card>> libraries = new Dictionary<string, List<Card>>();

        static LibraryManager()
        {
            libraries.Add("Red", new List<Card>()
            {
                Sorcery.CreerCarte("False Peace"),
                Sorcery.CreerCarte("Gaea's Blessing"),
                Sorcery.CreerCarte("Glimpse The Unthinkable"),
                Land.CreerCarte("Swamp"),
                Land.CreerCarte("Plains"),
                Land.CreerCarte("Mountain"),
                Creature.CreerCarte("Savannah Lions"),
                Creature.CreerCarte("Scathe Zombies"),
                Creature.CreerCarte("Spinned Karok"),
                Creature.CreerCarte("Spinned Karok"),
                new Models.Cards.CardBacks.CardBack()
            });
            libraries.Add("Blue", new List<Card>()
            {
                
            });
            libraries.Add("Green", new List<Card>()
            {
               
            });

        }

        public static List<Card> GetCards(string libraryName)
        {
            if (libraries.ContainsKey(libraryName))
            {
                return libraries[libraryName];
            }
            return new List<Card>();
        }




    }
}
