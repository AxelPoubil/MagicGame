using mtg_lite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGO_lite.Models.Manas.ManaColors
{
    public class ManaRed : ManaColor
    {
        public static string Name = "Red";

        public override string ColorName => Name;
        public override Bitmap Icon => Resource.red_mana;

        public ManaRed(int quantity) : base(quantity)
        {
        }
    }
}
