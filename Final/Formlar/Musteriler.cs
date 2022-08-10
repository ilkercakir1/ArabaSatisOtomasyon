using Final.Bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.Formlar
{
    public partial class Musteriler : Form
    {
        public Musteri Musteri { get; private set; }

        public Musteriler()
        {
            InitializeComponent();
        }





        private void musterieklebuton1_Click(object sender, EventArgs e)
        {
            MusteriFormu musteriFormu = new MusteriFormu();
            {
                Text = "Müsteri Ekle";
                Musteri = new Musteri() { ID = Guid.NewGuid() };
            };
        dönmesatırı:
            var sonuc = musteriFormu.ShowDialog();
            if (sonuc != DialogResult.OK)
            {
                bool b = BLogic.MusteriEkle(musteriFormu.Musteri);
                if (b)
                {
                    DataSet komutlar = BLogic.MusterileriGetir("");
                    if (komutlar != null)
                        dataGridView1.DataSource = komutlar.Tables[0];
                    else
                        goto dönmesatırı;
                }
                else
                {



                }


            }



        }

        private void musteribulbuton_Click(object sender, EventArgs e)
        {
            DataSet komutlar = BLogic.MusterileriGetir(musteribultext.Text);
            if (komutlar != null)
                dataGridView1.DataSource = komutlar.Tables[0];
        }

        private void musteriduzenlebuton_Click(object sender, EventArgs e)
        {

            DataGridViewRow sutun = dataGridView1.SelectedRows[0];
            MusteriFormu musteriFormu = new MusteriFormu();
            {
                Text = "Müsteri Düzenle";
                //  MusteriGuncelleme = true;
                Musteri = new Musteri()
                {
                    ID = Guid.Parse(sutun.Cells[0].Value.ToString()),
                    Adi = sutun.Cells[1].Value.ToString(),
                    Soyadi = sutun.Cells[2].Value.ToString(),
                    Telefon = sutun.Cells[3].Value.ToString(),
                    Mail = sutun.Cells[4].Value.ToString(),
                    Adres = sutun.Cells[5].Value.ToString(),
                };
            };
            var sonuc = musteriFormu.ShowDialog();
            if (sonuc != DialogResult.OK)
            {
                bool b = BLogic.MusteriGuncelle(musteriFormu.Musteri);
                if (b)
                {
                    sutun.Cells[1].Value = musteriFormu.Musteri.Adi;
                    sutun.Cells[2].Value = musteriFormu.Musteri.Soyadi;
                    sutun.Cells[3].Value = musteriFormu.Musteri.Telefon;
                    sutun.Cells[4].Value = musteriFormu.Musteri.Mail;
                    sutun.Cells[5].Value = musteriFormu.Musteri.Adres;
                };
            }
        }

        private void musterisilbuton_Click(object sender, EventArgs e)
        {
            DataGridViewRow sutun = dataGridView1.SelectedRows[0];
            var ID = (sutun.Cells[0].Value.ToString());


            var sonuc = MessageBox.Show("Seçili Kayıt Silinsin mi", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc != DialogResult.OK)
            {
                bool b = BLogic.MusteriSil(ID);
                if (b)
                {

                    DataSet komutlar = BLogic.MusterileriGetir("");
                    if (komutlar != null)
                        dataGridView1.DataSource = komutlar.Tables[0];
                }
            };
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MusterileriGetir("");
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }
        public Musteri musteri {  get; set; }
        private void Tamambutonu_Click(object sender, EventArgs e)
        {

            DataGridViewRow sutun = dataGridView1.SelectedRows[0];
          
                Musteri = new Musteri()
                {
                    ID = Guid.Parse(sutun.Cells[0].Value.ToString()),
                    Adi = sutun.Cells[1].Value.ToString(),
                    Soyadi = sutun.Cells[2].Value.ToString(),
                    Telefon = sutun.Cells[3].Value.ToString(),
                    Mail = sutun.Cells[4].Value.ToString(),
                    Adres = sutun.Cells[5].Value.ToString(),
                  
                };


            DialogResult = DialogResult.OK;

            }

        private void İptalButonu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
            }
        
    
