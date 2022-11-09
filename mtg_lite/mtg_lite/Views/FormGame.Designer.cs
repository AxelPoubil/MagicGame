namespace mtg_lite
{
    partial class FormGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.libraryDisplay = new mtg_lite.Views.UserControls.ZoneDisplays.TopCardZoneDisplay();
            this.graveyardDisplay = new mtg_lite.Views.UserControls.ZoneDisplays.TopCardZoneDisplay();
            this.handDisplay = new mtg_lite.Views.UserControls.ZoneDisplays.HandDisplay();
            this.manaPoolDisplay = new mtg_lite.Views.UserControls.ManaDisplays.ManaPoolDisplay();
            this.battlefieldDisplay = new mtg_lite.Views.UserControls.ZoneDisplays.BattlefieldDisplay();
            this.SuspendLayout();
            // 
            // libraryDisplay
            // 
            this.libraryDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.libraryDisplay.Location = new System.Drawing.Point(12, 12);
            this.libraryDisplay.Name = "libraryDisplay";
            this.libraryDisplay.Size = new System.Drawing.Size(204, 301);
            this.libraryDisplay.TabIndex = 0;
            this.libraryDisplay.Zone = null;
            // 
            // graveyardDisplay
            // 
            this.graveyardDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graveyardDisplay.Location = new System.Drawing.Point(12, 319);
            this.graveyardDisplay.Name = "graveyardDisplay";
            this.graveyardDisplay.Size = new System.Drawing.Size(204, 301);
            this.graveyardDisplay.TabIndex = 1;
            this.graveyardDisplay.Zone = null;
            // 
            // handDisplay
            // 
            this.handDisplay.Hand = null;
            this.handDisplay.Location = new System.Drawing.Point(230, 682);
            this.handDisplay.Name = "handDisplay";
            this.handDisplay.Size = new System.Drawing.Size(1625, 339);
            this.handDisplay.TabIndex = 3;
            // 
            // manaPoolDisplay
            // 
            this.manaPoolDisplay.Location = new System.Drawing.Point(12, 685);
            this.manaPoolDisplay.ManaPool = null;
            this.manaPoolDisplay.Name = "manaPoolDisplay";
            this.manaPoolDisplay.Size = new System.Drawing.Size(212, 336);
            this.manaPoolDisplay.TabIndex = 4;
            // 
            // battlefieldDisplay
            // 
            this.battlefieldDisplay.Battlefield = null;
            this.battlefieldDisplay.Location = new System.Drawing.Point(234, 12);
            this.battlefieldDisplay.Name = "battlefieldDisplay";
            this.battlefieldDisplay.Size = new System.Drawing.Size(1621, 664);
            this.battlefieldDisplay.TabIndex = 5;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1861, 1042);
            this.Controls.Add(this.battlefieldDisplay);
            this.Controls.Add(this.manaPoolDisplay);
            this.Controls.Add(this.handDisplay);
            this.Controls.Add(this.graveyardDisplay);
            this.Controls.Add(this.libraryDisplay);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormGame";
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.UserControls.ZoneDisplays.TopCardZoneDisplay libraryDisplay;
        private Views.UserControls.ZoneDisplays.TopCardZoneDisplay graveyardDisplay;
        private Views.UserControls.ZoneDisplays.HandDisplay handDisplay;
        private Views.UserControls.ManaDisplays.ManaPoolDisplay manaPoolDisplay;
        private Views.UserControls.ZoneDisplays.BattlefieldDisplay battlefieldDisplay;
    }
}