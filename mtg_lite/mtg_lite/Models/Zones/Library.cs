using mtg_lite.Models.Cards;
using mtg_lite.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    internal class Library : Zone
    {
        Random random = new Random();
        public override string Name { get => "Library"; }
        public Library(List<Card> cards, Player player) : base(cards, player)
        {
            this.cards=MelangerCarte();
        }

        

        public override string ToString()
        {
            return $"{Name} ({cards.Count - 1})";
        }


        public List<Card> MelangerCarte()
        {
            List<Card> shuffleCard= new List<Card>();
            for (int index = 0;  index < cards.Count;)
            {
                int randome = random.Next(0, cards.Count - 1);
                Card cardToShuffle = cards[randome];
                shuffleCard.Add(cardToShuffle);
                cards.RemoveAt(randome);
            }
            return shuffleCard;
        }

    }
}
