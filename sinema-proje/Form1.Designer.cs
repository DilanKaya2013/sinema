namespace sinema_proje
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.lblFilmAd = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.lblImdb = new System.Windows.Forms.Label();
            this.txtOzet = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEkleFilmAd = new System.Windows.Forms.TextBox();
            this.txtEkleYil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEkleTur = new System.Windows.Forms.ComboBox();
            this.txtEklePuan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEkleOzet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEklePoster = new System.Windows.Forms.Button();
            this.pbEklePoster = new System.Windows.Forms.PictureBox();
            this.pbGuncellePoster = new System.Windows.Forms.PictureBox();
            this.btnGuncellePoster = new System.Windows.Forms.Button();
            this.txtGuncelleOzet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGuncellePuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGuncelleTur = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGuncelleYil = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGuncelleFilmAd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imdb_puan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.film_posteri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ozet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEklePoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuncellePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(15, 15);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1098, 702);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage1.Controls.Add(this.btnGuncelle);
            this.tabPage1.Controls.Add(this.btnSil);
            this.tabPage1.Controls.Add(this.txtOzet);
            this.tabPage1.Controls.Add(this.lblImdb);
            this.tabPage1.Controls.Add(this.lblYil);
            this.tabPage1.Controls.Add(this.lblTur);
            this.tabPage1.Controls.Add(this.lblFilmAd);
            this.tabPage1.Controls.Add(this.pbPoster);
            this.tabPage1.Controls.Add(this.dgvListe);
            this.tabPage1.Location = new System.Drawing.Point(4, 57);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1090, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Film Listesi";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnKaydet);
            this.tabPage2.Controls.Add(this.pbEklePoster);
            this.tabPage2.Controls.Add(this.btnEklePoster);
            this.tabPage2.Controls.Add(this.txtEkleOzet);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtEklePuan);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmbEkleTur);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtEkleYil);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtEkleFilmAd);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 57);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1090, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Film Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.pbGuncellePoster);
            this.tabPage3.Controls.Add(this.btnGuncellePoster);
            this.tabPage3.Controls.Add(this.txtGuncelleOzet);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.txtGuncellePuan);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cmbGuncelleTur);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.txtGuncelleYil);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.txtGuncelleFilmAd);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 57);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1090, 641);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Film Güncelle";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.filmad,
            this.yil,
            this.tur,
            this.imdb_puan,
            this.film_posteri,
            this.ozet});
            this.dgvListe.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvListe.Location = new System.Drawing.Point(3, 3);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(484, 635);
            this.dgvListe.TabIndex = 0;
            this.dgvListe.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellEnter);
            // 
            // pbPoster
            // 
            this.pbPoster.Location = new System.Drawing.Point(682, 33);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(202, 240);
            this.pbPoster.TabIndex = 1;
            this.pbPoster.TabStop = false;
            // 
            // lblFilmAd
            // 
            this.lblFilmAd.AutoSize = true;
            this.lblFilmAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmAd.Location = new System.Drawing.Point(515, 293);
            this.lblFilmAd.Name = "lblFilmAd";
            this.lblFilmAd.Size = new System.Drawing.Size(142, 37);
            this.lblFilmAd.TabIndex = 2;
            this.lblFilmAd.Text = "Film Adı";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(518, 348);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(39, 24);
            this.lblTur.TabIndex = 3;
            this.lblTur.Text = "Tür";
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.Location = new System.Drawing.Point(518, 383);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(30, 24);
            this.lblYil.TabIndex = 4;
            this.lblYil.Text = "Yıl";
            // 
            // lblImdb
            // 
            this.lblImdb.AutoSize = true;
            this.lblImdb.Location = new System.Drawing.Point(921, 383);
            this.lblImdb.Name = "lblImdb";
            this.lblImdb.Size = new System.Drawing.Size(55, 24);
            this.lblImdb.TabIndex = 5;
            this.lblImdb.Text = "IMDB";
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(522, 424);
            this.txtOzet.Multiline = true;
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOzet.Size = new System.Drawing.Size(552, 139);
            this.txtOzet.TabIndex = 6;
            // 
            // btnSil
            // 
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.Location = new System.Drawing.Point(832, 586);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(116, 47);
            this.btnSil.TabIndex = 1;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(954, 586);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(120, 47);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı";
            // 
            // txtEkleFilmAd
            // 
            this.txtEkleFilmAd.Location = new System.Drawing.Point(116, 69);
            this.txtEkleFilmAd.Name = "txtEkleFilmAd";
            this.txtEkleFilmAd.Size = new System.Drawing.Size(957, 29);
            this.txtEkleFilmAd.TabIndex = 1;
            // 
            // txtEkleYil
            // 
            this.txtEkleYil.Location = new System.Drawing.Point(116, 142);
            this.txtEkleYil.Name = "txtEkleYil";
            this.txtEkleYil.Size = new System.Drawing.Size(957, 29);
            this.txtEkleYil.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yıl";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tür";
            // 
            // cmbEkleTur
            // 
            this.cmbEkleTur.FormattingEnabled = true;
            this.cmbEkleTur.Items.AddRange(new object[] {
            "Dram",
            "Komedi",
            "Aksiyon",
            "Korku",
            "Gerilim",
            "Animasyon",
            "Macera"});
            this.cmbEkleTur.Location = new System.Drawing.Point(116, 104);
            this.cmbEkleTur.Name = "cmbEkleTur";
            this.cmbEkleTur.Size = new System.Drawing.Size(957, 32);
            this.cmbEkleTur.TabIndex = 5;
            // 
            // txtEklePuan
            // 
            this.txtEklePuan.Location = new System.Drawing.Point(116, 177);
            this.txtEklePuan.Name = "txtEklePuan";
            this.txtEklePuan.Size = new System.Drawing.Size(957, 29);
            this.txtEklePuan.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "IMDB Puanı";
            // 
            // txtEkleOzet
            // 
            this.txtEkleOzet.Location = new System.Drawing.Point(116, 212);
            this.txtEkleOzet.Multiline = true;
            this.txtEkleOzet.Name = "txtEkleOzet";
            this.txtEkleOzet.Size = new System.Drawing.Size(703, 331);
            this.txtEkleOzet.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Özet";
            // 
            // btnEklePoster
            // 
            this.btnEklePoster.Location = new System.Drawing.Point(825, 218);
            this.btnEklePoster.Name = "btnEklePoster";
            this.btnEklePoster.Size = new System.Drawing.Size(248, 44);
            this.btnEklePoster.TabIndex = 10;
            this.btnEklePoster.Text = "Poster Seçin";
            this.btnEklePoster.UseVisualStyleBackColor = true;
            this.btnEklePoster.Click += new System.EventHandler(this.btnEklePoster_Click);
            // 
            // pbEklePoster
            // 
            this.pbEklePoster.Location = new System.Drawing.Point(825, 272);
            this.pbEklePoster.Name = "pbEklePoster";
            this.pbEklePoster.Size = new System.Drawing.Size(248, 271);
            this.pbEklePoster.TabIndex = 11;
            this.pbEklePoster.TabStop = false;
            // 
            // pbGuncellePoster
            // 
            this.pbGuncellePoster.Location = new System.Drawing.Point(619, 194);
            this.pbGuncellePoster.Name = "pbGuncellePoster";
            this.pbGuncellePoster.Size = new System.Drawing.Size(248, 271);
            this.pbGuncellePoster.TabIndex = 23;
            this.pbGuncellePoster.TabStop = false;
            // 
            // btnGuncellePoster
            // 
            this.btnGuncellePoster.Location = new System.Drawing.Point(619, 140);
            this.btnGuncellePoster.Name = "btnGuncellePoster";
            this.btnGuncellePoster.Size = new System.Drawing.Size(248, 44);
            this.btnGuncellePoster.TabIndex = 22;
            this.btnGuncellePoster.Text = "Poster Seçin";
            this.btnGuncellePoster.UseVisualStyleBackColor = true;
            // 
            // txtGuncelleOzet
            // 
            this.txtGuncelleOzet.Location = new System.Drawing.Point(287, 282);
            this.txtGuncelleOzet.Multiline = true;
            this.txtGuncelleOzet.Name = "txtGuncelleOzet";
            this.txtGuncelleOzet.Size = new System.Drawing.Size(296, 183);
            this.txtGuncelleOzet.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Özet";
            // 
            // txtGuncellePuan
            // 
            this.txtGuncellePuan.Location = new System.Drawing.Point(287, 247);
            this.txtGuncellePuan.Name = "txtGuncellePuan";
            this.txtGuncellePuan.Size = new System.Drawing.Size(296, 29);
            this.txtGuncellePuan.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(174, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "IMDB Puanı";
            // 
            // cmbGuncelleTur
            // 
            this.cmbGuncelleTur.FormattingEnabled = true;
            this.cmbGuncelleTur.Location = new System.Drawing.Point(287, 174);
            this.cmbGuncelleTur.Name = "cmbGuncelleTur";
            this.cmbGuncelleTur.Size = new System.Drawing.Size(296, 32);
            this.cmbGuncelleTur.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tür";
            // 
            // txtGuncelleYil
            // 
            this.txtGuncelleYil.Location = new System.Drawing.Point(287, 212);
            this.txtGuncelleYil.Name = "txtGuncelleYil";
            this.txtGuncelleYil.Size = new System.Drawing.Size(296, 29);
            this.txtGuncelleYil.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Yıl";
            // 
            // txtGuncelleFilmAd
            // 
            this.txtGuncelleFilmAd.Location = new System.Drawing.Point(287, 139);
            this.txtGuncelleFilmAd.Name = "txtGuncelleFilmAd";
            this.txtGuncelleFilmAd.Size = new System.Drawing.Size(296, 29);
            this.txtGuncelleFilmAd.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Film Adı";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(462, 564);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(193, 69);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // filmad
            // 
            this.filmad.DataPropertyName = "filmad";
            this.filmad.HeaderText = "Film Adı";
            this.filmad.Name = "filmad";
            this.filmad.ReadOnly = true;
            // 
            // yil
            // 
            this.yil.DataPropertyName = "yil";
            this.yil.HeaderText = "Yıl";
            this.yil.Name = "yil";
            this.yil.ReadOnly = true;
            this.yil.Visible = false;
            // 
            // tur
            // 
            this.tur.DataPropertyName = "tur";
            this.tur.HeaderText = "Türü";
            this.tur.Name = "tur";
            this.tur.ReadOnly = true;
            // 
            // imdb_puan
            // 
            this.imdb_puan.DataPropertyName = "imdb_puan";
            this.imdb_puan.HeaderText = "IMDB Puanı";
            this.imdb_puan.Name = "imdb_puan";
            this.imdb_puan.ReadOnly = true;
            // 
            // film_posteri
            // 
            this.film_posteri.DataPropertyName = "film_posteri";
            this.film_posteri.HeaderText = "Poster";
            this.film_posteri.Name = "film_posteri";
            this.film_posteri.ReadOnly = true;
            this.film_posteri.Visible = false;
            // 
            // ozet
            // 
            this.ozet.DataPropertyName = "ozet";
            this.ozet.HeaderText = "Özet";
            this.ozet.Name = "ozet";
            this.ozet.ReadOnly = true;
            this.ozet.Visible = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(459, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 69);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 702);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEklePoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuncellePoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvListe;
        private System.Windows.Forms.Label lblFilmAd;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtOzet;
        private System.Windows.Forms.Label lblImdb;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.PictureBox pbEklePoster;
        private System.Windows.Forms.Button btnEklePoster;
        private System.Windows.Forms.TextBox txtEkleOzet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEklePuan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEkleTur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEkleYil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEkleFilmAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbGuncellePoster;
        private System.Windows.Forms.Button btnGuncellePoster;
        private System.Windows.Forms.TextBox txtGuncelleOzet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGuncellePuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGuncelleTur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGuncelleYil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGuncelleFilmAd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmad;
        private System.Windows.Forms.DataGridViewTextBoxColumn yil;
        private System.Windows.Forms.DataGridViewTextBoxColumn tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn imdb_puan;
        private System.Windows.Forms.DataGridViewTextBoxColumn film_posteri;
        private System.Windows.Forms.DataGridViewTextBoxColumn ozet;
        private System.Windows.Forms.Button button1;
    }
}

