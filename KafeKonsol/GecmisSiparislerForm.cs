﻿using KafeKonsol.Data.Class;
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
    public partial class GecmisSiparislerForm : Form
    {
        private readonly KafeVeri _db;
        public GecmisSiparislerForm(KafeVeri db)
        {
            _db = db;
            InitializeComponent();
            dgvSiparisler.DataSource = _db.GecmisSiparisler;
        }

        private void GecmisSiparislerForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvSiparisler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDetyalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSiparisler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count == 0)
            {
                dgvDetyalar.DataSource = null;
            }
            else
            {
                var secilenSatir = dgvSiparisler.SelectedRows[0];
                var siparis = (Siparis)secilenSatir.DataBoundItem;
                dgvDetyalar.DataSource=siparis.SiparisDetaylar;
            }
        }
    }
}
