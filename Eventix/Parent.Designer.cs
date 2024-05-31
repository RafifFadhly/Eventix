namespace Eventix
{
    partial class Parent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parent));
            this.nama = new System.Windows.Forms.Label();
            this.Profil_click = new Guna.UI2.WinForms.Guna2Button();
            this.Cari = new Guna.UI2.WinForms.Guna2TextBox();
            this.navbar = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Dashboard_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Admin_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Penyelenggara_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Pengguna_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Event_btn = new Guna.UI2.WinForms.Guna2Button();
            this.buat_event_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Pembeli_btn = new Guna.UI2.WinForms.Guna2Button();
            this.sidebar = new System.Windows.Forms.Panel();
            this.profil = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tiket_saya = new Guna.UI2.WinForms.Guna2Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navbar.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // nama
            // 
            this.nama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nama.AutoSize = true;
            this.nama.BackColor = System.Drawing.Color.RoyalBlue;
            this.nama.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nama.Location = new System.Drawing.Point(1378, 32);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(52, 18);
            this.nama.TabIndex = 12;
            this.nama.Text = "label1";
            // 
            // Profil_click
            // 
            this.Profil_click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Profil_click.BorderRadius = 10;
            this.Profil_click.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Profil_click.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Profil_click.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Profil_click.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Profil_click.FillColor = System.Drawing.Color.RoyalBlue;
            this.Profil_click.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Profil_click.ForeColor = System.Drawing.Color.White;
            this.Profil_click.Location = new System.Drawing.Point(1363, 7);
            this.Profil_click.Name = "Profil_click";
            this.Profil_click.Size = new System.Drawing.Size(204, 72);
            this.Profil_click.TabIndex = 9;
            this.Profil_click.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // Cari
            // 
            this.Cari.BorderRadius = 10;
            this.Cari.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Cari.DefaultText = "";
            this.Cari.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Cari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Cari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Cari.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Cari.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cari.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cari.ForeColor = System.Drawing.Color.Black;
            this.Cari.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cari.Location = new System.Drawing.Point(285, 20);
            this.Cari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cari.Name = "Cari";
            this.Cari.PasswordChar = '\0';
            this.Cari.PlaceholderText = "";
            this.Cari.SelectedText = "";
            this.Cari.Size = new System.Drawing.Size(591, 48);
            this.Cari.TabIndex = 6;
            this.Cari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cari_KeyDown);
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.Blue;
            this.navbar.Controls.Add(this.label1);
            this.navbar.Controls.Add(this.profil);
            this.navbar.Controls.Add(this.nama);
            this.navbar.Controls.Add(this.Profil_click);
            this.navbar.Controls.Add(this.tiket_saya);
            this.navbar.Controls.Add(this.logo);
            this.navbar.Controls.Add(this.Cari);
            this.navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(1573, 91);
            this.navbar.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Blue;
            this.flowLayoutPanel1.Controls.Add(this.Dashboard_btn);
            this.flowLayoutPanel1.Controls.Add(this.Admin_btn);
            this.flowLayoutPanel1.Controls.Add(this.Penyelenggara_btn);
            this.flowLayoutPanel1.Controls.Add(this.Pengguna_btn);
            this.flowLayoutPanel1.Controls.Add(this.Event_btn);
            this.flowLayoutPanel1.Controls.Add(this.buat_event_btn);
            this.flowLayoutPanel1.Controls.Add(this.Pembeli_btn);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(203, 427);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // Dashboard_btn
            // 
            this.Dashboard_btn.BorderRadius = 10;
            this.Dashboard_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Dashboard_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Dashboard_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Dashboard_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Dashboard_btn.FillColor = System.Drawing.Color.Blue;
            this.Dashboard_btn.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Dashboard_btn.Location = new System.Drawing.Point(3, 3);
            this.Dashboard_btn.Name = "Dashboard_btn";
            this.Dashboard_btn.Size = new System.Drawing.Size(181, 45);
            this.Dashboard_btn.TabIndex = 1;
            this.Dashboard_btn.Text = "🟦 Dashboard";
            this.Dashboard_btn.Click += new System.EventHandler(this.Dashboard_btn_Click);
            // 
            // Admin_btn
            // 
            this.Admin_btn.BorderRadius = 10;
            this.Admin_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Admin_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Admin_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Admin_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Admin_btn.FillColor = System.Drawing.Color.Blue;
            this.Admin_btn.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Admin_btn.Location = new System.Drawing.Point(3, 54);
            this.Admin_btn.Name = "Admin_btn";
            this.Admin_btn.Size = new System.Drawing.Size(181, 45);
            this.Admin_btn.TabIndex = 2;
            this.Admin_btn.Text = "🧑‍💻 Admin";
            this.Admin_btn.Click += new System.EventHandler(this.Admin_btn_Click);
            // 
            // Penyelenggara_btn
            // 
            this.Penyelenggara_btn.BorderRadius = 10;
            this.Penyelenggara_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Penyelenggara_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Penyelenggara_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Penyelenggara_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Penyelenggara_btn.FillColor = System.Drawing.Color.Blue;
            this.Penyelenggara_btn.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Penyelenggara_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Penyelenggara_btn.Location = new System.Drawing.Point(3, 105);
            this.Penyelenggara_btn.Name = "Penyelenggara_btn";
            this.Penyelenggara_btn.Size = new System.Drawing.Size(181, 45);
            this.Penyelenggara_btn.TabIndex = 3;
            this.Penyelenggara_btn.Text = "🧑‍💻 Penyelenggara";
            this.Penyelenggara_btn.Click += new System.EventHandler(this.Penyelenggara_btn_Click);
            // 
            // Pengguna_btn
            // 
            this.Pengguna_btn.BorderRadius = 10;
            this.Pengguna_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Pengguna_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Pengguna_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Pengguna_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Pengguna_btn.FillColor = System.Drawing.Color.Blue;
            this.Pengguna_btn.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pengguna_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pengguna_btn.Location = new System.Drawing.Point(3, 156);
            this.Pengguna_btn.Name = "Pengguna_btn";
            this.Pengguna_btn.Size = new System.Drawing.Size(181, 45);
            this.Pengguna_btn.TabIndex = 4;
            this.Pengguna_btn.Text = "🧑‍💻 Pengguna";
            this.Pengguna_btn.Click += new System.EventHandler(this.Pengguna_btn_Click);
            // 
            // Event_btn
            // 
            this.Event_btn.BorderRadius = 10;
            this.Event_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Event_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Event_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Event_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Event_btn.FillColor = System.Drawing.Color.Blue;
            this.Event_btn.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Event_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Event_btn.Location = new System.Drawing.Point(3, 207);
            this.Event_btn.Name = "Event_btn";
            this.Event_btn.Size = new System.Drawing.Size(181, 45);
            this.Event_btn.TabIndex = 5;
            this.Event_btn.Text = "🎫 Event";
            this.Event_btn.Click += new System.EventHandler(this.Event_btn_Click);
            // 
            // buat_event_btn
            // 
            this.buat_event_btn.BorderRadius = 10;
            this.buat_event_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buat_event_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buat_event_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buat_event_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buat_event_btn.FillColor = System.Drawing.Color.Blue;
            this.buat_event_btn.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buat_event_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buat_event_btn.Location = new System.Drawing.Point(3, 258);
            this.buat_event_btn.Name = "buat_event_btn";
            this.buat_event_btn.Size = new System.Drawing.Size(181, 45);
            this.buat_event_btn.TabIndex = 6;
            this.buat_event_btn.Text = "➕ Buat Event";
            this.buat_event_btn.Click += new System.EventHandler(this.buat_event_btn_Click);
            // 
            // Pembeli_btn
            // 
            this.Pembeli_btn.BorderRadius = 10;
            this.Pembeli_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Pembeli_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Pembeli_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Pembeli_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Pembeli_btn.FillColor = System.Drawing.Color.Blue;
            this.Pembeli_btn.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pembeli_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pembeli_btn.Location = new System.Drawing.Point(3, 309);
            this.Pembeli_btn.Name = "Pembeli_btn";
            this.Pembeli_btn.Size = new System.Drawing.Size(181, 45);
            this.Pembeli_btn.TabIndex = 7;
            this.Pembeli_btn.Text = "🧑‍💻 Pembeli";
            this.Pembeli_btn.Click += new System.EventHandler(this.Pembeli_btn_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Blue;
            this.sidebar.Controls.Add(this.flowLayoutPanel1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 91);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(226, 610);
            this.sidebar.TabIndex = 13;
            // 
            // profil
            // 
            this.profil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profil.BackColor = System.Drawing.Color.RoyalBlue;
            this.profil.BorderRadius = 20;
            this.profil.FillColor = System.Drawing.Color.Black;
            this.profil.ImageRotate = 0F;
            this.profil.InitialImage = null;
            this.profil.Location = new System.Drawing.Point(1510, 16);
            this.profil.Name = "profil";
            this.profil.Size = new System.Drawing.Size(51, 52);
            this.profil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profil.TabIndex = 13;
            this.profil.TabStop = false;
            // 
            // tiket_saya
            // 
            this.tiket_saya.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tiket_saya.BackgroundImage = global::Eventix.Properties.Resources.Frame_39;
            this.tiket_saya.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tiket_saya.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tiket_saya.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tiket_saya.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tiket_saya.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tiket_saya.FillColor = System.Drawing.Color.Transparent;
            this.tiket_saya.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tiket_saya.ForeColor = System.Drawing.Color.White;
            this.tiket_saya.Location = new System.Drawing.Point(903, 16);
            this.tiket_saya.Name = "tiket_saya";
            this.tiket_saya.Size = new System.Drawing.Size(220, 63);
            this.tiket_saya.TabIndex = 7;
            this.tiket_saya.Click += new System.EventHandler(this.tiket_saya_Click);
            // 
            // logo
            // 
            this.logo.Image = global::Eventix.Properties.Resources.Frame_54__1_;
            this.logo.Location = new System.Drawing.Point(68, 32);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(104, 22);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1144, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "📞 082345543456";
            // 
            // Parent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1573, 701);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.navbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Parent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Parent_FormClosing);
            this.Load += new System.EventHandler(this.Parent_Load);
            this.ResizeEnd += new System.EventHandler(this.resize);
            this.Resize += new System.EventHandler(this.resize);
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nama;
        private Guna.UI2.WinForms.Guna2Button Profil_click;
        private Guna.UI2.WinForms.Guna2Button tiket_saya;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel navbar;
        public Guna.UI2.WinForms.Guna2TextBox Cari;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button Dashboard_btn;
        private Guna.UI2.WinForms.Guna2Button Admin_btn;
        private Guna.UI2.WinForms.Guna2Button Penyelenggara_btn;
        private Guna.UI2.WinForms.Guna2Button Pengguna_btn;
        private Guna.UI2.WinForms.Guna2Button Event_btn;
        private System.Windows.Forms.Panel sidebar;
        public Guna.UI2.WinForms.Guna2PictureBox profil;
        private Guna.UI2.WinForms.Guna2Button buat_event_btn;
        private Guna.UI2.WinForms.Guna2Button Pembeli_btn;
        private System.Windows.Forms.Label label1;
    }
}