namespace TP4
{
    partial class Fliste_prod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fliste_prod));
            this.txt_ref = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Catégorie = new System.Windows.Forms.Label();
            this.txt_desg = new System.Windows.Forms.TextBox();
            this.Désignation = new System.Windows.Forms.Label();
            this.txt_cmb_categ = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajout = new System.Windows.Forms.PictureBox();
            this.rechercher = new System.Windows.Forms.PictureBox();
            this.supprimer = new System.Windows.Forms.PictureBox();
            this.modifier = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechercher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ref
            // 
            this.txt_ref.Location = new System.Drawing.Point(94, 31);
            this.txt_ref.Name = "txt_ref";
            this.txt_ref.Size = new System.Drawing.Size(100, 22);
            this.txt_ref.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Référene";
            // 
            // Catégorie
            // 
            this.Catégorie.AutoSize = true;
            this.Catégorie.Location = new System.Drawing.Point(498, 34);
            this.Catégorie.Name = "Catégorie";
            this.Catégorie.Size = new System.Drawing.Size(66, 16);
            this.Catégorie.TabIndex = 2;
            this.Catégorie.Text = "Catégorie";
            // 
            // txt_desg
            // 
            this.txt_desg.Location = new System.Drawing.Point(339, 34);
            this.txt_desg.Name = "txt_desg";
            this.txt_desg.Size = new System.Drawing.Size(100, 22);
            this.txt_desg.TabIndex = 4;
            this.txt_desg.TextChanged += new System.EventHandler(this.txt_desg_TextChanged);
            // 
            // Désignation
            // 
            this.Désignation.AutoSize = true;
            this.Désignation.Location = new System.Drawing.Point(236, 34);
            this.Désignation.Name = "Désignation";
            this.Désignation.Size = new System.Drawing.Size(79, 16);
            this.Désignation.TabIndex = 5;
            this.Désignation.Text = "Désignation";
            // 
            // txt_cmb_categ
            // 
            this.txt_cmb_categ.FormattingEnabled = true;
            this.txt_cmb_categ.Location = new System.Drawing.Point(597, 34);
            this.txt_cmb_categ.Name = "txt_cmb_categ";
            this.txt_cmb_categ.Size = new System.Drawing.Size(121, 24);
            this.txt_cmb_categ.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(136, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(664, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Reference";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Catégorie";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Désignation";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PrixVente";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quantite stock";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // ajout
            // 
            this.ajout.Image = ((System.Drawing.Image)(resources.GetObject("ajout.Image")));
            this.ajout.Location = new System.Drawing.Point(12, 82);
            this.ajout.Name = "ajout";
            this.ajout.Size = new System.Drawing.Size(55, 50);
            this.ajout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ajout.TabIndex = 8;
            this.ajout.TabStop = false;
            this.ajout.Click += new System.EventHandler(this.ajout_Click);
            // 
            // rechercher
            // 
            this.rechercher.Image = ((System.Drawing.Image)(resources.GetObject("rechercher.Image")));
            this.rechercher.Location = new System.Drawing.Point(12, 138);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(55, 50);
            this.rechercher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rechercher.TabIndex = 9;
            this.rechercher.TabStop = false;
            // 
            // supprimer
            // 
            this.supprimer.Image = ((System.Drawing.Image)(resources.GetObject("supprimer.Image")));
            this.supprimer.Location = new System.Drawing.Point(12, 194);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(55, 50);
            this.supprimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.supprimer.TabIndex = 10;
            this.supprimer.TabStop = false;
            // 
            // modifier
            // 
            this.modifier.Image = ((System.Drawing.Image)(resources.GetObject("modifier.Image")));
            this.modifier.Location = new System.Drawing.Point(12, 250);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(52, 50);
            this.modifier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modifier.TabIndex = 11;
            this.modifier.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(724, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Fliste_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.ajout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_cmb_categ);
            this.Controls.Add(this.Désignation);
            this.Controls.Add(this.txt_desg);
            this.Controls.Add(this.Catégorie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ref);
            this.Name = "Fliste_prod";
            this.Text = "Fliste_prod";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ajout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechercher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ref;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Catégorie;
        private System.Windows.Forms.TextBox txt_desg;
        private System.Windows.Forms.Label Désignation;
        private System.Windows.Forms.ComboBox txt_cmb_categ;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.PictureBox ajout;
        private System.Windows.Forms.PictureBox rechercher;
        private System.Windows.Forms.PictureBox supprimer;
        private System.Windows.Forms.PictureBox modifier;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}