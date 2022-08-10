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
    public partial class SatisFormu : Form
    {
        public SatisFormu()
        {
            InitializeComponent();
        }

        public Satis Satis { get; set; }
        public bool Guncelleme { get; set; } = false;    

        private void Tamambutonu_Click(object sender, EventArgs e)
        {
            if(nmpfiyat.Value == 0)
            {
                errorProvider1.SetError(nmpfiyat, "Lütfen Fiyatı Belirleyiniz");
                nmpfiyat.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmpfiyat, "");

            }
            Satis.Tarih = dtptarih.Value;
            Satis.Fiyat = (double)nmpfiyat.Value;
            Satis.ArabaID = Guid.Parse(txtID.Text);
            Satis.MusteriID = Guid.Parse(txtMusteri.Text);



            DialogResult = DialogResult.OK;
        }

        private void İptalButonu_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void SatisFormu_Load(object sender, EventArgs e)
        {
            txtID.Text = Satis.ID.ToString();
            if (Guncelleme)
            {
                txtMusteri.Text = Satis.MusteriID.ToString();
                txtaraba.Text = Satis.ArabaID.ToString();
                nmpfiyat.Value = (decimal)Satis.Fiyat;
                dtptarih.Value = Satis.Tarih;
            }
          
           
        }

        private void musterisec_Click(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler();
            if(musteri.ShowDialog() == DialogResult.OK)
            {              
                txtMusteri.Text = musteri.Musteri.ToString();
            }
        }

        private void arabasec_Click(object sender, EventArgs e)
        {

           ArabaFormu araba  = new ArabaFormu();
            if (araba.ShowDialog() == DialogResult.OK)
            {
                txtaraba.Text = araba.Arabalar.ToString();
            }
        }
    }
}



