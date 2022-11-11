using mtg_lite.Models.Cards;
using mtg_lite.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    internal class Battlefield : Zone
    {
        public override string Name { get => "Battlefield"; }
        public Battlefield(List<Card> cards, Player player) : base(cards, player)
        {
        }
    }
}
