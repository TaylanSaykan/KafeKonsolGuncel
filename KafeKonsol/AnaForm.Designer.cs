namespace KafeKonsol
{
    partial class AnaForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            menuStrip1 = new MenuStrip();
            tsmiUrunler = new ToolStripMenuItem();
            tsmiGecmissiparisler = new ToolStripMenuItem();
            lvwMasalar = new ListView();
            iMasalar = new ImageList(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiUrunler, tsmiGecmissiparisler });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(697, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiUrunler
            // 
            tsmiUrunler.Name = "tsmiUrunler";
            tsmiUrunler.Size = new Size(71, 24);
            tsmiUrunler.Text = "Ürünler";
            tsmiUrunler.Click += tsmiUrunler_Click;
            // 
            // tsmiGecmissiparisler
            // 
            tsmiGecmissiparisler.Name = "tsmiGecmissiparisler";
            tsmiGecmissiparisler.Size = new Size(136, 24);
            tsmiGecmissiparisler.Text = "Geçmiş Siparişler";
            tsmiGecmissiparisler.Click += tsmiGecmissiparisler_Click;
            // 
            // lvwMasalar
            // 
            lvwMasalar.Dock = DockStyle.Fill;
            lvwMasalar.LargeImageList = iMasalar;
            lvwMasalar.Location = new Point(0, 30);
            lvwMasalar.Margin = new Padding(4);
            lvwMasalar.Name = "lvwMasalar";
            lvwMasalar.Size = new Size(697, 407);
            lvwMasalar.TabIndex = 1;
            lvwMasalar.UseCompatibleStateImageBehavior = false;
            lvwMasalar.SelectedIndexChanged += lvwMasalar_SelectedIndexChanged;
            lvwMasalar.DoubleClick += lvwMasalar_DoubleClick;
            lvwMasalar.MouseDoubleClick += lvwMasalar_MouseDoubleClick;
            // 
            // iMasalar
            // 
            iMasalar.ColorDepth = ColorDepth.Depth8Bit;
            iMasalar.ImageStream = (ImageListStreamer)resources.GetObject("iMasalar.ImageStream");
            iMasalar.TransparentColor = Color.Transparent;
            iMasalar.Images.SetKeyName(0, "dolu");
            iMasalar.Images.SetKeyName(1, "bos");
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 437);
            Controls.Add(lvwMasalar);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "AnaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kafe Konsol";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiUrunler;
        private ToolStripMenuItem tsmiGecmissiparisler;
        private ListView lvwMasalar;
        private ImageList iMasalar;
    }
}