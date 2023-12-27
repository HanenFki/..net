namespace ex1
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
            this.txt_chaine = new System.Windows.Forms.GroupBox();
            this.btn_convertir = new System.Windows.Forms.Button();
            this.txt_ch = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_supp_tous = new System.Windows.Forms.Button();
            this.rdb_egal10 = new System.Windows.Forms.RadioButton();
            this.rdb_inf10 = new System.Windows.Forms.RadioButton();
            this.rdb_sup10 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_rech = new System.Windows.Forms.TextBox();
            this.btn_rech = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_supp = new System.Windows.Forms.Button();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_vider = new System.Windows.Forms.Button();
            this.btn_inverser = new System.Windows.Forms.Button();
            this.btn_trier = new System.Windows.Forms.Button();
            this.list_int = new System.Windows.Forms.ListBox();
            this.txt_chaine.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_chaine
            // 
            this.txt_chaine.Controls.Add(this.btn_convertir);
            this.txt_chaine.Controls.Add(this.txt_ch);
            this.txt_chaine.Controls.Add(this.groupBox4);
            this.txt_chaine.Controls.Add(this.groupBox3);
            this.txt_chaine.Controls.Add(this.groupBox2);
            this.txt_chaine.Location = new System.Drawing.Point(25, 12);
            this.txt_chaine.Name = "txt_chaine";
            this.txt_chaine.Size = new System.Drawing.Size(556, 426);
            this.txt_chaine.TabIndex = 0;
            this.txt_chaine.TabStop = false;
            this.txt_chaine.Text = "Action sur liste";
            // 
            // btn_convertir
            // 
            this.btn_convertir.Location = new System.Drawing.Point(335, 364);
            this.btn_convertir.Name = "btn_convertir";
            this.btn_convertir.Size = new System.Drawing.Size(75, 23);
            this.btn_convertir.TabIndex = 4;
            this.btn_convertir.Text = "Convertir en chaine";
            this.btn_convertir.UseVisualStyleBackColor = true;
            this.btn_convertir.Click += new System.EventHandler(this.btn_convertir_Click);
            // 
            // txt_ch
            // 
            this.txt_ch.Enabled = false;
            this.txt_ch.Location = new System.Drawing.Point(19, 364);
            this.txt_ch.Name = "txt_ch";
            this.txt_ch.ReadOnly = true;
            this.txt_ch.Size = new System.Drawing.Size(258, 22);
            this.txt_ch.TabIndex = 3;
            this.txt_ch.TextChanged += new System.EventHandler(this.txt_ch_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_supp_tous);
            this.groupBox4.Controls.Add(this.rdb_egal10);
            this.groupBox4.Controls.Add(this.rdb_inf10);
            this.groupBox4.Controls.Add(this.rdb_sup10);
            this.groupBox4.Location = new System.Drawing.Point(31, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(477, 113);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // btn_supp_tous
            // 
            this.btn_supp_tous.Location = new System.Drawing.Point(339, 74);
            this.btn_supp_tous.Name = "btn_supp_tous";
            this.btn_supp_tous.Size = new System.Drawing.Size(132, 23);
            this.btn_supp_tous.TabIndex = 3;
            this.btn_supp_tous.Text = "supprimer tous";
            this.btn_supp_tous.UseVisualStyleBackColor = true;
            this.btn_supp_tous.Click += new System.EventHandler(this.btn_supp_tous_Click_1);
            // 
            // rdb_egal10
            // 
            this.rdb_egal10.AutoSize = true;
            this.rdb_egal10.Location = new System.Drawing.Point(262, 44);
            this.rdb_egal10.Name = "rdb_egal10";
            this.rdb_egal10.Size = new System.Drawing.Size(49, 20);
            this.rdb_egal10.TabIndex = 2;
            this.rdb_egal10.TabStop = true;
            this.rdb_egal10.Text = "=10";
            this.rdb_egal10.UseVisualStyleBackColor = true;
            // 
            // rdb_inf10
            // 
            this.rdb_inf10.AutoSize = true;
            this.rdb_inf10.Location = new System.Drawing.Point(152, 44);
            this.rdb_inf10.Name = "rdb_inf10";
            this.rdb_inf10.Size = new System.Drawing.Size(49, 20);
            this.rdb_inf10.TabIndex = 1;
            this.rdb_inf10.TabStop = true;
            this.rdb_inf10.Text = "<10";
            this.rdb_inf10.UseVisualStyleBackColor = true;
            this.rdb_inf10.CheckedChanged += new System.EventHandler(this.rdb_inf10_CheckedChanged);
            // 
            // rdb_sup10
            // 
            this.rdb_sup10.AutoSize = true;
            this.rdb_sup10.Location = new System.Drawing.Point(52, 44);
            this.rdb_sup10.Name = "rdb_sup10";
            this.rdb_sup10.Size = new System.Drawing.Size(49, 20);
            this.rdb_sup10.TabIndex = 0;
            this.rdb_sup10.TabStop = true;
            this.rdb_sup10.Text = ">10";
            this.rdb_sup10.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_rech);
            this.groupBox3.Controls.Add(this.btn_rech);
            this.groupBox3.Location = new System.Drawing.Point(19, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 82);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recherche de l\'existence d\'un élement";
            // 
            // txt_rech
            // 
            this.txt_rech.Location = new System.Drawing.Point(42, 42);
            this.txt_rech.Name = "txt_rech";
            this.txt_rech.Size = new System.Drawing.Size(216, 22);
            this.txt_rech.TabIndex = 1;
            // 
            // btn_rech
            // 
            this.btn_rech.Location = new System.Drawing.Point(325, 42);
            this.btn_rech.Name = "btn_rech";
            this.btn_rech.Size = new System.Drawing.Size(98, 23);
            this.btn_rech.TabIndex = 0;
            this.btn_rech.Text = "Rechercher";
            this.btn_rech.UseVisualStyleBackColor = true;
            this.btn_rech.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_supp);
            this.groupBox2.Controls.Add(this.btn_ajout);
            this.groupBox2.Controls.Add(this.txt_note);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(19, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 117);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_supp
            // 
            this.btn_supp.Location = new System.Drawing.Point(243, 80);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.Size = new System.Drawing.Size(208, 23);
            this.btn_supp.TabIndex = 3;
            this.btn_supp.Text = "Supprimer élément sélectionnée";
            this.btn_supp.UseVisualStyleBackColor = true;
            this.btn_supp.Click += new System.EventHandler(this.btn_supp_Click);
            // 
            // btn_ajout
            // 
            this.btn_ajout.Location = new System.Drawing.Point(70, 80);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(75, 23);
            this.btn_ajout.TabIndex = 2;
            this.btn_ajout.Text = "Ajouter";
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.Click += new System.EventHandler(this.btn_ajout_Click);
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(192, 29);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(160, 22);
            this.txt_note.TabIndex = 1;
            this.txt_note.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Donner une note";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_vider);
            this.groupBox1.Controls.Add(this.btn_inverser);
            this.groupBox1.Controls.Add(this.btn_trier);
            this.groupBox1.Controls.Add(this.list_int);
            this.groupBox1.Location = new System.Drawing.Point(588, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des notes";
            // 
            // btn_vider
            // 
            this.btn_vider.Location = new System.Drawing.Point(66, 382);
            this.btn_vider.Name = "btn_vider";
            this.btn_vider.Size = new System.Drawing.Size(75, 23);
            this.btn_vider.TabIndex = 3;
            this.btn_vider.Text = "Vider";
            this.btn_vider.UseVisualStyleBackColor = true;
            this.btn_vider.Click += new System.EventHandler(this.btn_vider_Click);
            // 
            // btn_inverser
            // 
            this.btn_inverser.Location = new System.Drawing.Point(66, 334);
            this.btn_inverser.Name = "btn_inverser";
            this.btn_inverser.Size = new System.Drawing.Size(75, 23);
            this.btn_inverser.TabIndex = 2;
            this.btn_inverser.Text = "Inverser";
            this.btn_inverser.UseVisualStyleBackColor = true;
            this.btn_inverser.Click += new System.EventHandler(this.btn_inverser_Click);
            // 
            // btn_trier
            // 
            this.btn_trier.Location = new System.Drawing.Point(66, 291);
            this.btn_trier.Name = "btn_trier";
            this.btn_trier.Size = new System.Drawing.Size(75, 23);
            this.btn_trier.TabIndex = 1;
            this.btn_trier.Text = "Trier";
            this.btn_trier.UseVisualStyleBackColor = true;
            this.btn_trier.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // list_int
            // 
            this.list_int.ItemHeight = 16;
            this.list_int.Location = new System.Drawing.Point(27, 21);
            this.list_int.Name = "list_int";
            this.list_int.Size = new System.Drawing.Size(156, 260);
            this.list_int.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_chaine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.txt_chaine.ResumeLayout(false);
            this.txt_chaine.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txt_chaine;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_supp;
        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_rech;
        private System.Windows.Forms.Button btn_rech;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdb_egal10;
        private System.Windows.Forms.RadioButton rdb_inf10;
        private System.Windows.Forms.RadioButton rdb_sup10;
        private System.Windows.Forms.TextBox txt_ch;
        private System.Windows.Forms.Button btn_convertir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_vider;
        private System.Windows.Forms.Button btn_inverser;
        private System.Windows.Forms.Button btn_trier;
        private System.Windows.Forms.ListBox list_int;
        private System.Windows.Forms.Button btn_supp_tous;
    }
}

