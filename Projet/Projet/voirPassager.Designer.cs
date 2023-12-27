namespace Projet
{
    partial class voirPassager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.telpass_voir = new Guna.UI2.WinForms.Guna2TextBox();
            this.numpass_voir = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nationalit_voir = new System.Windows.Forms.ComboBox();
            this.genrepass_voir = new System.Windows.Forms.ComboBox();
            this.nompass_voir = new Guna.UI2.WinForms.Guna2TextBox();
            this.idpass_voir = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dg_passager = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_passager)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.Location = new System.Drawing.Point(495, 275);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 35);
            this.button4.TabIndex = 49;
            this.button4.Text = "Retour";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(350, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 35);
            this.button3.TabIndex = 47;
            this.button3.Text = "Réinitialiser";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(218, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 35);
            this.button2.TabIndex = 44;
            this.button2.Text = "Supprimer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(115, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 43;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(237, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 38);
            this.label2.TabIndex = 34;
            this.label2.Text = "Voir Passagers";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // telpass_voir
            // 
            this.telpass_voir.BackColor = System.Drawing.Color.Transparent;
            this.telpass_voir.BorderColor = System.Drawing.Color.Red;
            this.telpass_voir.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.telpass_voir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telpass_voir.DefaultText = "";
            this.telpass_voir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.telpass_voir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.telpass_voir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.telpass_voir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.telpass_voir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.telpass_voir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.telpass_voir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.telpass_voir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.telpass_voir.Location = new System.Drawing.Point(562, 217);
            this.telpass_voir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.telpass_voir.Name = "telpass_voir";
            this.telpass_voir.PasswordChar = '\0';
            this.telpass_voir.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.telpass_voir.PlaceholderText = "";
            this.telpass_voir.SelectedText = "";
            this.telpass_voir.Size = new System.Drawing.Size(136, 34);
            this.telpass_voir.TabIndex = 61;
            // 
            // numpass_voir
            // 
            this.numpass_voir.BackColor = System.Drawing.Color.Transparent;
            this.numpass_voir.BorderColor = System.Drawing.Color.Red;
            this.numpass_voir.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.numpass_voir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numpass_voir.DefaultText = "";
            this.numpass_voir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numpass_voir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numpass_voir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numpass_voir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numpass_voir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numpass_voir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numpass_voir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.numpass_voir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numpass_voir.Location = new System.Drawing.Point(562, 85);
            this.numpass_voir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numpass_voir.Name = "numpass_voir";
            this.numpass_voir.PasswordChar = '\0';
            this.numpass_voir.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.numpass_voir.PlaceholderText = "";
            this.numpass_voir.SelectedText = "";
            this.numpass_voir.Size = new System.Drawing.Size(136, 34);
            this.numpass_voir.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(365, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 26);
            this.label7.TabIndex = 59;
            this.label7.Text = "Téléphone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(372, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 58;
            this.label1.Text = "Genre";
            // 
            // nationalit_voir
            // 
            this.nationalit_voir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nationalit_voir.FormattingEnabled = true;
            this.nationalit_voir.Items.AddRange(new object[] {
            "Tunisien",
            "Français",
            "Italien",
            "Canadien",
            "Allemand",
            "Chinois",
            "Espagnol",
            "Américain"});
            this.nationalit_voir.Location = new System.Drawing.Point(176, 217);
            this.nationalit_voir.Name = "nationalit_voir";
            this.nationalit_voir.Size = new System.Drawing.Size(136, 24);
            this.nationalit_voir.TabIndex = 57;
            // 
            // genrepass_voir
            // 
            this.genrepass_voir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.genrepass_voir.FormattingEnabled = true;
            this.genrepass_voir.Items.AddRange(new object[] {
            "Femme",
            "Homme"});
            this.genrepass_voir.Location = new System.Drawing.Point(562, 152);
            this.genrepass_voir.Name = "genrepass_voir";
            this.genrepass_voir.Size = new System.Drawing.Size(136, 24);
            this.genrepass_voir.TabIndex = 56;
            // 
            // nompass_voir
            // 
            this.nompass_voir.BackColor = System.Drawing.Color.Transparent;
            this.nompass_voir.BorderColor = System.Drawing.Color.Red;
            this.nompass_voir.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.nompass_voir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nompass_voir.DefaultText = "";
            this.nompass_voir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nompass_voir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nompass_voir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nompass_voir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nompass_voir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nompass_voir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nompass_voir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nompass_voir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nompass_voir.Location = new System.Drawing.Point(176, 144);
            this.nompass_voir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nompass_voir.Name = "nompass_voir";
            this.nompass_voir.PasswordChar = '\0';
            this.nompass_voir.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.nompass_voir.PlaceholderText = "";
            this.nompass_voir.SelectedText = "";
            this.nompass_voir.Size = new System.Drawing.Size(136, 34);
            this.nompass_voir.TabIndex = 55;
            // 
            // idpass_voir
            // 
            this.idpass_voir.BackColor = System.Drawing.Color.Transparent;
            this.idpass_voir.BorderColor = System.Drawing.Color.Red;
            this.idpass_voir.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.idpass_voir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idpass_voir.DefaultText = "";
            this.idpass_voir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idpass_voir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idpass_voir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idpass_voir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idpass_voir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idpass_voir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpass_voir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.idpass_voir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idpass_voir.Location = new System.Drawing.Point(176, 85);
            this.idpass_voir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.idpass_voir.Name = "idpass_voir";
            this.idpass_voir.PasswordChar = '\0';
            this.idpass_voir.PlaceholderForeColor = System.Drawing.Color.Transparent;
            this.idpass_voir.PlaceholderText = "";
            this.idpass_voir.SelectedText = "";
            this.idpass_voir.Size = new System.Drawing.Size(136, 34);
            this.idpass_voir.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(26, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 26);
            this.label6.TabIndex = 53;
            this.label6.Text = "Nationalité";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(365, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 26);
            this.label5.TabIndex = 52;
            this.label5.Text = "Num passeport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(18, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 26);
            this.label4.TabIndex = 51;
            this.label4.Text = "Nom passager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(24, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 26);
            this.label3.TabIndex = 50;
            this.label3.Text = "Id passager";
            // 
            // dg_passager
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dg_passager.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_passager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_passager.ColumnHeadersHeight = 30;
            this.dg_passager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_passager.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_passager.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_passager.Location = new System.Drawing.Point(0, 316);
            this.dg_passager.Name = "dg_passager";
            this.dg_passager.RowHeadersVisible = false;
            this.dg_passager.RowHeadersWidth = 51;
            this.dg_passager.RowTemplate.Height = 24;
            this.dg_passager.Size = new System.Drawing.Size(727, 245);
            this.dg_passager.TabIndex = 62;
            this.dg_passager.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_passager.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dg_passager.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dg_passager.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dg_passager.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dg_passager.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dg_passager.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_passager.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.dg_passager.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_passager.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_passager.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg_passager.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dg_passager.ThemeStyle.HeaderStyle.Height = 30;
            this.dg_passager.ThemeStyle.ReadOnly = false;
            this.dg_passager.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_passager.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_passager.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_passager.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dg_passager.ThemeStyle.RowsStyle.Height = 24;
            this.dg_passager.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_passager.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dg_passager.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_passager_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(0, 567);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 17);
            this.panel1.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(689, -2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 38);
            this.label9.TabIndex = 71;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // voirPassager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 584);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dg_passager);
            this.Controls.Add(this.telpass_voir);
            this.Controls.Add(this.numpass_voir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nationalit_voir);
            this.Controls.Add(this.genrepass_voir);
            this.Controls.Add(this.nompass_voir);
            this.Controls.Add(this.idpass_voir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "voirPassager";
            this.Text = "voirPassager";
            this.Load += new System.EventHandler(this.voirPassager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_passager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox telpass_voir;
        private Guna.UI2.WinForms.Guna2TextBox numpass_voir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox nationalit_voir;
        private System.Windows.Forms.ComboBox genrepass_voir;
        private Guna.UI2.WinForms.Guna2TextBox nompass_voir;
        private Guna.UI2.WinForms.Guna2TextBox idpass_voir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dg_passager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
    }
}