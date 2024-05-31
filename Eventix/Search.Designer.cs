namespace Eventix
{
    partial class Search
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
            this.Navbar = new System.Windows.Forms.Panel();
            this.SideBar = new System.Windows.Forms.Panel();
            this.Cari = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TalkShow = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Pemran_Seni = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Seminar = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Pekan_Olahraga = new Guna.UI2.WinForms.Guna2CheckBox();
            this.konser_musik = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lokasi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SideBar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Navbar
            // 
            this.Navbar.AutoSize = true;
            this.Navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Navbar.Location = new System.Drawing.Point(0, 0);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(1371, 0);
            this.Navbar.TabIndex = 5;
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SideBar.Controls.Add(this.Cari);
            this.SideBar.Controls.Add(this.panel4);
            this.SideBar.Controls.Add(this.panel3);
            this.SideBar.Controls.Add(this.pictureBox1);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(279, 790);
            this.SideBar.TabIndex = 6;
            // 
            // Cari
            // 
            this.Cari.BackColor = System.Drawing.Color.Transparent;
            this.Cari.BorderColor = System.Drawing.Color.Transparent;
            this.Cari.BorderRadius = 10;
            this.Cari.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Cari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Cari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Cari.FillColor = System.Drawing.SystemColors.ButtonFace;
            this.Cari.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cari.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Cari.Location = new System.Drawing.Point(207, 20);
            this.Cari.Name = "Cari";
            this.Cari.Size = new System.Drawing.Size(39, 36);
            this.Cari.TabIndex = 10;
            this.Cari.Text = "🔍";
            this.Cari.Click += new System.EventHandler(this.Cari_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TalkShow);
            this.panel4.Controls.Add(this.Pemran_Seni);
            this.panel4.Controls.Add(this.Seminar);
            this.panel4.Controls.Add(this.Pekan_Olahraga);
            this.panel4.Controls.Add(this.konser_musik);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(28, 174);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(193, 233);
            this.panel4.TabIndex = 5;
            // 
            // TalkShow
            // 
            this.TalkShow.AutoSize = true;
            this.TalkShow.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TalkShow.CheckedState.BorderRadius = 0;
            this.TalkShow.CheckedState.BorderThickness = 0;
            this.TalkShow.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TalkShow.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TalkShow.Location = new System.Drawing.Point(26, 196);
            this.TalkShow.Name = "TalkShow";
            this.TalkShow.Size = new System.Drawing.Size(104, 26);
            this.TalkShow.TabIndex = 6;
            this.TalkShow.Text = "Talkshow";
            this.TalkShow.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.TalkShow.UncheckedState.BorderRadius = 0;
            this.TalkShow.UncheckedState.BorderThickness = 0;
            this.TalkShow.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Pemran_Seni
            // 
            this.Pemran_Seni.AutoSize = true;
            this.Pemran_Seni.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pemran_Seni.CheckedState.BorderRadius = 0;
            this.Pemran_Seni.CheckedState.BorderThickness = 0;
            this.Pemran_Seni.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pemran_Seni.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pemran_Seni.Location = new System.Drawing.Point(25, 153);
            this.Pemran_Seni.Name = "Pemran_Seni";
            this.Pemran_Seni.Size = new System.Drawing.Size(140, 26);
            this.Pemran_Seni.TabIndex = 5;
            this.Pemran_Seni.Text = "Pameran Seni";
            this.Pemran_Seni.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Pemran_Seni.UncheckedState.BorderRadius = 0;
            this.Pemran_Seni.UncheckedState.BorderThickness = 0;
            this.Pemran_Seni.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Seminar
            // 
            this.Seminar.AutoSize = true;
            this.Seminar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Seminar.CheckedState.BorderRadius = 0;
            this.Seminar.CheckedState.BorderThickness = 0;
            this.Seminar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Seminar.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seminar.Location = new System.Drawing.Point(25, 117);
            this.Seminar.Name = "Seminar";
            this.Seminar.Size = new System.Drawing.Size(96, 26);
            this.Seminar.TabIndex = 4;
            this.Seminar.Text = "Seminar";
            this.Seminar.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Seminar.UncheckedState.BorderRadius = 0;
            this.Seminar.UncheckedState.BorderThickness = 0;
            this.Seminar.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Pekan_Olahraga
            // 
            this.Pekan_Olahraga.AutoSize = true;
            this.Pekan_Olahraga.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pekan_Olahraga.CheckedState.BorderRadius = 0;
            this.Pekan_Olahraga.CheckedState.BorderThickness = 0;
            this.Pekan_Olahraga.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pekan_Olahraga.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pekan_Olahraga.Location = new System.Drawing.Point(25, 74);
            this.Pekan_Olahraga.Name = "Pekan_Olahraga";
            this.Pekan_Olahraga.Size = new System.Drawing.Size(155, 26);
            this.Pekan_Olahraga.TabIndex = 3;
            this.Pekan_Olahraga.Text = "Pekan Olahraga";
            this.Pekan_Olahraga.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Pekan_Olahraga.UncheckedState.BorderRadius = 0;
            this.Pekan_Olahraga.UncheckedState.BorderThickness = 0;
            this.Pekan_Olahraga.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // konser_musik
            // 
            this.konser_musik.AutoSize = true;
            this.konser_musik.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.konser_musik.CheckedState.BorderRadius = 0;
            this.konser_musik.CheckedState.BorderThickness = 0;
            this.konser_musik.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.konser_musik.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konser_musik.Location = new System.Drawing.Point(25, 35);
            this.konser_musik.Name = "konser_musik";
            this.konser_musik.Size = new System.Drawing.Size(137, 26);
            this.konser_musik.TabIndex = 2;
            this.konser_musik.Text = "Konser Musik";
            this.konser_musik.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.konser_musik.UncheckedState.BorderRadius = 0;
            this.konser_musik.UncheckedState.BorderThickness = 0;
            this.konser_musik.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lokasi);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(28, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(193, 70);
            this.panel3.TabIndex = 4;
            // 
            // lokasi
            // 
            this.lokasi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lokasi.BorderColor = System.Drawing.Color.Black;
            this.lokasi.BorderRadius = 10;
            this.lokasi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lokasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lokasi.FillColor = System.Drawing.Color.Gainsboro;
            this.lokasi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lokasi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lokasi.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lokasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.lokasi.ItemHeight = 30;
            this.lokasi.Items.AddRange(new object[] {
            "Aceh",
            "Sumatera Utara",
            "Sumatera Barat",
            "Riau",
            "Kepulauan Riau",
            "Jambi",
            "Sumatera Selatan",
            "Kepulauan Bangka Belitung",
            "Bengkulu",
            "Lampung",
            "DKI Jakarta",
            "Jawa Barat",
            "Banten",
            "Jawa Tengah",
            "DI Yogyakarta",
            "Jawa Timur",
            "Bali",
            "Nusa Tenggara Barat",
            "Nusa Tenggara Timur",
            "Kalimantan Barat",
            "-",
            "Kalimantan Tengah",
            "Kalimantan Selatan",
            "Kalimantan Timur",
            "Kalimantan Utara",
            "Sulawesi Utara",
            "Gorontalo",
            "Sulawesi Tengah",
            "Sulawesi Selatan",
            "Sulawesi Barat",
            "Sulawesi Tenggara",
            "Maluku",
            "Maluku Utara",
            "Papua",
            "Papua Barat"});
            this.lokasi.Location = new System.Drawing.Point(7, 24);
            this.lokasi.Name = "lokasi";
            this.lokasi.Size = new System.Drawing.Size(183, 36);
            this.lokasi.TabIndex = 1;
            this.lokasi.SelectedIndexChanged += new System.EventHandler(this.lokasi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lokasi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Eventix.Properties.Resources.Frame_54;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 790);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(279, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1092, 790);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.SideBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 790);
            this.panel1.TabIndex = 7;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 790);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Navbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_Load);
            this.SideBar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel Navbar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CheckBox Pekan_Olahraga;
        private Guna.UI2.WinForms.Guna2CheckBox konser_musik;
        private Guna.UI2.WinForms.Guna2ComboBox lokasi;
        private Guna.UI2.WinForms.Guna2CheckBox TalkShow;
        private Guna.UI2.WinForms.Guna2CheckBox Pemran_Seni;
        private Guna.UI2.WinForms.Guna2CheckBox Seminar;
        private Guna.UI2.WinForms.Guna2Button Cari;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

