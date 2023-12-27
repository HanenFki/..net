namespace TP4
{
    partial class FListe_cl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FListe_cl));
            this.txt_cin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_vil = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.Liste_Clients = new System.Windows.Forms.GroupBox();
            this.btn_vider = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.PictureBox();
            this.btn_recherche = new System.Windows.Forms.PictureBox();
            this.btn_modifier = new System.Windows.Forms.PictureBox();
            this.btn_ajouter = new System.Windows.Forms.PictureBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.Liste_Clients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_supprimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_recherche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ajouter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cin
            // 
            this.txt_cin.Location = new System.Drawing.Point(94, 15);
            this.txt_cin.Name = "txt_cin";
            this.txt_cin.Size = new System.Drawing.Size(100, 22);
            this.txt_cin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "CIN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "VILLE :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOM :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "TELEPHONE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "PRENOM :";
            // 
            // txt_vil
            // 
            this.txt_vil.Location = new System.Drawing.Point(103, 70);
            this.txt_vil.Name = "txt_vil";
            this.txt_vil.Size = new System.Drawing.Size(100, 22);
            this.txt_vil.TabIndex = 6;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(318, 9);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(100, 22);
            this.txt_nom.TabIndex = 7;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(358, 64);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(100, 22);
            this.txt_tel.TabIndex = 8;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(548, 9);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(100, 22);
            this.txt_prenom.TabIndex = 9;
            // 
            // Liste_Clients
            // 
            this.Liste_Clients.Controls.Add(this.btn_vider);
            this.Liste_Clients.Controls.Add(this.btn_supprimer);
            this.Liste_Clients.Controls.Add(this.btn_recherche);
            this.Liste_Clients.Controls.Add(this.btn_modifier);
            this.Liste_Clients.Controls.Add(this.btn_ajouter);
            this.Liste_Clients.Controls.Add(this.txt_prenom);
            this.Liste_Clients.Controls.Add(this.txt_tel);
            this.Liste_Clients.Controls.Add(this.txt_nom);
            this.Liste_Clients.Controls.Add(this.txt_vil);
            this.Liste_Clients.Controls.Add(this.label5);
            this.Liste_Clients.Controls.Add(this.label4);
            this.Liste_Clients.Controls.Add(this.label3);
            this.Liste_Clients.Controls.Add(this.label2);
            this.Liste_Clients.Controls.Add(this.label1);
            this.Liste_Clients.Controls.Add(this.txt_cin);
            this.Liste_Clients.Location = new System.Drawing.Point(18, 20);
            this.Liste_Clients.Name = "Liste_Clients";
            this.Liste_Clients.Size = new System.Drawing.Size(782, 142);
            this.Liste_Clients.TabIndex = 11;
            this.Liste_Clients.TabStop = false;
            this.Liste_Clients.Text = "Liste_Clients";
            // 
            // btn_vider
            // 
            this.btn_vider.Location = new System.Drawing.Point(591, 51);
            this.btn_vider.Name = "btn_vider";
            this.btn_vider.Size = new System.Drawing.Size(75, 23);
            this.btn_vider.TabIndex = 14;
            this.btn_vider.Text = "vider";
            this.btn_vider.UseVisualStyleBackColor = true;
            this.btn_vider.Click += new System.EventHandler(this.btn_vider_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_supprimer.Image = ((System.Drawing.Image)(resources.GetObject("btn_supprimer.Image")));
            this.btn_supprimer.Location = new System.Drawing.Point(716, 92);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(54, 50);
            this.btn_supprimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_supprimer.TabIndex = 13;
            this.btn_supprimer.TabStop = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_recherche
            // 
            this.btn_recherche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_recherche.Image = ((System.Drawing.Image)(resources.GetObject("btn_recherche.Image")));
            this.btn_recherche.Location = new System.Drawing.Point(654, 92);
            this.btn_recherche.Name = "btn_recherche";
            this.btn_recherche.Size = new System.Drawing.Size(56, 50);
            this.btn_recherche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_recherche.TabIndex = 12;
            this.btn_recherche.TabStop = false;
            this.btn_recherche.Click += new System.EventHandler(this.btn_recherche_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_modifier.Image = ((System.Drawing.Image)(resources.GetObject("btn_modifier.Image")));
            this.btn_modifier.Location = new System.Drawing.Point(591, 92);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(57, 50);
            this.btn_modifier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_modifier.TabIndex = 11;
            this.btn_modifier.TabStop = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_ajouter.Image = global::TP4.Properties.Resources.business_application_addmale_useradd_insert_add_user_client_2312;
            this.btn_ajouter.Location = new System.Drawing.Point(526, 92);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(59, 47);
            this.btn_ajouter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_ajouter.TabIndex = 10;
            this.btn_ajouter.TabStop = false;
            this.btn_ajouter.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(69, 242);
            this.dg.Name = "dg";
            this.dg.RowHeadersWidth = 51;
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(633, 150);
            this.dg.TabIndex = 12;
            this.dg.DoubleClick += new System.EventHandler(this.dg_DoubleClick);
            // 
            // FListe_cl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 460);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.Liste_Clients);
            this.Name = "FListe_cl";
            this.Text = "Liste des clients";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Liste_Clients.ResumeLayout(false);
            this.Liste_Clients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_supprimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_recherche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_modifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ajouter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_cin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_vil;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.GroupBox Liste_Clients;
        private System.Windows.Forms.PictureBox btn_ajouter;
        private System.Windows.Forms.PictureBox btn_modifier;
        private System.Windows.Forms.PictureBox btn_supprimer;
        private System.Windows.Forms.PictureBox btn_recherche;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button btn_vider;
    }
}