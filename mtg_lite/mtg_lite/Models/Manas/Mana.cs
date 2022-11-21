using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTGO_lite.Models.Manas.ManaColors;

namespace MTGO_lite.Models.Manas
{
    public class Mana
    {
        private Dictionary<string, ManaColor> manaColors;
        public ManaColor White
        {
            get => manaColors[ManaWhite.Name];
        }
        public ManaColor Blue
        {
            get => manaColors[ManaBlue.Name];
        }
        public ManaColor Black
        {
            get => manaColors[ManaBlack.Name];
        }
        public ManaColor Red
        {
            get => manaColors[ManaRed.Name];
        }
        public ManaColor Green
        {
            get => manaColors[ManaGreen.Name];
        }
        public ManaColor Colorless
        {
            get => manaColors[ManaColorless.Name];
        }
        public Dictionary<string, ManaColor> ManaColors { get => manaColors; }

        public Mana(): this(0, 0, 0, 0, 0, 0)
        {
        }

        public Mana(int black, int blue, int green, int red, int white, int colorless)
        {
            manaColors = new Dictionary<string, ManaColor>()
            {
                { ManaBlack.Name, new ManaBlack(black)},
                { ManaBlue.Name, new ManaBlue(blue)},
                { ManaGreen.Name, new ManaGreen(green)},
                { ManaRed.Name, new ManaRed(red)},
                { ManaWhite.Name, new ManaWhite(white)},
                { ManaColorless.Name, new ManaColorless(colorless)},
            };
        }

        public event EventHandler<object>? manaChanged;

        public bool Compare(Mana manaCard,Mana manaJoueur)
        {
            //a modifier
            if (manaCard.Black.Quantity<=manaJoueur.Black.Quantity&&
                manaCard.White.Quantity<=manaJoueur.White.Quantity&&
                manaCard.Blue.Quantity <= manaJoueur.Blue.Quantity &&
                manaCard.Red.Quantity <= manaJoueur.Red.Quantity &&
                manaCard.Green.Quantity <= manaJoueur.Green.Quantity &&
                manaCard.Colorless.Quantity <= manaJoueur.Colorless.Quantity)
                
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void Pay(Mana manaToPay, Mana manaPlayer)
        {
            //a modifier
            manaPlayer.Black.Remove(manaToPay.Black.Quantity);
            manaPlayer.White.Remove(manaToPay.White.Quantity);
            manaPlayer.Red.Remove(manaToPay.Red.Quantity);
            manaPlayer.Blue.Remove(manaToPay.Blue.Quantity);
            manaPlayer.Green.Remove(manaToPay.Green.Quantity);
            manaPlayer.Colorless.Remove(manaToPay.Colorless.Quantity);
        }

        public void Add(Mana mana)
        {
            foreach (var manaColor in mana.manaColors)
            {
                manaColors[manaColor.Key].Add(manaColor.Value);
            }
            manaChanged?.Invoke(this, mana);
        }
    }
}
