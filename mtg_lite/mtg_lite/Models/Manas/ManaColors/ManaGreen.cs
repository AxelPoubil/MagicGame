using mtg_lite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTGO_lite.Models.Manas.ManaColors
{
    public class ManaGreen : ManaColor
    {
        public static string Name = "Green";

        public override string ColorName => Name;
        public override Bitmap Icon => Resource.green_mana;

        public ManaGreen(int quantity) : base(quantity)
        {
        }
    }
}
