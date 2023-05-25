namespace KafeKonsol
{
    partial class GecmisSiparislerForm
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
            splitContainer1 = new SplitContainer();
            dgvSiparisler = new DataGridView();
            label1 = new Label();
            dgvDetyalar = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetyalar).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvSiparisler);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvDetyalar);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(936, 681);
            splitContainer1.SplitterDistance = 339;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 22;
            // 
            // dgvSiparisler
            // 
            dgvSiparisler.AllowUserToAddRows = false;
            dgvSiparisler.AllowUserToDeleteRows = false;
            dgvSiparisler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSiparisler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSiparisler.Location = new Point(14, 44);
            dgvSiparisler.Margin = new Padding(3, 4, 3, 4);
            dgvSiparisler.MultiSelect = false;
            dgvSiparisler.Name = "dgvSiparisler";
            dgvSiparisler.ReadOnly = true;
            dgvSiparisler.RowHeadersVisible = false;
            dgvSiparisler.RowHeadersWidth = 51;
            dgvSiparisler.RowTemplate.Height = 25;
            dgvSiparisler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSiparisler.Size = new Size(909, 276);
            dgvSiparisler.TabIndex = 1;
            dgvSiparisler.CellContentClick += dgvSiparisler_CellContentClick;
            dgvSiparisler.SelectionChanged += dgvSiparisler_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 0;
            label1.Text = "Siparişler";
            // 
            // dgvDetyalar
            // 
            dgvDetyalar.AllowUserToAddRows = false;
            dgvDetyalar.AllowUserToDeleteRows = false;
            dgvDetyalar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetyalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetyalar.Location = new Point(14, 44);
            dgvDetyalar.Margin = new Padding(3, 4, 3, 4);
            dgvDetyalar.MultiSelect = false;
            dgvDetyalar.Name = "dgvDetyalar";
            dgvDetyalar.ReadOnly = true;
            dgvDetyalar.RowHeadersVisible = false;
            dgvDetyalar.RowHeadersWidth = 51;
            dgvDetyalar.RowTemplate.Height = 25;
            dgvDetyalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetyalar.Size = new Size(909, 276);
            dgvDetyalar.TabIndex = 1;
            dgvDetyalar.CellContentClick += dgvDetyalar_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 12);
            label2.Name = "label2";
            label2.Size = new Size(168, 28);
            label2.TabIndex = 0;
            label2.Text = "Sipariş Detayları";
            // 
            // GecmisSiparislerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 681);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GecmisSiparislerForm";
            Text = "Geçmiş Siparişler";
            Load += GecmisSiparislerForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSiparisler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetyalar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dgvSiparisler;
        private Label label1;
        private DataGridView dgvDetyalar;
        private Label label2;
    }
}