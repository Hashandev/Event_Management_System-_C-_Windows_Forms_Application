namespace WinFormsApp1
{
    partial class reports
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
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem = new ToolStripMenuItem();
            packagesToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            sToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            customer = new Label();
            download = new Button();
            label1 = new Label();
            downloadBooking = new Button();
            label2 = new Label();
            downloadPackages = new Button();
            label3 = new Label();
            downloadInventory = new Button();
            label4 = new Label();
            downloadStaff = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();

            // menuStrip1
            menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            menuStrip1.Items.AddRange(new ToolStripItem[] {
                dashboardToolStripMenuItem,
                customersToolStripMenuItem,
                bookingToolStripMenuItem,
                packagesToolStripMenuItem,
                inventoryToolStripMenuItem,
                sToolStripMenuItem,
                reportsToolStripMenuItem
            });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 1;

            // dashboardToolStripMenuItem
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            dashboardToolStripMenuItem.Text = "Home";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;

            // customersToolStripMenuItem
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            customersToolStripMenuItem.Text = "Customers";
            customersToolStripMenuItem.Click += customersToolStripMenuItem_Click;

            // bookingToolStripMenuItem
            bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            bookingToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            bookingToolStripMenuItem.Text = "Booking";
            bookingToolStripMenuItem.Click += bookingToolStripMenuItem_Click;

            // packagesToolStripMenuItem
            packagesToolStripMenuItem.Name = "packagesToolStripMenuItem";
            packagesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            packagesToolStripMenuItem.Text = "Packages";
            packagesToolStripMenuItem.Click += packagesToolStripMenuItem_Click;

            // inventoryToolStripMenuItem
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            inventoryToolStripMenuItem.Text = "Inventory";
            inventoryToolStripMenuItem.Click += inventoryToolStripMenuItem_Click;

            // sToolStripMenuItem
            sToolStripMenuItem.Name = "sToolStripMenuItem";
            sToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            sToolStripMenuItem.Text = "Staff";
            sToolStripMenuItem.Click += sToolStripMenuItem_Click;

            // reportsToolStripMenuItem
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            reportsToolStripMenuItem.Text = "Reports";

            // Customer
            customer.AutoSize = true;
            customer.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            customer.ForeColor = System.Drawing.Color.White;
            customer.Location = new System.Drawing.Point(12, 40);
            customer.Name = "customer";
            customer.Size = new System.Drawing.Size(102, 30);
            customer.TabIndex = 2;
            customer.Text = "Customer";

            download.Location = new System.Drawing.Point(388, 48);
            download.Name = "download";
            download.Size = new System.Drawing.Size(100, 35);
            download.TabIndex = 3;
            download.Text = "Download";
            download.UseVisualStyleBackColor = true;
            download.Click += download_Click;

            // Booking
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 100);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(88, 30);
            label1.TabIndex = 4;
            label1.Text = "Booking";

            downloadBooking.Location = new System.Drawing.Point(388, 108);
            downloadBooking.Name = "downloadBooking";
            downloadBooking.Size = new System.Drawing.Size(100, 35);
            downloadBooking.TabIndex = 5;
            downloadBooking.Text = "Download";
            downloadBooking.UseVisualStyleBackColor = true;
            downloadBooking.Click += downloadBooking_Click;

            // Packages
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(12, 160);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 30);
            label2.TabIndex = 6;
            label2.Text = "Packages";

            downloadPackages.Location = new System.Drawing.Point(388, 168);
            downloadPackages.Name = "downloadPackages";
            downloadPackages.Size = new System.Drawing.Size(100, 35);
            downloadPackages.TabIndex = 7;
            downloadPackages.Text = "Download";
            downloadPackages.UseVisualStyleBackColor = true;
            downloadPackages.Click += downloadPackages_Click;

            // Inventory
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(12, 220);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(100, 30);
            label3.TabIndex = 8;
            label3.Text = "Inventory";

            downloadInventory.Location = new System.Drawing.Point(388, 228);
            downloadInventory.Name = "downloadInventory";
            downloadInventory.Size = new System.Drawing.Size(100, 35);
            downloadInventory.TabIndex = 9;
            downloadInventory.Text = "Download";
            downloadInventory.UseVisualStyleBackColor = true;
            downloadInventory.Click += downloadInventory_Click;

            // Staff
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(12, 280);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 30);
            label4.TabIndex = 10;
            label4.Text = "Staff";

            downloadStaff.Location = new System.Drawing.Point(388, 288);
            downloadStaff.Name = "downloadStaff";
            downloadStaff.Size = new System.Drawing.Size(100, 35);
            downloadStaff.TabIndex = 11;
            downloadStaff.Text = "Download";
            downloadStaff.UseVisualStyleBackColor = true;
            downloadStaff.Click += downloadStaff_Click;

            // reports
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(downloadStaff);
            this.Controls.Add(label4);
            this.Controls.Add(downloadInventory);
            this.Controls.Add(label3);
            this.Controls.Add(downloadPackages);
            this.Controls.Add(label2);
            this.Controls.Add(downloadBooking);
            this.Controls.Add(label1);
            this.Controls.Add(download);
            this.Controls.Add(customer);
            this.Controls.Add(menuStrip1);
            this.Name = "reports";
            this.Text = "reports";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
        private Label customer;
        private Button download;
        private Label label1;
        private Button downloadBooking;
        private Label label2;
        private Button downloadPackages;
        private Label label3;
        private Button downloadInventory;
        private Label label4;
        private Button downloadStaff;
    }
}