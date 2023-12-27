namespace Projet
{
    partial class ajoutPassager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ajoutPassager));
            this.label1 = new System.Windows.Forms.Label();
            this.nationalitePass = new System.Windows.Forms.ComboBox();
            this.genrePass = new System.Windows.Forms.ComboBox();
            this.passName = new Guna.UI2.WinForms.Guna2TextBox();
            this.passId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.passeportPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.telPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_ResetPass = new System.Windows.Forms.Button();
            this.btn_AddPass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_voirpass = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(64, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "Genre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nationalitePass
            // 
            this.nationalitePass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nationalitePass.FormattingEnabled = true;
            this.nationalitePass.Items.AddRange(new object[] {
            "Tunisien",
            "Français",
            "Italien",
            "Canadien",
            "Allemand",
            "Chinois",
            "Espagnol",
            "Américain"});
            this.nationalitePass.Location = new System.Drawing.Point(267, 305);
            this.nationalitePass.Name = "nationalitePass";
            this.nationalitePass.Size = new System.Drawing.Size(136, 24);
            this.nationalitePass.TabIndex = 31;
            // 
            // genrePass
            // 
            this.genrePass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.genrePass.FormattingEnabled = true;
            this.genrePass.Items.AddRange(new object[] {
            "Femme",
            "Homme"});
            this.genrePass.Location = new System.Drawing.Point(267, 240);
            this.genrePass.Name = "genrePass";
            this.genrePass.Size = new System.Drawing.Size(136, 24);
            this.genrePass.TabIndex = 30;
            // 
            // passName
            // 
            this.passName.BackColor = System.Drawing.Color.Transparent;
            this.passName.BorderColor = System.Drawing.Color.Red;
            this.passName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.passName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passName.DefaultText = "";
            this.passName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passName.Location = new System.Drawing.Point(267, 169);
            this.passName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passName.Name = "passName";
            this.passName.PasswordChar = '\0';
            this.passName.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.passName.PlaceholderText = "";
            this.passName.SelectedText = "";
            this.passName.Size = new System.Drawing.Size(136, 34);
            this.passName.TabIndex = 29;
            // 
            // passId
            // 
            this.passId.BackColor = System.Drawing.Color.Transparent;
            this.passId.BorderColor = System.Drawing.Color.Red;
            this.passId.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.passId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passId.DefaultText = "";
            this.passId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passId.Location = new System.Drawing.Point(267, 102);
            this.passId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passId.Name = "passId";
            this.passId.PasswordChar = '\0';
            this.passId.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.passId.PlaceholderText = "";
            this.passId.SelectedText = "";
            this.passId.Size = new System.Drawing.Size(136, 34);
            this.passId.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(64, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 26);
            this.label6.TabIndex = 27;
            this.label6.Text = "Nationalité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(64, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Num passeport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(64, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 26);
            this.label4.TabIndex = 25;
            this.label4.Text = "Nom passager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(64, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 26);
            this.label3.TabIndex = 24;
            this.label3.Text = "Id passager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(187, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 47);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ajouter  passager";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(64, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 26);
            this.label7.TabIndex = 34;
            this.label7.Text = "Téléphone";
            // 
            // passeportPass
            // 
            this.passeportPass.BackColor = System.Drawing.Color.Transparent;
            this.passeportPass.BorderColor = System.Drawing.Color.Red;
            this.passeportPass.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.passeportPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passeportPass.DefaultText = "";
            this.passeportPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passeportPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passeportPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passeportPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passeportPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passeportPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passeportPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passeportPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passeportPass.Location = new System.Drawing.Point(267, 361);
            this.passeportPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passeportPass.Name = "passeportPass";
            this.passeportPass.PasswordChar = '\0';
            this.passeportPass.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.passeportPass.PlaceholderText = "";
            this.passeportPass.SelectedText = "";
            this.passeportPass.Size = new System.Drawing.Size(136, 34);
            this.passeportPass.TabIndex = 35;
            // 
            // telPass
            // 
            this.telPass.BackColor = System.Drawing.Color.Transparent;
            this.telPass.BorderColor = System.Drawing.Color.Red;
            this.telPass.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.telPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telPass.DefaultText = "";
            this.telPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.telPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.telPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.telPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.telPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.telPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.telPass.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.telPass.Location = new System.Drawing.Point(267, 432);
            this.telPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.telPass.Name = "telPass";
            this.telPass.PasswordChar = '\0';
            this.telPass.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.telPass.PlaceholderText = "";
            this.telPass.SelectedText = "";
            this.telPass.Size = new System.Drawing.Size(136, 34);
            this.telPass.TabIndex = 36;
            // 
            // btn_ResetPass
            // 
            this.btn_ResetPass.BackColor = System.Drawing.Color.Navy;
            this.btn_ResetPass.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetPass.ForeColor = System.Drawing.Color.Snow;
            this.btn_ResetPass.Location = new System.Drawing.Point(208, 529);
            this.btn_ResetPass.Name = "btn_ResetPass";
            this.btn_ResetPass.Size = new System.Drawing.Size(139, 35);
            this.btn_ResetPass.TabIndex = 38;
            this.btn_ResetPass.Text = "Réinitialiser";
            this.btn_ResetPass.UseVisualStyleBackColor = false;
            this.btn_ResetPass.Click += new System.EventHandler(this.btn_ResetPass_Click);
            // 
            // btn_AddPass
            // 
            this.btn_AddPass.BackColor = System.Drawing.Color.Navy;
            this.btn_AddPass.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPass.ForeColor = System.Drawing.Color.Snow;
            this.btn_AddPass.Location = new System.Drawing.Point(92, 529);
            this.btn_AddPass.Name = "btn_AddPass";
            this.btn_AddPass.Size = new System.Drawing.Size(110, 35);
            this.btn_AddPass.TabIndex = 37;
            this.btn_AddPass.Text = "Ajouter";
            this.btn_AddPass.UseVisualStyleBackColor = false;
            this.btn_AddPass.Click += new System.EventHandler(this.btn_AddPass_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(454, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 346);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(675, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 38);
            this.label8.TabIndex = 40;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_voirpass
            // 
            this.btn_voirpass.BackColor = System.Drawing.Color.Navy;
            this.btn_voirpass.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voirpass.ForeColor = System.Drawing.Color.Snow;
            this.btn_voirpass.Location = new System.Drawing.Point(353, 529);
            this.btn_voirpass.Name = "btn_voirpass";
            this.btn_voirpass.Size = new System.Drawing.Size(153, 35);
            this.btn_voirpass.TabIndex = 41;
            this.btn_voirpass.Text = "Voir Passager";
            this.btn_voirpass.UseVisualStyleBackColor = false;
            this.btn_voirpass.Click += new System.EventHandler(this.btn_voirpass_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(512, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 42;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ajoutPassager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 586);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_voirpass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_ResetPass);
            this.Controls.Add(this.btn_AddPass);
            this.Controls.Add(this.telPass);
            this.Controls.Add(this.passeportPass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nationalitePass);
            this.Controls.Add(this.genrePass);
            this.Controls.Add(this.passName);
            this.Controls.Add(this.passId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ajoutPassager";
            this.Text = "ajoutPassager";
            this.Load += new System.EventHandler(this.ajoutPassager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nationalitePass;
        private System.Windows.Forms.ComboBox genrePass;
        private Guna.UI2.WinForms.Guna2TextBox passName;
        private Guna.UI2.WinForms.Guna2TextBox passId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox passeportPass;
        private Guna.UI2.WinForms.Guna2TextBox telPass;
        private System.Windows.Forms.Button btn_ResetPass;
        private System.Windows.Forms.Button btn_AddPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_voirpass;
        private System.Windows.Forms.Button button1;
    }
}