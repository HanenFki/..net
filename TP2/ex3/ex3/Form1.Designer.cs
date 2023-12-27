namespace ex3
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
            this.btn_vider = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_recherche = new System.Windows.Forms.Button();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.btn_noveau = new System.Windows.Forms.Button();
            this.txt_mot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_mot = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_def = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mot)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_def);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_vider);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btn_recherche);
            this.groupBox1.Controls.Add(this.btn_ajout);
            this.groupBox1.Controls.Add(this.btn_noveau);
            this.groupBox1.Controls.Add(this.txt_mot);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saisie de mot/Définition";
            // 
            // btn_vider
            // 
            this.btn_vider.Location = new System.Drawing.Point(502, 155);
            this.btn_vider.Name = "btn_vider";
            this.btn_vider.Size = new System.Drawing.Size(126, 23);
            this.btn_vider.TabIndex = 6;
            this.btn_vider.Text = "Vider";
            this.btn_vider.UseVisualStyleBackColor = true;
            this.btn_vider.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(502, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Supprimer un mot";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_recherche
            // 
            this.btn_recherche.Location = new System.Drawing.Point(502, 76);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Size = new System.Drawing.Size(109, 23);
            this.btn_recherche.TabIndex = 4;
            this.btn_recherche.Text = "Rechercher";
            this.btn_recherche.UseVisualStyleBackColor = true;
            this.btn_recherche.Click += new System.EventHandler(this.btn_recherche_Click);
            // 
            // btn_ajout
            // 
            this.btn_ajout.Location = new System.Drawing.Point(502, 37);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(109, 23);
            this.btn_ajout.TabIndex = 3;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // btn_noveau
            // 
            this.btn_noveau.Location = new System.Drawing.Point(285, 41);
            this.btn_noveau.Name = "btn_noveau";
            this.btn_noveau.Size = new System.Drawing.Size(90, 23);
            this.btn_noveau.TabIndex = 2;
            this.btn_noveau.Text = "Noveau";
            this.btn_noveau.UseVisualStyleBackColor = true;
            this.btn_noveau.Click += new System.EventHandler(this.btn_noveau_Click);
            // 
            // txt_mot
            // 
            this.txt_mot.Location = new System.Drawing.Point(105, 44);
            this.txt_mot.Name = "txt_mot";
            this.txt_mot.Size = new System.Drawing.Size(129, 22);
            this.txt_mot.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mot:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg_mot);
            this.groupBox2.Location = new System.Drawing.Point(33, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(678, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste Mots/Définitions";
            // 
            // dg_mot
            // 
            this.dg_mot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dg_mot.Location = new System.Drawing.Point(54, 47);
            this.dg_mot.Name = "dg_mot";
            this.dg_mot.RowHeadersWidth = 51;
            this.dg_mot.RowTemplate.Height = 24;
            this.dg_mot.Size = new System.Drawing.Size(332, 150);
            this.dg_mot.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Définition";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Définition";
            // 
            // txt_def
            // 
            this.txt_def.Location = new System.Drawing.Point(116, 82);
            this.txt_def.Name = "txt_def";
            this.txt_def.Size = new System.Drawing.Size(281, 96);
            this.txt_def.TabIndex = 8;
            this.txt_def.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_mot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_vider;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_recherche;
        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.Button btn_noveau;
        private System.Windows.Forms.TextBox txt_mot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_mot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txt_def;
    }
}

