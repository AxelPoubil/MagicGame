using mtg_lite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGO_lite.Models.Manas.ManaColors
{
    public class ManaWhite : ManaColor
    {
        public static string Name = "White";

        public override string ColorName => Name;
        public override Bitmap Icon => Resource.white_mana;

        public ManaWhite(int quantity) : base(quantity)
        {
        }
    }
}
