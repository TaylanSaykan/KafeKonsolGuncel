using KafeKonsol.Data.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeKonsol
{
    public partial class UrunlerForm : Form
    {
        private readonly KafeVeri _db;
        BindingList<Urun> urunler;
        public UrunlerForm(KafeVeri db)
        {
            _db = db;
            urunler = new BindingList<Urun>(db.Urunler);
            InitializeComponent();
            dgvUrunler.DataSource = urunler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = txtUrunaD.Text.Trim();
            if (string.IsNullOrEmpty(ad))
            {
                MessageBox.Show("Ürün adı belirtymediniz.");
                return;

            }
            Urun urun = new Urun() { UrunAd = ad, BirimFiyat = nudBirimFiyat.Value };
            urunler.Add(urun);
        }
        Urun _duzenlenen;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.SelectedRows.Count == 0)
            {
                return;
            }
            var satir = dgvUrunler.SelectedRows[0];
            Urun urun = (Urun)satir.DataBoundItem;
            _duzenlenen = urun;

            txtUrunaD.Text = urun.UrunAd;
            nudBirimFiyat.Value = urun.BirimFiyat;
            btnEkle.Text = "KAYDET";
            dgvUrunler.Enabled = false;
            btnIptal.Show();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuSifila();
        }

        private void FormuSifila()
        {
            btnIptal.Hide();
            btnEkle.Text = "EKLE";
            txtUrunaD.Clear();
            nudBirimFiyat.Value = 0;
            dgvUrunler.Enabled = true;
            _duzenlenen = null;
        }

    }
}
