using mtg_lite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGO_lite.Models.Manas.ManaColors
{
    public class ManaBlue : ManaColor
    {
        public static string Name = "Blue";

        public override string ColorName => Name;
        public override Bitmap Icon => Resource.blue_mana;

        public ManaBlue(int quantity) : base(quantity)
        {
        }
    }
}
