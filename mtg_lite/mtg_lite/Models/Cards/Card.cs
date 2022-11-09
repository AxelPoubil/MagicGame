using MTGO_lite.Models.Manas;
using MTGO_lite.Models.Manas.ManaColors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtg_lite.Models.Cards
{
    [DebuggerDisplay("{Name}")]
    public class Card
    {
        private string name;
        private Mana manaCost;
        private Bitmap picture;
        private bool tapped;
        private Guid guid;
        private bool isPermanent;

        public string Name { get => name; }
        public Bitmap Picture { get => picture; }
        public bool Tapped { get => tapped; set => ChangeTapped(value); }
        public Mana ManaCost { get => manaCost; }
        public virtual bool IsPermanent { get => isPermanent; set => isPermanent = value; }

        public event EventHandler<bool>? TappedChanged;

        public Card(string name, Mana manaCost, Bitmap picture, bool isPermanent)
        {
            this.name = name;
            this.manaCost = manaCost;
            this.picture = picture;
            tapped = false;
            guid = Guid.NewGuid();
            this.isPermanent = isPermanent;
        }

        private void ChangeTapped(bool value)
        {
            tapped = value;
            TappedChanged?.Invoke(this, tapped);
        }

        public static bool operator ==(Card card1, Card card2)
        {
            return card1.guid == card2.guid;
        }

        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }
    }
}
