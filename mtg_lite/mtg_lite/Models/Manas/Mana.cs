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


        public bool Pay(Mana manaToPay, Mana manaPlayer)
        {
            bool resultat=false;
            foreach (var manaColor in manaToPay.manaColors)
            {
                string key = manaColor.Key;
                if (key!= "Colorless")
                {
                    if (manaToPay.manaColors[key] <= manaPlayer.manaColors[key]
                    && manaPlayer.manaColors[key] != 0 && manaToPay.manaColors[key] != 0)
                    {
                        manaColors[manaColor.Key].Remove(manaColor.Value);
                        manaChanged?.Invoke(this, manaPlayer);
                        resultat = true;
                        break;
                    }
                }
                else
                {
                    if (manaToPay.manaColors[key] <= manaPlayer.manaColors[key]
                    && manaPlayer.manaColors[key] != 0 && manaToPay.manaColors[key] != 0)
                    {
                        manaColors[manaColor.Key].Remove(manaColor.Value);
                        manaChanged?.Invoke(this, manaPlayer);
                        resultat = true;
                    }
                }
                
            }
            return resultat;
            
        }

        public void Add(Mana mana)
        {
            foreach (var manaColor in mana.manaColors)
            {
                manaColors[manaColor.Key].Add(manaColor.Value);
                manaColors["Colorless"].Add(manaColor.Value);
            }
            manaChanged?.Invoke(this, mana);
        }
    }
}
