namespace VeriYapilariOdev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbBireysel = new System.Windows.Forms.ListBox();
            this.LbTicari = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTicariQueue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnBaslatBireysel = new System.Windows.Forms.Button();
            this.BtnBireyselDurdur = new System.Windows.Forms.Button();
            this.BtnTicariCagriDurdur = new System.Windows.Forms.Button();
            this.BtnTicariCagriBaslat = new System.Windows.Forms.Button();
            this.LbBireyselGecmis = new System.Windows.Forms.ListBox();
            this.LbTicariGecmis = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCagriEkle = new System.Windows.Forms.Button();
            this.CBmusteriTipi = new System.Windows.Forms.ComboBox();
            this.txtBoxMusteriAd = new System.Windows.Forms.TextBox();
            this.txtBoxCagriAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbBireysel
            // 
            this.LbBireysel.FormattingEnabled = true;
            this.LbBireysel.HorizontalScrollbar = true;
            this.LbBireysel.ItemHeight = 20;
            this.LbBireysel.Location = new System.Drawing.Point(623, 70);
            this.LbBireysel.Name = "LbBireysel";
            this.LbBireysel.Size = new System.Drawing.Size(349, 264);
            this.LbBireysel.TabIndex = 0;
            // 
            // LbTicari
            // 
            this.LbTicari.FormattingEnabled = true;
            this.LbTicari.HorizontalScrollbar = true;
            this.LbTicari.ItemHeight = 20;
            this.LbTicari.Location = new System.Drawing.Point(214, 70);
            this.LbTicari.Name = "LbTicari";
            this.LbTicari.Size = new System.Drawing.Size(372, 264);
            this.LbTicari.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çağrı Merkezi (Ticari)";
            // 
            // lblTicariQueue
            // 
            this.lblTicariQueue.AutoSize = true;
            this.lblTicariQueue.Location = new System.Drawing.Point(214, 36);
            this.lblTicariQueue.Name = "lblTicariQueue";
            this.lblTicariQueue.Size = new System.Drawing.Size(98, 20);
            this.lblTicariQueue.TabIndex = 3;
            this.lblTicariQueue.Text = "Ticari Müşteri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bireysel Müsteri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Çağrı Merkezi (Bireysel)";
            // 
            // BtnBaslatBireysel
            // 
            this.BtnBaslatBireysel.Location = new System.Drawing.Point(27, 56);
            this.BtnBaslatBireysel.Name = "BtnBaslatBireysel";
            this.BtnBaslatBireysel.Size = new System.Drawing.Size(138, 53);
            this.BtnBaslatBireysel.TabIndex = 6;
            this.BtnBaslatBireysel.Text = "Çağrı Başlat";
            this.BtnBaslatBireysel.UseVisualStyleBackColor = true;
            this.BtnBaslatBireysel.Click += new System.EventHandler(this.BtnBaslatBireysel_Click);
            // 
            // BtnBireyselDurdur
            // 
            this.BtnBireyselDurdur.Enabled = false;
            this.BtnBireyselDurdur.Location = new System.Drawing.Point(27, 115);
            this.BtnBireyselDurdur.Name = "BtnBireyselDurdur";
            this.BtnBireyselDurdur.Size = new System.Drawing.Size(138, 53);
            this.BtnBireyselDurdur.TabIndex = 7;
            this.BtnBireyselDurdur.Text = "Çağrı Durdur";
            this.BtnBireyselDurdur.UseVisualStyleBackColor = true;
            this.BtnBireyselDurdur.Click += new System.EventHandler(this.BtnBireyselDurdur_Click);
            // 
            // BtnTicariCagriDurdur
            // 
            this.BtnTicariCagriDurdur.Enabled = false;
            this.BtnTicariCagriDurdur.Location = new System.Drawing.Point(27, 265);
            this.BtnTicariCagriDurdur.Name = "BtnTicariCagriDurdur";
            this.BtnTicariCagriDurdur.Size = new System.Drawing.Size(138, 53);
            this.BtnTicariCagriDurdur.TabIndex = 9;
            this.BtnTicariCagriDurdur.Text = "Çağrı Durdur";
            this.BtnTicariCagriDurdur.UseVisualStyleBackColor = true;
            this.BtnTicariCagriDurdur.Click += new System.EventHandler(this.BtnTicariCagriDurdur_Click);
            // 
            // BtnTicariCagriBaslat
            // 
            this.BtnTicariCagriBaslat.Location = new System.Drawing.Point(27, 206);
            this.BtnTicariCagriBaslat.Name = "BtnTicariCagriBaslat";
            this.BtnTicariCagriBaslat.Size = new System.Drawing.Size(138, 53);
            this.BtnTicariCagriBaslat.TabIndex = 8;
            this.BtnTicariCagriBaslat.Text = "Çağrı Başlat";
            this.BtnTicariCagriBaslat.UseVisualStyleBackColor = true;
            this.BtnTicariCagriBaslat.Click += new System.EventHandler(this.BtnTicariCagriBaslat_Click);
            // 
            // LbBireyselGecmis
            // 
            this.LbBireyselGecmis.FormattingEnabled = true;
            this.LbBireyselGecmis.ItemHeight = 20;
            this.LbBireyselGecmis.Location = new System.Drawing.Point(12, 388);
            this.LbBireyselGecmis.Name = "LbBireyselGecmis";
            this.LbBireyselGecmis.Size = new System.Drawing.Size(463, 144);
            this.LbBireyselGecmis.TabIndex = 10;
            // 
            // LbTicariGecmis
            // 
            this.LbTicariGecmis.FormattingEnabled = true;
            this.LbTicariGecmis.ItemHeight = 20;
            this.LbTicariGecmis.Location = new System.Drawing.Point(500, 388);
            this.LbTicariGecmis.Name = "LbTicariGecmis";
            this.LbTicariGecmis.Size = new System.Drawing.Size(463, 144);
            this.LbTicariGecmis.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bireysel Müsteri Çağrı Geçmişi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ticari Müsteri Çağrı Geçmişi";
            // 
            // BtnCagriEkle
            // 
            this.BtnCagriEkle.Location = new System.Drawing.Point(1099, 352);
            this.BtnCagriEkle.Name = "BtnCagriEkle";
            this.BtnCagriEkle.Size = new System.Drawing.Size(144, 61);
            this.BtnCagriEkle.TabIndex = 14;
            this.BtnCagriEkle.Text = "Çağrı Ekle";
            this.BtnCagriEkle.UseVisualStyleBackColor = true;
            this.BtnCagriEkle.Click += new System.EventHandler(this.BtnCagriEkle_Click);
            // 
            // CBmusteriTipi
            // 
            this.CBmusteriTipi.FormattingEnabled = true;
            this.CBmusteriTipi.Items.AddRange(new object[] {
            "Bireysel",
            "Ticari"});
            this.CBmusteriTipi.Location = new System.Drawing.Point(1068, 278);
            this.CBmusteriTipi.Name = "CBmusteriTipi";
            this.CBmusteriTipi.Size = new System.Drawing.Size(196, 28);
            this.CBmusteriTipi.TabIndex = 15;
            // 
            // txtBoxMusteriAd
            // 
            this.txtBoxMusteriAd.Location = new System.Drawing.Point(1068, 128);
            this.txtBoxMusteriAd.Name = "txtBoxMusteriAd";
            this.txtBoxMusteriAd.Size = new System.Drawing.Size(196, 27);
            this.txtBoxMusteriAd.TabIndex = 16;
            // 
            // txtBoxCagriAd
            // 
            this.txtBoxCagriAd.Location = new System.Drawing.Point(1068, 206);
            this.txtBoxCagriAd.Name = "txtBoxCagriAd";
            this.txtBoxCagriAd.Size = new System.Drawing.Size(196, 27);
            this.txtBoxCagriAd.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1068, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Çağrı Ekle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1068, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Müşteri Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1068, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Çağrı Adı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1068, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Müşteri Tipi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 544);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxCagriAd);
            this.Controls.Add(this.txtBoxMusteriAd);
            this.Controls.Add(this.CBmusteriTipi);
            this.Controls.Add(this.BtnCagriEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbTicariGecmis);
            this.Controls.Add(this.LbBireyselGecmis);
            this.Controls.Add(this.BtnTicariCagriDurdur);
            this.Controls.Add(this.BtnTicariCagriBaslat);
            this.Controls.Add(this.BtnBireyselDurdur);
            this.Controls.Add(this.BtnBaslatBireysel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTicariQueue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbTicari);
            this.Controls.Add(this.LbBireysel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LbBireysel;
        private ListBox LbTicari;
        private Label label1;
        private Label lblTicariQueue;
        private Label label3;
        private Label label4;
        private Button BtnBaslatBireysel;
        private Button BtnBireyselDurdur;
        private Button BtnTicariCagriDurdur;
        private Button BtnTicariCagriBaslat;
        private ListBox LbBireyselGecmis;
        private ListBox LbTicariGecmis;
        private Label label2;
        private Label label5;
        private Button BtnCagriEkle;
        private ComboBox CBmusteriTipi;
        private TextBox txtBoxMusteriAd;
        private TextBox txtBoxCagriAd;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}