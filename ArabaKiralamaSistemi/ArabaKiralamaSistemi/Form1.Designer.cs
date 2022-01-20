namespace ArabaKiralamaSistemi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_duzelt = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_goruntule = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.cmb_kasa = new System.Windows.Forms.ComboBox();
            this.cmb_vite = new System.Windows.Forms.ComboBox();
            this.cmb_yakit = new System.Windows.Forms.ComboBox();
            this.txt_kilometre = new System.Windows.Forms.TextBox();
            this.cmb_renk = new System.Windows.Forms.ComboBox();
            this.txt_aracModel = new System.Windows.Forms.TextBox();
            this.txt_aracMarka = new System.Windows.Forms.TextBox();
            this.txt_aracKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_araclar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Araç Kodu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Araç Marka :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Araç Model :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Araç Renk :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btn_duzelt);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Controls.Add(this.btn_goruntule);
            this.groupBox1.Controls.Add(this.btn_kaydet);
            this.groupBox1.Controls.Add(this.cmb_kasa);
            this.groupBox1.Controls.Add(this.cmb_vite);
            this.groupBox1.Controls.Add(this.cmb_yakit);
            this.groupBox1.Controls.Add(this.txt_kilometre);
            this.groupBox1.Controls.Add(this.cmb_renk);
            this.groupBox1.Controls.Add(this.txt_aracModel);
            this.groupBox1.Controls.Add(this.txt_aracMarka);
            this.groupBox1.Controls.Add(this.txt_aracKodu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 224);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            // 
            // btn_duzelt
            // 
            this.btn_duzelt.Location = new System.Drawing.Point(709, 167);
            this.btn_duzelt.Name = "btn_duzelt";
            this.btn_duzelt.Size = new System.Drawing.Size(100, 33);
            this.btn_duzelt.TabIndex = 19;
            this.btn_duzelt.Text = "Düzelt";
            this.btn_duzelt.UseVisualStyleBackColor = true;
            this.btn_duzelt.Click += new System.EventHandler(this.btn_duzelt_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(709, 122);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(100, 33);
            this.btn_sil.TabIndex = 18;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_goruntule
            // 
            this.btn_goruntule.Location = new System.Drawing.Point(709, 28);
            this.btn_goruntule.Name = "btn_goruntule";
            this.btn_goruntule.Size = new System.Drawing.Size(100, 33);
            this.btn_goruntule.TabIndex = 17;
            this.btn_goruntule.Text = "Görüntüle";
            this.btn_goruntule.UseVisualStyleBackColor = true;
            this.btn_goruntule.Click += new System.EventHandler(this.btn_goruntule_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(709, 74);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(100, 33);
            this.btn_kaydet.TabIndex = 16;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // cmb_kasa
            // 
            this.cmb_kasa.FormattingEnabled = true;
            this.cmb_kasa.Items.AddRange(new object[] {
            "Hatback 5 Kapı",
            "Hatcback 3 Kapı",
            "Sedan",
            "Station Wagon"});
            this.cmb_kasa.Location = new System.Drawing.Point(504, 180);
            this.cmb_kasa.Name = "cmb_kasa";
            this.cmb_kasa.Size = new System.Drawing.Size(174, 28);
            this.cmb_kasa.TabIndex = 15;
            // 
            // cmb_vite
            // 
            this.cmb_vite.FormattingEnabled = true;
            this.cmb_vite.Items.AddRange(new object[] {
            "manuel",
            "otomatik"});
            this.cmb_vite.Location = new System.Drawing.Point(504, 134);
            this.cmb_vite.Name = "cmb_vite";
            this.cmb_vite.Size = new System.Drawing.Size(174, 28);
            this.cmb_vite.TabIndex = 14;
            // 
            // cmb_yakit
            // 
            this.cmb_yakit.FormattingEnabled = true;
            this.cmb_yakit.Items.AddRange(new object[] {
            "dizel",
            "benzinli"});
            this.cmb_yakit.Location = new System.Drawing.Point(504, 84);
            this.cmb_yakit.Name = "cmb_yakit";
            this.cmb_yakit.Size = new System.Drawing.Size(174, 28);
            this.cmb_yakit.TabIndex = 13;
            // 
            // txt_kilometre
            // 
            this.txt_kilometre.Location = new System.Drawing.Point(504, 39);
            this.txt_kilometre.Name = "txt_kilometre";
            this.txt_kilometre.Size = new System.Drawing.Size(174, 26);
            this.txt_kilometre.TabIndex = 12;
            // 
            // cmb_renk
            // 
            this.cmb_renk.FormattingEnabled = true;
            this.cmb_renk.Items.AddRange(new object[] {
            "mavi",
            "gri",
            "siyah",
            "beyaz"});
            this.cmb_renk.Location = new System.Drawing.Point(126, 177);
            this.cmb_renk.Name = "cmb_renk";
            this.cmb_renk.Size = new System.Drawing.Size(174, 28);
            this.cmb_renk.TabIndex = 6;
            // 
            // txt_aracModel
            // 
            this.txt_aracModel.Location = new System.Drawing.Point(126, 134);
            this.txt_aracModel.Name = "txt_aracModel";
            this.txt_aracModel.Size = new System.Drawing.Size(174, 26);
            this.txt_aracModel.TabIndex = 11;
            // 
            // txt_aracMarka
            // 
            this.txt_aracMarka.Location = new System.Drawing.Point(126, 87);
            this.txt_aracMarka.Name = "txt_aracMarka";
            this.txt_aracMarka.Size = new System.Drawing.Size(174, 26);
            this.txt_aracMarka.TabIndex = 10;
            // 
            // txt_aracKodu
            // 
            this.txt_aracKodu.Location = new System.Drawing.Point(126, 41);
            this.txt_aracKodu.Name = "txt_aracKodu";
            this.txt_aracKodu.Size = new System.Drawing.Size(174, 26);
            this.txt_aracKodu.TabIndex = 9;
            this.txt_aracKodu.Text = "121";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yakıt Türü :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Kasa Tipi :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Araç Kilometre :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Vites Türü :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_araclar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(945, 266);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Listesi";
            // 
            // lst_araclar
            // 
            this.lst_araclar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lst_araclar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_araclar.FullRowSelect = true;
            this.lst_araclar.HideSelection = false;
            this.lst_araclar.Location = new System.Drawing.Point(3, 22);
            this.lst_araclar.Name = "lst_araclar";
            this.lst_araclar.Size = new System.Drawing.Size(939, 241);
            this.lst_araclar.TabIndex = 0;
            this.lst_araclar.UseCompatibleStateImageBehavior = false;
            this.lst_araclar.View = System.Windows.Forms.View.Details;
            this.lst_araclar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_araclar_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "aracId";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "aracMarka";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "aracModel";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "aracRenk";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "aracKilometre";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "aracYakit";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "aracVites";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "aracKasa";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "aracKodu";
            this.columnHeader9.Width = 89;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 490);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Araç Kitalama Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_renk;
        private System.Windows.Forms.TextBox txt_aracModel;
        private System.Windows.Forms.TextBox txt_aracMarka;
        private System.Windows.Forms.TextBox txt_aracKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_kilometre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_kasa;
        private System.Windows.Forms.ComboBox cmb_vite;
        private System.Windows.Forms.ComboBox cmb_yakit;
        private System.Windows.Forms.Button btn_duzelt;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_goruntule;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.ListView lst_araclar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}

