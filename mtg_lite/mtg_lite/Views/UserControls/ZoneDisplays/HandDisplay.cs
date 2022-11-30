using mtg_lite.Models.Zones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mtg_lite.Views.UserControls.ZoneDisplays
{
    public partial class HandDisplay : UserControl
    {
        private Zone? hand;

        public Zone? Hand { get => hand; set => ChangeHand(value); }

        public HandDisplay()
        {
            InitializeComponent();
        }

        private void ChangeHand(Zone? newHand)
        {
            HandUnsubscribe();
            hand = newHand;
            DisplayHand();
            HandSubscribe();
        }

        private void DisplayHand()
        {
            if (hand is null) { return; }
            grpHand.Text = hand.ToString();
            rowOfCardsDisplay.Cards = hand.Cards;
        }

        private void HandUnsubscribe()
        {
            if (hand is null) { return; }
            hand.CardsChanged -= Hand_CardsChanged;
        }

        private void HandSubscribe()
        {
            if (hand is null) { return; }
            hand.CardsChanged += Hand_CardsChanged; ;
        }

        private void Hand_CardsChanged(object? sender, List<Models.Cards.Card> cards)
        {
            DisplayHand();
        }

        private void rowOfCardsDisplay_CardClicked(object sender, Models.Cards.Card card)
        {
            try
            {
                hand.CliquerCard(card);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Pas assez de mana");
            }
           
        }
    }
}
