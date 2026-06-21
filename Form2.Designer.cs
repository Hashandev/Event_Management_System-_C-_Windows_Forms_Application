namespace WinFormsApp1
{
    partial class dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem = new ToolStripMenuItem();
            packagesToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            sToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            sta = new Label();
            pac = new Label();
            boo = new Label();
            cus = new Label();
            labelStaff = new Label();
            labelPackages = new Label();
            labelBookings = new Label();
            labelCustomers = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.ForeColor = Color.Black;
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, customersToolStripMenuItem, bookingToolStripMenuItem, packagesToolStripMenuItem, inventoryToolStripMenuItem, sToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1000, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStripdash";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.BackColor = Color.White;
            dashboardToolStripMenuItem.ForeColor = Color.Black;
            dashboardToolStripMenuItem.Image = (Image)resources.GetObject("dashboardToolStripMenuItem.Image");
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(74, 23);
            dashboardToolStripMenuItem.Text = "Home";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.BackColor = Color.White;
            customersToolStripMenuItem.ForeColor = Color.Black;
            customersToolStripMenuItem.Image = (Image)resources.GetObject("customersToolStripMenuItem.Image");
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(103, 23);
            customersToolStripMenuItem.Text = "Customers";
            customersToolStripMenuItem.Click += customersToolStripMenuItem_Click;
            // 
            // bookingToolStripMenuItem
            // 
            bookingToolStripMenuItem.BackColor = Color.White;
            bookingToolStripMenuItem.ForeColor = Color.Black;
            bookingToolStripMenuItem.Image = (Image)resources.GetObject("bookingToolStripMenuItem.Image");
            bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            bookingToolStripMenuItem.Size = new Size(87, 23);
            bookingToolStripMenuItem.Text = "Booking";
            bookingToolStripMenuItem.Click += bookingToolStripMenuItem_Click;
            // 
            // packagesToolStripMenuItem
            // 
            packagesToolStripMenuItem.BackColor = Color.White;
            packagesToolStripMenuItem.ForeColor = Color.Black;
            packagesToolStripMenuItem.Image = (Image)resources.GetObject("packagesToolStripMenuItem.Image");
            packagesToolStripMenuItem.Name = "packagesToolStripMenuItem";
            packagesToolStripMenuItem.Size = new Size(93, 23);
            packagesToolStripMenuItem.Text = "Packages";
            packagesToolStripMenuItem.Click += packagesToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.BackColor = Color.White;
            inventoryToolStripMenuItem.ForeColor = Color.Black;
            inventoryToolStripMenuItem.Image = (Image)resources.GetObject("inventoryToolStripMenuItem.Image");
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(96, 23);
            inventoryToolStripMenuItem.Text = "Inventory";
            inventoryToolStripMenuItem.Click += inventoryToolStripMenuItem_Click;
            // 
            // sToolStripMenuItem
            // 
            sToolStripMenuItem.BackColor = Color.White;
            sToolStripMenuItem.ForeColor = Color.Black;
            sToolStripMenuItem.Image = (Image)resources.GetObject("sToolStripMenuItem.Image");
            sToolStripMenuItem.Name = "sToolStripMenuItem";
            sToolStripMenuItem.Size = new Size(64, 23);
            sToolStripMenuItem.Text = "Staff";
            sToolStripMenuItem.Click += sToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.BackColor = Color.White;
            reportsToolStripMenuItem.ForeColor = Color.Black;
            reportsToolStripMenuItem.Image = (Image)resources.GetObject("reportsToolStripMenuItem.Image");
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(84, 23);
            reportsToolStripMenuItem.Text = "Reports";
            reportsToolStripMenuItem.Click += reportsToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(sta);
            panel1.Controls.Add(pac);
            panel1.Controls.Add(boo);
            panel1.Controls.Add(cus);
            panel1.Controls.Add(labelStaff);
            panel1.Controls.Add(labelPackages);
            panel1.Controls.Add(labelBookings);
            panel1.Controls.Add(labelCustomers);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 29);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30);
            panel1.Size = new Size(1000, 551);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // sta
            // 
            sta.AutoSize = true;
            sta.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            sta.ForeColor = Color.FromArgb(231, 76, 60);
            sta.Location = new Point(755, 100);
            sta.Name = "sta";
            sta.Size = new Size(50, 59);
            sta.TabIndex = 7;
            sta.Text = "0";
            // 
            // pac
            // 
            pac.AutoSize = true;
            pac.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            pac.ForeColor = Color.FromArgb(155, 89, 182);
            pac.Location = new Point(525, 100);
            pac.Name = "pac";
            pac.Size = new Size(50, 59);
            pac.TabIndex = 6;
            pac.Text = "0";
            // 
            // boo
            // 
            boo.AutoSize = true;
            boo.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            boo.ForeColor = Color.FromArgb(46, 204, 113);
            boo.Location = new Point(295, 100);
            boo.Name = "boo";
            boo.Size = new Size(50, 59);
            boo.TabIndex = 5;
            boo.Text = "0";
            // 
            // cus
            // 
            cus.AutoSize = true;
            cus.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            cus.ForeColor = Color.FromArgb(52, 152, 219);
            cus.Location = new Point(65, 100);
            cus.Name = "cus";
            cus.Size = new Size(50, 59);
            cus.TabIndex = 4;
            cus.Text = "0";
            cus.Click += label1_Click;
            // 
            // labelStaff
            // 
            labelStaff.AutoSize = true;
            labelStaff.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelStaff.ForeColor = Color.FromArgb(44, 62, 80);
            labelStaff.Location = new Point(760, 45);
            labelStaff.Name = "labelStaff";
            labelStaff.Size = new Size(46, 21);
            labelStaff.TabIndex = 3;
            labelStaff.Text = "Staff";
            // 
            // labelPackages
            // 
            labelPackages.AutoSize = true;
            labelPackages.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelPackages.ForeColor = Color.FromArgb(44, 62, 80);
            labelPackages.Location = new Point(515, 45);
            labelPackages.Name = "labelPackages";
            labelPackages.Size = new Size(81, 21);
            labelPackages.TabIndex = 2;
            labelPackages.Text = "Packages";
            // 
            // labelBookings
            // 
            labelBookings.AutoSize = true;
            labelBookings.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelBookings.ForeColor = Color.FromArgb(44, 62, 80);
            labelBookings.Location = new Point(285, 45);
            labelBookings.Name = "labelBookings";
            labelBookings.Size = new Size(81, 21);
            labelBookings.TabIndex = 1;
            labelBookings.Text = "Bookings";
            // 
            // labelCustomers
            // 
            labelCustomers.AutoSize = true;
            labelCustomers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelCustomers.ForeColor = Color.FromArgb(44, 62, 80);
            labelCustomers.Location = new Point(40, 45);
            labelCustomers.Name = "labelCustomers";
            labelCustomers.Size = new Size(90, 21);
            labelCustomers.TabIndex = 0;
            labelCustomers.Text = "Customers";
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1000, 580);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Event Decoration Management";
            WindowState = FormWindowState.Maximized;
            Load += dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem bookingToolStripMenuItem;
        private ToolStripMenuItem packagesToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem sToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private Panel panel1;

        // DATA LABELS - These show the counts from database
        private Label cus;   // Customers Count
        private Label boo;   // Bookings Count
        private Label pac;   // Packages Count
        private Label sta;   // Staff Count

        // TITLE LABELS - These show the titles
        private Label labelCustomers;
        private Label labelBookings;
        private Label labelPackages;
        private Label labelStaff;
    }
}