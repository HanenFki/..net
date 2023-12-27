namespace Gestion_compte
{
    partial class form_cpt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_cpt));
            this.tab_cl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_rech = new System.Windows.Forms.TextBox();
            this.text_tit = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dg_cllient = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txttitulaire = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_solde = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.datem = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdb_retr = new System.Windows.Forms.RadioButton();
            this.rdb_vers = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_mt = new System.Windows.Forms.TextBox();
            this.btn_creerMouv = new System.Windows.Forms.Button();
            this.dg_mouv = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Numéro = new System.Windows.Forms.Label();
            this.txt_nume = new System.Windows.Forms.TextBox();
            this.Titulaire = new System.Windows.Forms.Label();
            this.txt_tite = new System.Windows.Forms.TextBox();
            this.Solde = new System.Windows.Forms.Label();
            this.txt_slde = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.date_deb = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.date_fin = new System.Windows.Forms.DateTimePicker();
            this.btn_afficher = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dg_extrait = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_cl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_cllient)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mouv)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_extrait)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_cl
            // 
            this.tab_cl.Controls.Add(this.tabPage1);
            this.tab_cl.Controls.Add(this.tabPage2);
            this.tab_cl.Controls.Add(this.tabPage3);
            this.tab_cl.Location = new System.Drawing.Point(12, 12);
            this.tab_cl.Name = "tab_cl";
            this.tab_cl.SelectedIndex = 0;
            this.tab_cl.Size = new System.Drawing.Size(785, 426);
            this.tab_cl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestion des comptes clients";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mouvement compte";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(777, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Extrait du compte";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(107, 391);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(104, 24);
            this.toolStripButton1.Text = "Ajouter";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(104, 24);
            this.toolStripButton2.Text = "Supprimer";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(104, 24);
            this.toolStripButton3.Text = "Rechercher";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.text_tit);
            this.groupBox1.Controls.Add(this.text_rech);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(129, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "compte client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulaire";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Solde";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // text_rech
            // 
            this.text_rech.Location = new System.Drawing.Point(121, 31);
            this.text_rech.Name = "text_rech";
            this.text_rech.Size = new System.Drawing.Size(100, 22);
            this.text_rech.TabIndex = 3;
            // 
            // text_tit
            // 
            this.text_tit.Location = new System.Drawing.Point(121, 63);
            this.text_tit.Name = "text_tit";
            this.text_tit.Size = new System.Drawing.Size(100, 22);
            this.text_tit.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dg_cllient);
            this.groupBox2.Location = new System.Drawing.Point(129, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 202);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des clients";
            // 
            // dg_cllient
            // 
            this.dg_cllient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_cllient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dg_cllient.Location = new System.Drawing.Point(37, 21);
            this.dg_cllient.Name = "dg_cllient";
            this.dg_cllient.RowHeadersWidth = 51;
            this.dg_cllient.RowTemplate.Height = 24;
            this.dg_cllient.Size = new System.Drawing.Size(457, 150);
            this.dg_cllient.TabIndex = 0;
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
            this.Column2.HeaderText = "Titulaire";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Solde";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_solde);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txttitulaire);
            this.groupBox3.Controls.Add(this.txtnum);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(16, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(697, 96);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compte client";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Numéro:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Titulaire";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(61, 36);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 22);
            this.txtnum.TabIndex = 2;
            // 
            // txttitulaire
            // 
            this.txttitulaire.Location = new System.Drawing.Point(239, 33);
            this.txttitulaire.Name = "txttitulaire";
            this.txttitulaire.Size = new System.Drawing.Size(100, 22);
            this.txttitulaire.TabIndex = 3;
            this.txttitulaire.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Solde";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_solde
            // 
            this.txt_solde.Location = new System.Drawing.Point(428, 39);
            this.txt_solde.Name = "txt_solde";
            this.txt_solde.Size = new System.Drawing.Size(100, 22);
            this.txt_solde.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dg_mouv);
            this.groupBox4.Controls.Add(this.btn_creerMouv);
            this.groupBox4.Controls.Add(this.txt_mt);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.datem);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(16, 117);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(745, 274);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mouvement du compte";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Date Opération";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // datem
            // 
            this.datem.Location = new System.Drawing.Point(106, 29);
            this.datem.Name = "datem";
            this.datem.Size = new System.Drawing.Size(147, 22);
            this.datem.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdb_vers);
            this.groupBox5.Controls.Add(this.rdb_retr);
            this.groupBox5.Location = new System.Drawing.Point(33, 83);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(189, 84);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Type d\'opération";
            // 
            // rdb_retr
            // 
            this.rdb_retr.AutoSize = true;
            this.rdb_retr.Location = new System.Drawing.Point(39, 34);
            this.rdb_retr.Name = "rdb_retr";
            this.rdb_retr.Size = new System.Drawing.Size(67, 20);
            this.rdb_retr.TabIndex = 0;
            this.rdb_retr.TabStop = true;
            this.rdb_retr.Text = "Retrait";
            this.rdb_retr.UseVisualStyleBackColor = true;
            this.rdb_retr.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdb_vers
            // 
            this.rdb_vers.AutoSize = true;
            this.rdb_vers.Location = new System.Drawing.Point(39, 60);
            this.rdb_vers.Name = "rdb_vers";
            this.rdb_vers.Size = new System.Drawing.Size(93, 20);
            this.rdb_vers.TabIndex = 1;
            this.rdb_vers.TabStop = true;
            this.rdb_vers.Text = "Versement";
            this.rdb_vers.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Montant";
            // 
            // txt_mt
            // 
            this.txt_mt.Location = new System.Drawing.Point(122, 201);
            this.txt_mt.Name = "txt_mt";
            this.txt_mt.Size = new System.Drawing.Size(100, 22);
            this.txt_mt.TabIndex = 4;
            // 
            // btn_creerMouv
            // 
            this.btn_creerMouv.Location = new System.Drawing.Point(106, 245);
            this.btn_creerMouv.Name = "btn_creerMouv";
            this.btn_creerMouv.Size = new System.Drawing.Size(137, 23);
            this.btn_creerMouv.TabIndex = 5;
            this.btn_creerMouv.Text = "Créer Mouvement Compte";
            this.btn_creerMouv.UseVisualStyleBackColor = true;
            // 
            // dg_mouv
            // 
            this.dg_mouv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_mouv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.dg_mouv.Location = new System.Drawing.Point(273, 29);
            this.dg_mouv.Name = "dg_mouv";
            this.dg_mouv.RowHeadersWidth = 51;
            this.dg_mouv.RowTemplate.Height = 24;
            this.dg_mouv.Size = new System.Drawing.Size(451, 205);
            this.dg_mouv.TabIndex = 6;
            this.dg_mouv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date Opération";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Type Mouvement";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mouvement";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_afficher);
            this.groupBox6.Controls.Add(this.date_fin);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.date_deb);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txt_slde);
            this.groupBox6.Controls.Add(this.Solde);
            this.groupBox6.Controls.Add(this.txt_tite);
            this.groupBox6.Controls.Add(this.Titulaire);
            this.groupBox6.Controls.Add(this.txt_nume);
            this.groupBox6.Controls.Add(this.Numéro);
            this.groupBox6.Location = new System.Drawing.Point(29, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(650, 125);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Compte Client";
            // 
            // Numéro
            // 
            this.Numéro.AutoSize = true;
            this.Numéro.Location = new System.Drawing.Point(6, 35);
            this.Numéro.Name = "Numéro";
            this.Numéro.Size = new System.Drawing.Size(55, 16);
            this.Numéro.TabIndex = 0;
            this.Numéro.Text = "Numéro";
            this.Numéro.Click += new System.EventHandler(this.Numéro_Click);
            // 
            // txt_nume
            // 
            this.txt_nume.Location = new System.Drawing.Point(67, 32);
            this.txt_nume.Name = "txt_nume";
            this.txt_nume.Size = new System.Drawing.Size(100, 22);
            this.txt_nume.TabIndex = 1;
            // 
            // Titulaire
            // 
            this.Titulaire.AutoSize = true;
            this.Titulaire.Location = new System.Drawing.Point(173, 35);
            this.Titulaire.Name = "Titulaire";
            this.Titulaire.Size = new System.Drawing.Size(55, 16);
            this.Titulaire.TabIndex = 2;
            this.Titulaire.Text = "Titulaire";
            // 
            // txt_tite
            // 
            this.txt_tite.Location = new System.Drawing.Point(234, 35);
            this.txt_tite.Name = "txt_tite";
            this.txt_tite.Size = new System.Drawing.Size(100, 22);
            this.txt_tite.TabIndex = 3;
            // 
            // Solde
            // 
            this.Solde.AutoSize = true;
            this.Solde.Location = new System.Drawing.Point(351, 35);
            this.Solde.Name = "Solde";
            this.Solde.Size = new System.Drawing.Size(43, 16);
            this.Solde.TabIndex = 4;
            this.Solde.Text = "Solde";
            // 
            // txt_slde
            // 
            this.txt_slde.Location = new System.Drawing.Point(400, 32);
            this.txt_slde.Name = "txt_slde";
            this.txt_slde.Size = new System.Drawing.Size(100, 22);
            this.txt_slde.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Extrait de :";
            // 
            // date_deb
            // 
            this.date_deb.Location = new System.Drawing.Point(89, 83);
            this.date_deb.Name = "date_deb";
            this.date_deb.Size = new System.Drawing.Size(154, 22);
            this.date_deb.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Jusqu\'à";
            // 
            // date_fin
            // 
            this.date_fin.Location = new System.Drawing.Point(309, 84);
            this.date_fin.Name = "date_fin";
            this.date_fin.Size = new System.Drawing.Size(115, 22);
            this.date_fin.TabIndex = 9;
            // 
            // btn_afficher
            // 
            this.btn_afficher.Location = new System.Drawing.Point(514, 81);
            this.btn_afficher.Name = "btn_afficher";
            this.btn_afficher.Size = new System.Drawing.Size(75, 23);
            this.btn_afficher.TabIndex = 10;
            this.btn_afficher.Text = "Afficher";
            this.btn_afficher.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dg_extrait);
            this.groupBox7.Location = new System.Drawing.Point(15, 146);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(732, 245);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Liste des mouvements";
            // 
            // dg_extrait
            // 
            this.dg_extrait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_extrait.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dg_extrait.Location = new System.Drawing.Point(47, 42);
            this.dg_extrait.Name = "dg_extrait";
            this.dg_extrait.RowHeadersWidth = 51;
            this.dg_extrait.RowTemplate.Height = 24;
            this.dg_extrait.Size = new System.Drawing.Size(617, 150);
            this.dg_extrait.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Date";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Type";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Débit";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Crédit";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // form_cpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_cl);
            this.Name = "form_cpt";
            this.Text = "Gestion des comptes bancaires";
            this.tab_cl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_cllient)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_mouv)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_extrait)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_cl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox text_tit;
        private System.Windows.Forms.TextBox text_rech;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_cllient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txttitulaire;
        private System.Windows.Forms.TextBox txt_solde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdb_retr;
        private System.Windows.Forms.DateTimePicker datem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdb_vers;
        private System.Windows.Forms.Button btn_creerMouv;
        private System.Windows.Forms.TextBox txt_mt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dg_mouv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txt_nume;
        private System.Windows.Forms.Label Numéro;
        private System.Windows.Forms.TextBox txt_tite;
        private System.Windows.Forms.Label Titulaire;
        private System.Windows.Forms.TextBox txt_slde;
        private System.Windows.Forms.Label Solde;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dg_extrait;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btn_afficher;
        private System.Windows.Forms.DateTimePicker date_fin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker date_deb;
        private System.Windows.Forms.Label label9;
    }
}

