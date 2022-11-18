using MTGO_lite.Models.Manas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mtg_lite.Views.UserControls.ManaDisplays
{
    public partial class ManaPoolDisplay : UserControl
    {
        private Mana? manaPool;

        public Mana? ManaPool { get => manaPool; set => ChangeManaPool(value); }

        public ManaPoolDisplay()
        {
            InitializeComponent();
            Subscribe();
        }

        private void Subscribe()
        {
            if (manaPool is null) { return; }
            manaPool.manaChanged += ManaPool_manaChanged1;
        }

        private void ManaPool_manaChanged1(object? sender, object e)
        {
            DisplayManaPool();
        }

        private void ChangeManaPool(Mana? newManaPool)
        {
            this.manaPool = newManaPool;
            DisplayManaPool();
        }

        private void DisplayManaPool()
        {
            if(manaPool is null) { return; }
            foreach (var mana in manaPool.ManaColors)
            {
                var manaColorDisplay = new ManaColorDisplay();
                manaColorDisplay.ManaColor = mana.Value;
                flowLayoutPanel.Controls.Add(manaColorDisplay);
            }
        }
    }
}
