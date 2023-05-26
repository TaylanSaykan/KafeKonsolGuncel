namespace KafeKonsol
{
    partial class SiparisForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblOdemeTutarı = new Label();
            lblMasaNo = new Label();
            dgvDetaylar = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnEkle = new Button();
            btnMasaTasi = new Button();
            button3 = new Button();
            btnOdemeAl = new Button();
            btnAnasayFayaDon = new Button();
            cboUrun = new ComboBox();
            nudAdeet = new NumericUpDown();
            cboMasaNo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAdeet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(58, 28);
            label1.TabIndex = 0;
            label1.Text = "Ürün";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(207, 12);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 1;
            label2.Text = "Adet";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(594, 11);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 2;
            label3.Text = "Masa No";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(625, 401);
            label4.Name = "label4";
            label4.Size = new Size(135, 28);
            label4.TabIndex = 3;
            label4.Text = "Ödeme Tutarı:";
            // 
            // lblOdemeTutarı
            // 
            lblOdemeTutarı.Anchor = AnchorStyles.Right;
            lblOdemeTutarı.AutoSize = true;
            lblOdemeTutarı.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOdemeTutarı.Location = new Point(755, 401);
            lblOdemeTutarı.Name = "lblOdemeTutarı";
            lblOdemeTutarı.Size = new Size(71, 28);
            lblOdemeTutarı.TabIndex = 4;
            lblOdemeTutarı.Text = "0,00 ₺";
            // 
            // lblMasaNo
            // 
            lblMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblMasaNo.BackColor = Color.IndianRed;
            lblMasaNo.Font = new Font("Segoe UI", 60F, FontStyle.Bold, GraphicsUnit.Point);
            lblMasaNo.ForeColor = Color.White;
            lblMasaNo.Location = new Point(594, 91);
            lblMasaNo.Name = "lblMasaNo";
            lblMasaNo.Size = new Size(263, 310);
            lblMasaNo.TabIndex = 5;
            lblMasaNo.Text = "00";
            lblMasaNo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.AllowUserToAddRows = false;
            dgvDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetaylar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaylar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDetaylar.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvDetaylar.GridColor = SystemColors.ActiveCaption;
            dgvDetaylar.Location = new Point(14, 91);
            dgvDetaylar.Margin = new Padding(3, 4, 3, 4);
            dgvDetaylar.MultiSelect = false;
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.ReadOnly = true;
            dgvDetaylar.RowHeadersVisible = false;
            dgvDetaylar.RowHeadersWidth = 51;
            dgvDetaylar.RowTemplate.Height = 25;
            dgvDetaylar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetaylar.Size = new Size(555, 467);
            dgvDetaylar.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "UrunAd";
            Column1.HeaderText = "Ürün";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "BirimFiyat";
            Column2.HeaderText = "Fiyat";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Adet";
            Column3.HeaderText = "Adet";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TutarTL";
            Column4.HeaderText = "Tutar";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(361, 44);
            btnEkle.Margin = new Padding(3, 4, 3, 4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(102, 39);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnMasaTasi
            // 
            btnMasaTasi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMasaTasi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasaTasi.Location = new Point(745, 43);
            btnMasaTasi.Margin = new Padding(3, 4, 3, 4);
            btnMasaTasi.Name = "btnMasaTasi";
            btnMasaTasi.Size = new Size(112, 39);
            btnMasaTasi.TabIndex = 8;
            btnMasaTasi.Text = "TAŞI";
            btnMasaTasi.UseVisualStyleBackColor = true;
            btnMasaTasi.Click += btnMasaTasi_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(594, 433);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(127, 57);
            button3.TabIndex = 9;
            button3.Text = " İPTAL";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnOdemeAl
            // 
            btnOdemeAl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOdemeAl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOdemeAl.Location = new Point(728, 433);
            btnOdemeAl.Margin = new Padding(3, 4, 3, 4);
            btnOdemeAl.Name = "btnOdemeAl";
            btnOdemeAl.Size = new Size(127, 57);
            btnOdemeAl.TabIndex = 10;
            btnOdemeAl.Text = "ÖDEME AL";
            btnOdemeAl.UseVisualStyleBackColor = true;
            btnOdemeAl.Click += btnOdemeAl_Click;
            // 
            // btnAnasayFayaDon
            // 
            btnAnasayFayaDon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAnasayFayaDon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnasayFayaDon.Location = new Point(594, 499);
            btnAnasayFayaDon.Margin = new Padding(3, 4, 3, 4);
            btnAnasayFayaDon.Name = "btnAnasayFayaDon";
            btnAnasayFayaDon.Size = new Size(261, 57);
            btnAnasayFayaDon.TabIndex = 11;
            btnAnasayFayaDon.Text = "ANASAYFAYA DÖN";
            btnAnasayFayaDon.UseVisualStyleBackColor = true;
            btnAnasayFayaDon.Click += btnAnasayFayaDon_Click;
            // 
            // cboUrun
            // 
            cboUrun.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUrun.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboUrun.FormattingEnabled = true;
            cboUrun.Location = new Point(14, 44);
            cboUrun.Margin = new Padding(3, 4, 3, 4);
            cboUrun.Name = "cboUrun";
            cboUrun.Size = new Size(186, 36);
            cboUrun.TabIndex = 12;
            // 
            // nudAdeet
            // 
            nudAdeet.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nudAdeet.Location = new Point(217, 44);
            nudAdeet.Margin = new Padding(3, 4, 3, 4);
            nudAdeet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudAdeet.Name = "nudAdeet";
            nudAdeet.Size = new Size(137, 34);
            nudAdeet.TabIndex = 13;
            nudAdeet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cboMasaNo
            // 
            cboMasaNo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cboMasaNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMasaNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboMasaNo.FormattingEnabled = true;
            cboMasaNo.Location = new Point(594, 43);
            cboMasaNo.Margin = new Padding(3, 4, 3, 4);
            cboMasaNo.Name = "cboMasaNo";
            cboMasaNo.Size = new Size(139, 36);
            cboMasaNo.TabIndex = 14;
            // 
            // SiparisForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 593);
            Controls.Add(cboMasaNo);
            Controls.Add(nudAdeet);
            Controls.Add(cboUrun);
            Controls.Add(btnAnasayFayaDon);
            Controls.Add(btnOdemeAl);
            Controls.Add(button3);
            Controls.Add(btnMasaTasi);
            Controls.Add(btnEkle);
            Controls.Add(dgvDetaylar);
            Controls.Add(lblMasaNo);
            Controls.Add(lblOdemeTutarı);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SiparisForm";
            Text = "Masa 0";
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAdeet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblOdemeTutarı;
        private Label lblMasaNo;
        private DataGridView dgvDetaylar;
        private Button btnEkle;
        private Button btnMasaTasi;
        private Button button3;
        private Button btnOdemeAl;
        private Button btnAnasayFayaDon;
        private ComboBox cboUrun;
        private NumericUpDown nudAdeet;
        private ComboBox cboMasaNo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}