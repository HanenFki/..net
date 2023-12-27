namespace TP4
{
    partial class Fmenu
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_btn_cl = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_prod = new System.Windows.Forms.ToolStripButton();
            this.ts_btn_com = new System.Windows.Forms.ToolStripButton();
            this.btn_ts_quit = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_btn_cl,
            this.ts_btn_prod,
            this.ts_btn_com,
            this.btn_ts_quit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_btn_cl
            // 
            this.ts_btn_cl.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_cl.Image")));
            this.ts_btn_cl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ts_btn_cl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_cl.Name = "ts_btn_cl";
            this.ts_btn_cl.Size = new System.Drawing.Size(57, 44);
            this.ts_btn_cl.Text = "Clients";
            this.ts_btn_cl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_cl.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ts_btn_prod
            // 
            this.ts_btn_prod.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_prod.Image")));
            this.ts_btn_prod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_prod.Name = "ts_btn_prod";
            this.ts_btn_prod.Size = new System.Drawing.Size(67, 44);
            this.ts_btn_prod.Text = "Produits";
            this.ts_btn_prod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_btn_prod.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // ts_btn_com
            // 
            this.ts_btn_com.Image = ((System.Drawing.Image)(resources.GetObject("ts_btn_com.Image")));
            this.ts_btn_com.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ts_btn_com.Name = "ts_btn_com";
            this.ts_btn_com.Size = new System.Drawing.Size(90, 44);
            this.ts_btn_com.Text = "Commande";
            this.ts_btn_com.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btn_ts_quit
            // 
            this.btn_ts_quit.Image = ((System.Drawing.Image)(resources.GetObject("btn_ts_quit.Image")));
            this.btn_ts_quit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ts_quit.Name = "btn_ts_quit";
            this.btn_ts_quit.Size = new System.Drawing.Size(59, 44);
            this.btn_ts_quit.Text = "Quitter";
            this.btn_ts_quit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // Fmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Fmenu";
            this.Text = "Gestion des commandes clients";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ts_btn_cl;
        private System.Windows.Forms.ToolStripButton ts_btn_prod;
        private System.Windows.Forms.ToolStripButton ts_btn_com;
        private System.Windows.Forms.ToolStripButton btn_ts_quit;
    }
}

