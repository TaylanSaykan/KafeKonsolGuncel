﻿using KafeKonsol.Data.Class;
using KafeKonsol.Data.Enum;
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
    public partial class SiparisForm : Form
    {

        public event EventHandler<MAsaTasiEventArgs>? MAsaTasi;
        private readonly KafeVeri _db;
        private readonly Siparis _siparis;
        private readonly BindingList<SiparisDetay> _siparisDetaylar;
        public SiparisForm(KafeVeri db, Siparis siparis)
        {
            _db = db;
            _siparis = siparis;
            _siparisDetaylar = new BindingList<SiparisDetay>(_siparis.SiparisDetaylar);
            _siparisDetaylar.ListChanged += _siparisDetaylar_ListChanged;
            InitializeComponent();
            dgvDetaylar.AutoGenerateColumns = false;
            dgvDetaylar.DataSource = _siparisDetaylar;
            Guncelle();
        }

        private void _siparisDetaylar_ListChanged(object? sender, ListChangedEventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            Text = $"Masa {_siparis.MasaNo}(Açılış : {_siparis.AcilisZamani})";
            lblMasaNo.Text = _siparis.MasaNo.ToString("00");
            lblOdemeTutarı.Text = _siparis.ToplamTutarTL;
            cboUrun.DataSource = _db.Urunler;
            MasanolarıYukle();
        }

        private void MasanolarıYukle()
        {
            cboMasaNo.Items.Clear();

            for (int i = 1; i < _db.MasaAdet; i++)
            {
                if (!_db.AktifSiparisler.Any(x => x.MasaNo == i))
                {
                    cboMasaNo.Items.Add(i);
                } 
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urun urun = (Urun)cboUrun.SelectedItem;
            if (urun == null) return;
            // var sd = new SiparisDetay()
            // {
            //     UrunAd = urun.UrunAd,
            //     BirimFiyat = urun.BirimFiyat,
            //     Adet = (int)nudAdeet.Value
            // };
            //_siparisDetaylar.Add(sd);
            var sd = _siparisDetaylar.FirstOrDefault(x => x.UrunAd == urun.UrunAd);
            if (sd == null)
            {
                sd = new SiparisDetay()
                {
                    UrunAd = urun.UrunAd,
                    BirimFiyat = urun.BirimFiyat,
                    Adet = (int)nudAdeet.Value
                };
                _siparisDetaylar.Add(sd);

            }
            else
            {
                sd.Adet += (int)nudAdeet.Value;
                _siparisDetaylar.ResetBindings();
            }
        }

        private void btnAnasayFayaDon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            MasayiKapat(SiparisDurum.Odendi, _siparis.ToplamTutar());
        }

        private void MasayiKapat(SiparisDurum yeniDurum, decimal odenenTutar)
        {
            _siparis.Durum = yeniDurum;
            _siparis.OdenenTutar = odenenTutar;
            _siparis.KapanisZamani = DateTime.Now;
            _db.AktifSiparisler.Remove(_siparis);
            _db.GecmisSiparisler.Add(_siparis);
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MasayiKapat(SiparisDurum.Odendi, _siparis.ToplamTutar());

        }

        private void btnMasaTasi_Click(object sender, EventArgs e)
        {
            if (cboMasaNo.SelectedIndex == -1) return;
            int eskiMasaNO = _siparis.MasaNo;
            int hedefMasaNo = (int)cboMasaNo.SelectedItem;
            _siparis.MasaNo = hedefMasaNo;
            Guncelle();

            if (MAsaTasi != null)
            {
                var args = new MAsaTasiEventArgs(eskiMasaNO, hedefMasaNo);
                MAsaTasi(this, args);
            }

        }
    }
}
