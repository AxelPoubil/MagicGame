using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards.CardBacks
{
    public class CardBack: Card
    {
        public CardBack() : base("Card Back", new Mana(), Resource.card_back)
        {
        }
    }
}
