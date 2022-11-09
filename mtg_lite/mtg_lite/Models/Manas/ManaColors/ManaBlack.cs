using mtg_lite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGO_lite.Models.Manas.ManaColors
{
    public class ManaBlack : ManaColor
    {
        public static string Name = "Black";

        public override string ColorName => Name;
        public override Bitmap Icon => Resource.black_mana;

        public ManaBlack(int quantity) : base(quantity)
        {
        }
    }
}
