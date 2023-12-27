namespace ex2
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
            this.Rdb_Volailles = new System.Windows.Forms.RadioButton();
            this.Rdb_Viandes = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Tirer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Serv_Volail = new System.Windows.Forms.Button();
            this.Lst_Volailles = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Serv_Viande = new System.Windows.Forms.Button();
            this.Lst_Viandes = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rdb_Volailles
            // 
            this.Rdb_Volailles.AutoSize = true;
            this.Rdb_Volailles.Location = new System.Drawing.Point(24, 23);
            this.Rdb_Volailles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rdb_Volailles.Name = "Rdb_Volailles";
            this.Rdb_Volailles.Size = new System.Drawing.Size(80, 20);
            this.Rdb_Volailles.TabIndex = 0;
            this.Rdb_Volailles.TabStop = true;
            this.Rdb_Volailles.Text = "Volailles";
            this.Rdb_Volailles.UseVisualStyleBackColor = true;
            this.Rdb_Volailles.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Rdb_Viandes
            // 
            this.Rdb_Viandes.AutoSize = true;
            this.Rdb_Viandes.Location = new System.Drawing.Point(179, 23);
            this.Rdb_Viandes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rdb_Viandes.Name = "Rdb_Viandes";
            this.Rdb_Viandes.Size = new System.Drawing.Size(81, 20);
            this.Rdb_Viandes.TabIndex = 1;
            this.Rdb_Viandes.TabStop = true;
            this.Rdb_Viandes.Text = "Viandes ";
            this.Rdb_Viandes.UseVisualStyleBackColor = true;
            this.Rdb_Viandes.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Tirer);
            this.groupBox1.Controls.Add(this.Rdb_Volailles);
            this.groupBox1.Controls.Add(this.Rdb_Viandes);
            this.groupBox1.Location = new System.Drawing.Point(67, 62);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(447, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // Btn_Tirer
            // 
            this.Btn_Tirer.Location = new System.Drawing.Point(319, 23);
            this.Btn_Tirer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Tirer.Name = "Btn_Tirer";
            this.Btn_Tirer.Size = new System.Drawing.Size(120, 28);
            this.Btn_Tirer.TabIndex = 2;
            this.Btn_Tirer.Text = "Tirer un Ticket";
            this.Btn_Tirer.UseVisualStyleBackColor = true;
            this.Btn_Tirer.Click += new System.EventHandler(this.Btn_Tirer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Serv_Volail);
            this.groupBox2.Controls.Add(this.Lst_Volailles);
            this.groupBox2.Location = new System.Drawing.Point(16, 149);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(267, 349);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volailles";
            // 
            // Btn_Serv_Volail
            // 
            this.Btn_Serv_Volail.Location = new System.Drawing.Point(75, 34);
            this.Btn_Serv_Volail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Serv_Volail.Name = "Btn_Serv_Volail";
            this.Btn_Serv_Volail.Size = new System.Drawing.Size(100, 28);
            this.Btn_Serv_Volail.TabIndex = 5;
            this.Btn_Serv_Volail.Text = "Se Servir";
            this.Btn_Serv_Volail.UseVisualStyleBackColor = true;
            this.Btn_Serv_Volail.Click += new System.EventHandler(this.Btn_Serv_Volail_Click);
            // 
            // Lst_Volailles
            // 
            this.Lst_Volailles.FormattingEnabled = true;
            this.Lst_Volailles.ItemHeight = 16;
            this.Lst_Volailles.Location = new System.Drawing.Point(51, 106);
            this.Lst_Volailles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Lst_Volailles.Name = "Lst_Volailles";
            this.Lst_Volailles.Size = new System.Drawing.Size(162, 196);
            this.Lst_Volailles.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_Serv_Viande);
            this.groupBox3.Controls.Add(this.Lst_Viandes);
            this.groupBox3.Location = new System.Drawing.Point(291, 149);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(282, 349);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Viandes";
            // 
            // Btn_Serv_Viande
            // 
            this.Btn_Serv_Viande.Location = new System.Drawing.Point(80, 34);
            this.Btn_Serv_Viande.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_Serv_Viande.Name = "Btn_Serv_Viande";
            this.Btn_Serv_Viande.Size = new System.Drawing.Size(100, 28);
            this.Btn_Serv_Viande.TabIndex = 6;
            this.Btn_Serv_Viande.Text = "Se Servir";
            this.Btn_Serv_Viande.UseVisualStyleBackColor = true;
            this.Btn_Serv_Viande.Click += new System.EventHandler(this.Btn_Serv_Viande_Click);
            // 
            // Lst_Viandes
            // 
            this.Lst_Viandes.FormattingEnabled = true;
            this.Lst_Viandes.ItemHeight = 16;
            this.Lst_Viandes.Location = new System.Drawing.Point(80, 106);
            this.Lst_Viandes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Lst_Viandes.Name = "Lst_Viandes";
            this.Lst_Viandes.Size = new System.Drawing.Size(161, 196);
            this.Lst_Viandes.TabIndex = 5;
            this.Lst_Viandes.SelectedIndexChanged += new System.EventHandler(this.Lst_Viandes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton Rdb_Volailles;
        private System.Windows.Forms.RadioButton Rdb_Viandes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Tirer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Serv_Volail;
        private System.Windows.Forms.ListBox Lst_Volailles;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_Serv_Viande;
        private System.Windows.Forms.ListBox Lst_Viandes;
    }
}

