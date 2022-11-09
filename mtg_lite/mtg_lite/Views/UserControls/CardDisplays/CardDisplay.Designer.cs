namespace mtg_lite.Views.UserControls.CardDisplays
{
    partial class CardDisplay
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
            this.picCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            this.SuspendLayout();
            // 
            // picCard
            // 
            this.picCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCard.Image = global::mtg_lite.Resource.card_back;
            this.picCard.Location = new System.Drawing.Point(0, 0);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(195, 270);
            this.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard.TabIndex = 0;
            this.picCard.TabStop = false;
            this.picCard.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CardDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picCard);
            this.Name = "CardDisplay";
            this.Size = new System.Drawing.Size(195, 270);
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picCard;
    }
}
