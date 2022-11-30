﻿using mtg_lite.Models.Cards;
using mtg_lite.Models.Cards.CardBacks;
using mtg_lite.Models.Players;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Zones
{
    public class Zone
    {
        protected List<Card> cards;
        protected Player player;

        public virtual List<Card> Cards { get { return cards; } }
        public virtual string Name { get => "Zone"; }
        public virtual Card TopCard {
            get
            {
                if (cards.Count == 1 && Name == "Library" || cards.Count == 0)
                {
                    return new DarkCardBack();
                }
                return cards[cards.Count-1];
            }
        }

        public virtual event EventHandler<List<Card>>? CardsChanged;
        public virtual event EventHandler<Card>? CardAdded;
        public virtual event EventHandler<Card>? CardRemoved;

        public Zone(List<Card> cards, Player player)
        {
            this.cards = cards;
            this.player = player;
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
            CardAdded?.Invoke(this, card);
            CardsChanged?.Invoke(this, cards);
        }

        public  void  RemoveCard(Card cardToRemove)
        {
            CardRemoved?.Invoke(this, cardToRemove);
            var index = cards.FindIndex(card => card == cardToRemove);
            cards.RemoveAt(index);
            CardsChanged?.Invoke(this, cards);
        }

        public override string ToString()
        {
            return $"{Name} ({cards.Count})";
        }
        public virtual void CliquerCard(Card card)
        {
        }
    }
}
