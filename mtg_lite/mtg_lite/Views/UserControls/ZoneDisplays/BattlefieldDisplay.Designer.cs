namespace mtg_lite.Views.UserControls.ZoneDisplays
{
    partial class BattlefieldDisplay
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
            this.creaturesDisplay = new mtg_lite.Views.UserControls.CardDisplays.RowOfCardsDisplay();
            this.grpBattlefield = new System.Windows.Forms.GroupBox();
            this.landsDisplay = new mtg_lite.Views.UserControls.CardDisplays.RowOfCardsDisplay();
            this.grpBattlefield.SuspendLayout();
            this.SuspendLayout();
            // 
            // creaturesDisplay
            // 
            this.creaturesDisplay.Cards = null;
            this.creaturesDisplay.Location = new System.Drawing.Point(6, 30);
            this.creaturesDisplay.Name = "creaturesDisplay";
            this.creaturesDisplay.Size = new System.Drawing.Size(1600, 300);
            this.creaturesDisplay.TabIndex = 0;
            this.creaturesDisplay.CardClicked += new System.EventHandler<mtg_lite.Models.Cards.Card>(this.cardsDisplay_CardClicked);
            // 
            // grpBattlefield
            // 
            this.grpBattlefield.Controls.Add(this.landsDisplay);
            this.grpBattlefield.Controls.Add(this.creaturesDisplay);
            this.grpBattlefield.Location = new System.Drawing.Point(3, 3);
            this.grpBattlefield.Name = "grpBattlefield";
            this.grpBattlefield.Size = new System.Drawing.Size(1613, 656);
            this.grpBattlefield.TabIndex = 1;
            this.grpBattlefield.TabStop = false;
            this.grpBattlefield.Text = "Battlefield";
            // 
            // landsDisplay
            // 
            this.landsDisplay.Cards = null;
            this.landsDisplay.Location = new System.Drawing.Point(7, 336);
            this.landsDisplay.Name = "landsDisplay";
            this.landsDisplay.Size = new System.Drawing.Size(1600, 300);
            this.landsDisplay.TabIndex = 1;
            this.landsDisplay.CardClicked += new System.EventHandler<mtg_lite.Models.Cards.Card>(this.cardsDisplay_CardClicked);
            // 
            // BattlefieldDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpBattlefield);
            this.Name = "BattlefieldDisplay";
            this.Size = new System.Drawing.Size(1659, 729);
            this.grpBattlefield.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CardDisplays.RowOfCardsDisplay creaturesDisplay;
        private GroupBox grpBattlefield;
        private CardDisplays.RowOfCardsDisplay landsDisplay;
    }
}
