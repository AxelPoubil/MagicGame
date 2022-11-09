using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MTGO_lite.Models.Manas.ManaColors
{
    [DebuggerDisplay("{ColorName}({Quantity})")]
    public abstract class ManaColor
    {
        protected int quantity;

        public int Quantity { get => quantity; }
        public abstract string ColorName { get; }
        public abstract Bitmap Icon { get; }

        protected ManaColor(int quantity)
        {
            this.quantity = quantity;
        }

        public ManaColor(ManaColor manaColor)
        {
            this.quantity = manaColor.quantity;
        }

        public void Add(ManaColor mana)
        {
            this.quantity += mana.quantity;
        }

        public void Remove(ManaColor mana)
        {
            this.quantity -= mana.quantity;
        }

        public void Remove(int quantity)
        {
            this.quantity -= quantity;
        }

        public override string ToString()
        {
            return $"{ColorName}: {Quantity}";
        }
    }
}
