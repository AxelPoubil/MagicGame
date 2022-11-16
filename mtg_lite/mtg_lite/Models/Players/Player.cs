using mtg_lite.Models.Cards;
using mtg_lite.Models.Zones;
using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Players
{
    public class Player
    {
        private Mana manaPool;
        private Zone battlefield;
        private Zone graveyard;
        private Zone hand;
        private Zone library;

        public Mana ManaPool { get => manaPool; }
        public Zone Battlefield { get => battlefield; }
        public Zone Graveyard { get => graveyard; }
        public Zone Hand { get => hand; }
        public Zone Library { get => library; }

        public Player(string libraryName)
        {
            manaPool = new Mana();
            battlefield = new Battlefield(new List<Card>(), this);
            graveyard = new Graveyard(new List<Card>(), this);
            hand = new Hand(new List<Card>(), this);
            this.library = new Library(LibraryManager.GetCards(libraryName), this);
            Subscribe();
        }

        public void Subscribe()
        {
            library.CardRemoved += Library_CardRemoved;
            hand.CardRemoved += Hand_CardRemoved;
        }

        private void Hand_CardRemoved(object? sender, Card card)
        {
            
            if (card.IsPermanent)
            {
                battlefield.AddCard(card);
            }
            else
            {
                graveyard.AddCard(card);
            }
        }

        private void Library_CardRemoved(object? sender, Cards.Card card)
        {
            hand.AddCard(card);
        }

        public void PlayCard(Card card)
        {
        }
    }
}
