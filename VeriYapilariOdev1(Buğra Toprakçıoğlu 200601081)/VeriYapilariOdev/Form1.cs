using System.Collections;
namespace VeriYapilariOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        Kuyruk ticariKuyruk = new Kuyruk(10);
        Kuyruk bireyselKuyruk = new Kuyruk(10);
        Kuyruk ticariGecmisKuyruk = new Kuyruk(10);
        Kuyruk bireyselGecmisKuyruk = new Kuyruk(10);

        Kuyruk bireyselCagriMerkezi = new Kuyruk(2);
        Kuyruk ticariCagriMerkezi=new Kuyruk(2);


        private void Form1_Load(object sender, EventArgs e)
        {
            

            Cagri c=new Cagri();
            c.musteri.Adi = "Ahmet";
            c.musteri.MusteriTip = "Bireysel";
            c.CagriAdi = "Teknik Paket Deðiþimi";
            
            
            
            bireyselKuyruk.Insert(c);
            Yenile();
        }

        public void Yenile() //Kuyruklarda bulunan elemanlarý ListBoxlara yazdýran fonksiyon
        {
            LbBireysel.Items.Clear();
            LbTicari.Items.Clear();
            LbTicariGecmis.Items.Clear();
            LbBireyselGecmis.Items.Clear();


            for (int i = 0; i <= bireyselKuyruk.Count(); i++)
            {
                Cagri cagri = new Cagri();
                cagri = bireyselKuyruk.Access(i);
                LbBireysel.Items.Add("Müsteri Adi:" + cagri.musteri.Adi + "Çaðrý Adý:"+cagri.CagriAdi);

            }
            for (int i = 0; i <= ticariKuyruk.Count(); i++)
            {
                Cagri cagri = new Cagri();
                cagri = ticariKuyruk.Access(i);
                LbTicari.Items.Add("Müsteri Adi:" + cagri.musteri.Adi + "Çaðrý Adý:" + cagri.CagriAdi);

            }
            for (int i = 0; i <= ticariGecmisKuyruk.Count(); i++)
            {
                Cagri cagri = new Cagri();
                cagri = ticariGecmisKuyruk.Access(i);
                LbTicariGecmis.Items.Add("Müsteri Adi:" + cagri.musteri.Adi + "Çaðrý Adý:" + cagri.CagriAdi);

            }
            for (int i = 0; i <= bireyselGecmisKuyruk.Count(); i++)
            {
                Cagri cagri = new Cagri();
                cagri = bireyselGecmisKuyruk.Access(i);
                LbBireyselGecmis.Items.Add("Müsteri Adi:" + cagri.musteri.Adi + "Çaðrý Adý:" + cagri.CagriAdi);

            }

        }

        private void BtnBaslatBireysel_Click(object sender, EventArgs e)
        {
            Cagri Temp = bireyselKuyruk.Remove();
            bireyselCagriMerkezi.Insert(Temp);

            BtnBireyselDurdur.Enabled = true;

        }

        private void BtnBireyselDurdur_Click(object sender, EventArgs e)
        {
            Cagri Temp = bireyselCagriMerkezi.Remove();
            bireyselGecmisKuyruk.Insert(Temp);


        }

        private void BtnTicariCagriBaslat_Click(object sender, EventArgs e)
        {
            Cagri temp = ticariKuyruk.Remove();
            ticariCagriMerkezi.Insert(temp);

            BtnTicariCagriDurdur.Enabled = true;
        }

        private void BtnTicariCagriDurdur_Click(object sender, EventArgs e)
        {
            Cagri temp=ticariCagriMerkezi.Remove();
            ticariGecmisKuyruk.Insert(temp);
        }

        private void BtnCagriEkle_Click(object sender, EventArgs e)
        {
            
            Musteri m =new Musteri();

            m.MusteriTip = CBmusteriTipi.Text;
            m.Adi = txtBoxMusteriAd.Text;

            Cagri s = new Cagri();
            s.musteri = m;
            s.CagriAdi=txtBoxCagriAd.Text;

            if (m.MusteriTip == "Bireysel")
            {
                bireyselKuyruk.Insert(s);
            }
            else
                ticariKuyruk.Insert(s);
            
        }
    }
}