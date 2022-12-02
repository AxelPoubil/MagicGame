using mtg_lite.Models.Cards;
using mtg_lite.Models.Cards.CardBacks;
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
        public override Card TopCard
        {
            get
            {
                if (cards.Count == 0 && Name == "Library" || cards.Count == 0)
                {
                    return new DarkCardBack();
                }
                else
                {
                    return new CardBack();
                }
            }
        }
        public Library(List<Card> cards, Player player) : base(cards, player)
        {
            this.cards=MelangerCarte();
        }

        

        public override string ToString()
        {
            return $"{Name} ({cards.Count})";
        }


        public List<Card> MelangerCarte()
        {
            List<Card> shuffleCard= new List<Card>();
            for (int index = 0;  index < cards.Count;)
            {
                int randome = random.Next(0, cards.Count);
                Card cardToShuffle = cards[randome];
                shuffleCard.Add(cardToShuffle);
                cards.RemoveAt(randome);
            }
            return shuffleCard;
        }
        public override void CliquerCard(Card card)
        {
            Card cradToRemove = this.cards.Last();
            this.RemoveCard(cradToRemove);
        }

    }
}
