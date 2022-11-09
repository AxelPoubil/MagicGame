namespace mtg_lite.Views.UserControls.ManaDisplays
{
    partial class ManaPoolDisplay
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.grpManaPool = new System.Windows.Forms.GroupBox();
            this.grpManaPool.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(6, 30);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(195, 297);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // grpManaPool
            // 
            this.grpManaPool.Controls.Add(this.flowLayoutPanel);
            this.grpManaPool.Location = new System.Drawing.Point(0, 0);
            this.grpManaPool.Name = "grpManaPool";
            this.grpManaPool.Size = new System.Drawing.Size(206, 333);
            this.grpManaPool.TabIndex = 1;
            this.grpManaPool.TabStop = false;
            this.grpManaPool.Text = "Mana pool";
            // 
            // ManaPoolDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpManaPool);
            this.Name = "ManaPoolDisplay";
            this.Size = new System.Drawing.Size(333, 429);
            this.grpManaPool.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel;
        private GroupBox grpManaPool;
    }
}
