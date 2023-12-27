namespace exple
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.longeur_txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.long_txt = new System.Windows.Forms.TextBox();
            this.larg_txt = new System.Windows.Forms.TextBox();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.btn_affich = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg);
            this.groupBox1.Controls.Add(this.btn_affich);
            this.groupBox1.Controls.Add(this.btn_ajout);
            this.groupBox1.Controls.Add(this.larg_txt);
            this.groupBox1.Controls.Add(this.long_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.longeur_txt);
            this.groupBox1.Location = new System.Drawing.Point(44, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulaire";
            // 
            // longeur_txt
            // 
            this.longeur_txt.AutoSize = true;
            this.longeur_txt.Location = new System.Drawing.Point(60, 52);
            this.longeur_txt.Name = "longeur_txt";
            this.longeur_txt.Size = new System.Drawing.Size(52, 16);
            this.longeur_txt.TabIndex = 0;
            this.longeur_txt.Text = "longeur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Largeur";
            // 
            // long_txt
            // 
            this.long_txt.Location = new System.Drawing.Point(164, 52);
            this.long_txt.Name = "long_txt";
            this.long_txt.Size = new System.Drawing.Size(100, 22);
            this.long_txt.TabIndex = 2;
            // 
            // larg_txt
            // 
            this.larg_txt.Location = new System.Drawing.Point(164, 95);
            this.larg_txt.Name = "larg_txt";
            this.larg_txt.Size = new System.Drawing.Size(100, 22);
            this.larg_txt.TabIndex = 3;
            // 
            // btn_ajout
            // 
            this.btn_ajout.Location = new System.Drawing.Point(439, 47);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(75, 23);
            this.btn_ajout.TabIndex = 4;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // btn_affich
            // 
            this.btn_affich.Location = new System.Drawing.Point(439, 92);
            this.btn_affich.Name = "btn_affich";
            this.btn_affich.Size = new System.Drawing.Size(75, 23);
            this.btn_affich.TabIndex = 5;
            this.btn_affich.Text = "Afficher";
            this.btn_affich.UseVisualStyleBackColor = true;
            this.btn_affich.Click += new System.EventHandler(this.btn_affich_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dg.Location = new System.Drawing.Point(6, 167);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(722, 186);
            this.dg.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numéro";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Largeur";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Longeur";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Surface";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_affich;
        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.TextBox larg_txt;
        private System.Windows.Forms.TextBox long_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label longeur_txt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

