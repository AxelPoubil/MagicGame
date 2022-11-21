using mtg_lite.Models.Cards;
using mtg_lite.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    internal class Hand : Zone
    {
        public override string Name { get => "Hand"; }
        public Hand(List<Card> cards, Player player) : base(cards, player)
        {
        }

        public override void RemoveCard(Card cardToRemove)
        {
            // a modifier
            if (player.ManaPool.Compare(cardToRemove.ManaCost,player.ManaPool)==true)
            {
                player.ManaPool.Pay(cardToRemove.ManaCost,player.ManaPool);
                base.RemoveCard(cardToRemove);
            }
        }

    }
}
