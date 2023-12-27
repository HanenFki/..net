namespace Projet
{
    partial class tabVol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabVol));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Vcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.Vnbrplac = new Guna.UI2.WinForms.Guna2TextBox();
            this.Vsrc = new System.Windows.Forms.ComboBox();
            this.Vdest = new System.Windows.Forms.ComboBox();
            this.btn_ajoutvol = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Vdate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_voirvol = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(243, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 47);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ajouter  vol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(48, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Code Vol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(48, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Source";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(48, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Destination";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(48, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nombre de place";
            // 
            // Vcode
            // 
            this.Vcode.BackColor = System.Drawing.Color.Transparent;
            this.Vcode.BorderColor = System.Drawing.Color.Red;
            this.Vcode.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Vcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Vcode.DefaultText = "";
            this.Vcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Vcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Vcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Vcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Vcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Vcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vcode.ForeColor = System.Drawing.Color.Black;
            this.Vcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Vcode.Location = new System.Drawing.Point(251, 104);
            this.Vcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Vcode.Name = "Vcode";
            this.Vcode.PasswordChar = '\0';
            this.Vcode.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.Vcode.PlaceholderText = "";
            this.Vcode.SelectedText = "";
            this.Vcode.Size = new System.Drawing.Size(136, 34);
            this.Vcode.TabIndex = 11;
            // 
            // Vnbrplac
            // 
            this.Vnbrplac.BackColor = System.Drawing.Color.Transparent;
            this.Vnbrplac.BorderColor = System.Drawing.Color.Red;
            this.Vnbrplac.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Vnbrplac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Vnbrplac.DefaultText = "";
            this.Vnbrplac.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Vnbrplac.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Vnbrplac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Vnbrplac.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Vnbrplac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Vnbrplac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vnbrplac.ForeColor = System.Drawing.Color.Black;
            this.Vnbrplac.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Vnbrplac.Location = new System.Drawing.Point(251, 307);
            this.Vnbrplac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Vnbrplac.Name = "Vnbrplac";
            this.Vnbrplac.PasswordChar = '\0';
            this.Vnbrplac.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.Vnbrplac.PlaceholderText = "";
            this.Vnbrplac.SelectedText = "";
            this.Vnbrplac.Size = new System.Drawing.Size(136, 34);
            this.Vnbrplac.TabIndex = 13;
            // 
            // Vsrc
            // 
            this.Vsrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vsrc.ForeColor = System.Drawing.Color.Black;
            this.Vsrc.FormattingEnabled = true;
            this.Vsrc.Items.AddRange(new object[] {
            "Tunis",
            "France",
            "Italie",
            "Canada",
            "Allemagne",
            "China",
            "Espana",
            "Etats Unis"});
            this.Vsrc.Location = new System.Drawing.Point(251, 175);
            this.Vsrc.Name = "Vsrc";
            this.Vsrc.Size = new System.Drawing.Size(136, 26);
            this.Vsrc.TabIndex = 14;
            // 
            // Vdest
            // 
            this.Vdest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vdest.ForeColor = System.Drawing.Color.Black;
            this.Vdest.FormattingEnabled = true;
            this.Vdest.Items.AddRange(new object[] {
            "Tunis",
            "France",
            "Italie",
            "Canada",
            "Allemagne",
            "China",
            "Espana",
            "Etats Unis"});
            this.Vdest.Location = new System.Drawing.Point(251, 242);
            this.Vdest.Name = "Vdest";
            this.Vdest.Size = new System.Drawing.Size(136, 26);
            this.Vdest.TabIndex = 15;
            // 
            // btn_ajoutvol
            // 
            this.btn_ajoutvol.BackColor = System.Drawing.Color.Navy;
            this.btn_ajoutvol.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutvol.ForeColor = System.Drawing.Color.Snow;
            this.btn_ajoutvol.Location = new System.Drawing.Point(104, 462);
            this.btn_ajoutvol.Name = "btn_ajoutvol";
            this.btn_ajoutvol.Size = new System.Drawing.Size(110, 35);
            this.btn_ajoutvol.TabIndex = 16;
            this.btn_ajoutvol.Text = "Ajouter";
            this.btn_ajoutvol.UseVisualStyleBackColor = false;
            this.btn_ajoutvol.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(227, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = "Réinitialiser";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(436, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(56, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Date";
            // 
            // Vdate
            // 
            this.Vdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vdate.Location = new System.Drawing.Point(251, 385);
            this.Vdate.Name = "Vdate";
            this.Vdate.Size = new System.Drawing.Size(136, 24);
            this.Vdate.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(-1, 527);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 26);
            this.panel1.TabIndex = 66;
            // 
            // btn_voirvol
            // 
            this.btn_voirvol.BackColor = System.Drawing.Color.Navy;
            this.btn_voirvol.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voirvol.ForeColor = System.Drawing.Color.Snow;
            this.btn_voirvol.Location = new System.Drawing.Point(383, 462);
            this.btn_voirvol.Name = "btn_voirvol";
            this.btn_voirvol.Size = new System.Drawing.Size(139, 35);
            this.btn_voirvol.TabIndex = 67;
            this.btn_voirvol.Text = "Voir Vols";
            this.btn_voirvol.UseVisualStyleBackColor = false;
            this.btn_voirvol.Click += new System.EventHandler(this.btn_voirvol_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(544, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 68;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabVol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 548);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_voirvol);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Vdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ajoutvol);
            this.Controls.Add(this.Vdest);
            this.Controls.Add(this.Vsrc);
            this.Controls.Add(this.Vnbrplac);
            this.Controls.Add(this.Vcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "tabVol";
            this.Text = "tabVol";
            this.Load += new System.EventHandler(this.tabVol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox Vcode;
        private Guna.UI2.WinForms.Guna2TextBox Vnbrplac;
        private System.Windows.Forms.ComboBox Vsrc;
        private System.Windows.Forms.ComboBox Vdest;
        private System.Windows.Forms.Button btn_ajoutvol;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Vdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_voirvol;
        private System.Windows.Forms.Button button1;
    }
}