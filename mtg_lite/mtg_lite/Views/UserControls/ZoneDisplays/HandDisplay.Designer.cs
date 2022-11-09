namespace mtg_lite.Views.UserControls.ZoneDisplays
{
    partial class HandDisplay
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpHand = new System.Windows.Forms.GroupBox();
            this.rowOfCardsDisplay = new mtg_lite.Views.UserControls.CardDisplays.RowOfCardsDisplay();
            this.grpHand.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHand
            // 
            this.grpHand.Controls.Add(this.rowOfCardsDisplay);
            this.grpHand.Location = new System.Drawing.Point(3, 3);
            this.grpHand.Name = "grpHand";
            this.grpHand.Size = new System.Drawing.Size(1619, 333);
            this.grpHand.TabIndex = 1;
            this.grpHand.TabStop = false;
            this.grpHand.Text = "Hand";
            // 
            // rowOfCardsDisplay
            // 
            this.rowOfCardsDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.rowOfCardsDisplay.Cards = null;
            this.rowOfCardsDisplay.Location = new System.Drawing.Point(8, 22);
            this.rowOfCardsDisplay.Name = "rowOfCardsDisplay";
            this.rowOfCardsDisplay.Size = new System.Drawing.Size(1600, 300);
            this.rowOfCardsDisplay.TabIndex = 0;
            this.rowOfCardsDisplay.CardClicked += new System.EventHandler<mtg_lite.Models.Cards.Card>(this.rowOfCardsDisplay_CardClicked);
            // 
            // HandDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpHand);
            this.Name = "HandDisplay";
            this.Size = new System.Drawing.Size(1631, 344);
            this.grpHand.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpHand;
        private CardDisplays.RowOfCardsDisplay rowOfCardsDisplay;
    }
}
