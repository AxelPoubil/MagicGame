using mtg_lite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGO_lite.Models.Manas.ManaColors
{
    public class ManaColorless : ManaColor
    {
        public static string Name = "Colorless";

        public override string ColorName => Name;
        public override Bitmap Icon => Resource.colorless_mana;

        public ManaColorless(int quantity) : base(quantity)
        {
        }
    }
}
