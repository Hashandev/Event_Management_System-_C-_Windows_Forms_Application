namespace WinFormsApp1
{
    partial class Package  // Changed from 'package' to 'Package' to match code file
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Package));
            mainTableLayout = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem = new ToolStripMenuItem();
            packagesToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            sToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            packagemanagement = new Label();
            contentPanel = new TableLayoutPanel();
            leftPanel = new TableLayoutPanel();
            searchPanel = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            txtSearch = new TextBox();
            searchPackage = new Button();
            dataGridView2 = new DataGridView();
            totalPanel = new TableLayoutPanel();
            label3 = new Label();
            txtTotalPackage = new TextBox();
            rightPanel = new TableLayoutPanel();
            addpackage = new Label();
            lblPackageName = new Label();
            txtPackageName = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblPackageItems = new Label();
            txtPackageItems = new TextBox();
            lblPackageID = new Label();
            txtPackageID = new TextBox();
            lblDescription = new Label();
            txtDescription = new RichTextBox();
            buttonPanel = new FlowLayoutPanel();
            add = new Button();
            update = new Button();
            delete = new Button();
            clear = new Button();
            mainTableLayout.SuspendLayout();
            menuStrip1.SuspendLayout();
            contentPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            totalPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            buttonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayout
            // 
            mainTableLayout.BackColor = Color.MidnightBlue;
            mainTableLayout.ColumnCount = 1;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayout.Controls.Add(menuStrip1, 0, 0);
            mainTableLayout.Controls.Add(packagemanagement, 0, 1);
            mainTableLayout.Controls.Add(contentPanel, 0, 2);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.RowCount = 3;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayout.Size = new Size(1200, 700);
            mainTableLayout.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 9F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, customersToolStripMenuItem, bookingToolStripMenuItem, packagesToolStripMenuItem, inventoryToolStripMenuItem, sToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1200, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Image = (Image)resources.GetObject("dashboardToolStripMenuItem.Image");
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(68, 20);
            dashboardToolStripMenuItem.Text = "Home";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.Image = (Image)resources.GetObject("customersToolStripMenuItem.Image");
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(92, 20);
            customersToolStripMenuItem.Text = "Customers";
            customersToolStripMenuItem.Click += customersToolStripMenuItem_Click;
            // 
            // bookingToolStripMenuItem
            // 
            bookingToolStripMenuItem.Image = (Image)resources.GetObject("bookingToolStripMenuItem.Image");
            bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            bookingToolStripMenuItem.Size = new Size(79, 20);
            bookingToolStripMenuItem.Text = "Booking";
            bookingToolStripMenuItem.Click += bookingToolStripMenuItem_Click;
            // 
            // packagesToolStripMenuItem
            // 
            packagesToolStripMenuItem.Image = (Image)resources.GetObject("packagesToolStripMenuItem.Image");
            packagesToolStripMenuItem.Name = "packagesToolStripMenuItem";
            packagesToolStripMenuItem.Size = new Size(84, 20);
            packagesToolStripMenuItem.Text = "Packages";
            packagesToolStripMenuItem.Click += packagesToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Image = (Image)resources.GetObject("inventoryToolStripMenuItem.Image");
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(85, 20);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // sToolStripMenuItem
            // 
            sToolStripMenuItem.Image = (Image)resources.GetObject("sToolStripMenuItem.Image");
            sToolStripMenuItem.Name = "sToolStripMenuItem";
            sToolStripMenuItem.Size = new Size(59, 20);
            sToolStripMenuItem.Text = "Staff";
            sToolStripMenuItem.Click += sToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Image = (Image)resources.GetObject("reportsToolStripMenuItem.Image");
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(75, 20);
            reportsToolStripMenuItem.Text = "Reports";
            reportsToolStripMenuItem.Click += reportsToolStripMenuItem_Click;
            // 
            // packagemanagement
            // 
            packagemanagement.AutoSize = true;
            packagemanagement.Dock = DockStyle.Fill;
            packagemanagement.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            packagemanagement.ForeColor = SystemColors.ControlLightLight;
            packagemanagement.Location = new Point(3, 30);
            packagemanagement.Name = "packagemanagement";
            packagemanagement.Size = new Size(1194, 50);
            packagemanagement.TabIndex = 1;
            packagemanagement.Text = "Package Management";
            packagemanagement.TextAlign = ContentAlignment.MiddleCenter;
            packagemanagement.Click += packagemanagement_Click;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.MidnightBlue;
            contentPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            contentPanel.ColumnCount = 2;
            contentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            contentPanel.Controls.Add(leftPanel, 0, 0);
            contentPanel.Controls.Add(rightPanel, 1, 0);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(3, 83);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(8);
            contentPanel.RowCount = 1;
            contentPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contentPanel.Size = new Size(1194, 614);
            contentPanel.TabIndex = 2;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.Navy;
            leftPanel.ColumnCount = 1;
            leftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftPanel.Controls.Add(searchPanel, 0, 0);
            leftPanel.Controls.Add(dataGridView2, 0, 1);
            leftPanel.Controls.Add(totalPanel, 0, 2);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(12, 12);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(8);
            leftPanel.RowCount = 3;
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            leftPanel.Size = new Size(581, 590);
            leftPanel.TabIndex = 0;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.Navy;
            searchPanel.ColumnCount = 3;
            searchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            searchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            searchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            searchPanel.Controls.Add(pictureBox1, 0, 0);
            searchPanel.Controls.Add(txtSearch, 1, 0);
            searchPanel.Controls.Add(searchPackage, 2, 0);
            searchPanel.Dock = DockStyle.Fill;
            searchPanel.Location = new Point(11, 11);
            searchPanel.Name = "searchPanel";
            searchPanel.RowCount = 1;
            searchPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            searchPanel.Size = new Size(559, 39);
            searchPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(29, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(38, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(438, 25);
            txtSearch.TabIndex = 1;
            // 
            // searchPackage
            // 
            searchPackage.Dock = DockStyle.Fill;
            searchPackage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            searchPackage.Location = new Point(482, 3);
            searchPackage.Name = "searchPackage";
            searchPackage.Size = new Size(74, 33);
            searchPackage.TabIndex = 2;
            searchPackage.Text = "🔍 Search";
            searchPackage.UseVisualStyleBackColor = true;
            searchPackage.Click += searchPackage_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(11, 56);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(559, 483);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // totalPanel
            // 
            totalPanel.BackColor = Color.Navy;
            totalPanel.ColumnCount = 2;
            totalPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            totalPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            totalPanel.Controls.Add(label3, 0, 0);
            totalPanel.Controls.Add(txtTotalPackage, 1, 0);
            totalPanel.Dock = DockStyle.Fill;
            totalPanel.Location = new Point(11, 545);
            totalPanel.Name = "totalPanel";
            totalPanel.RowCount = 1;
            totalPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            totalPanel.Size = new Size(559, 34);
            totalPanel.TabIndex = 4;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(144, 34);
            label3.TabIndex = 0;
            label3.Text = "Total Packages :";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTotalPackage
            // 
            txtTotalPackage.BackColor = Color.LightGray;
            txtTotalPackage.Dock = DockStyle.Fill;
            txtTotalPackage.Enabled = false;
            txtTotalPackage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtTotalPackage.ForeColor = Color.Black;
            txtTotalPackage.Location = new Point(153, 3);
            txtTotalPackage.Name = "txtTotalPackage";
            txtTotalPackage.Size = new Size(403, 25);
            txtTotalPackage.TabIndex = 1;
            txtTotalPackage.Text = "0";
            txtTotalPackage.TextAlign = HorizontalAlignment.Center;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.Navy;
            rightPanel.ColumnCount = 2;
            rightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            rightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            rightPanel.Controls.Add(addpackage, 0, 0);
            rightPanel.Controls.Add(lblPackageName, 0, 1);
            rightPanel.Controls.Add(txtPackageName, 1, 1);
            rightPanel.Controls.Add(lblPrice, 0, 2);
            rightPanel.Controls.Add(txtPrice, 1, 2);
            rightPanel.Controls.Add(lblPackageItems, 0, 3);
            rightPanel.Controls.Add(txtPackageItems, 1, 3);
            rightPanel.Controls.Add(lblPackageID, 0, 4);
            rightPanel.Controls.Add(txtPackageID, 1, 4);
            rightPanel.Controls.Add(lblDescription, 0, 5);
            rightPanel.Controls.Add(txtDescription, 1, 5);
            rightPanel.Controls.Add(buttonPanel, 0, 6);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(600, 12);
            rightPanel.Name = "rightPanel";
            rightPanel.Padding = new Padding(10);
            rightPanel.RowCount = 7;
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            rightPanel.Size = new Size(582, 590);
            rightPanel.TabIndex = 1;
            // 
            // addpackage
            // 
            rightPanel.SetColumnSpan(addpackage, 2);
            addpackage.Dock = DockStyle.Fill;
            addpackage.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            addpackage.ForeColor = SystemColors.ControlLightLight;
            addpackage.Location = new Point(13, 10);
            addpackage.Name = "addpackage";
            addpackage.Size = new Size(556, 40);
            addpackage.TabIndex = 0;
            addpackage.Text = "📦 Add Package";
            addpackage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPackageName
            // 
            lblPackageName.Dock = DockStyle.Fill;
            lblPackageName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPackageName.ForeColor = SystemColors.ControlLightLight;
            lblPackageName.Location = new Point(13, 50);
            lblPackageName.Name = "lblPackageName";
            lblPackageName.Size = new Size(190, 40);
            lblPackageName.TabIndex = 1;
            lblPackageName.Text = "Package Name :";
            lblPackageName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPackageName
            // 
            txtPackageName.Dock = DockStyle.Fill;
            txtPackageName.Font = new Font("Segoe UI", 10F);
            txtPackageName.Location = new Point(209, 53);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(360, 25);
            txtPackageName.TabIndex = 2;
            // 
            // lblPrice
            // 
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPrice.ForeColor = SystemColors.ControlLightLight;
            lblPrice.Location = new Point(13, 90);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(190, 40);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price (Rs) :";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Font = new Font("Segoe UI", 10F);
            txtPrice.Location = new Point(209, 93);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(360, 25);
            txtPrice.TabIndex = 4;
            // 
            // lblPackageItems
            // 
            lblPackageItems.Dock = DockStyle.Fill;
            lblPackageItems.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPackageItems.ForeColor = SystemColors.ControlLightLight;
            lblPackageItems.Location = new Point(13, 130);
            lblPackageItems.Name = "lblPackageItems";
            lblPackageItems.Size = new Size(190, 40);
            lblPackageItems.TabIndex = 5;
            lblPackageItems.Text = "Package Items :";
            lblPackageItems.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPackageItems
            // 
            txtPackageItems.Dock = DockStyle.Fill;
            txtPackageItems.Font = new Font("Segoe UI", 10F);
            txtPackageItems.Location = new Point(209, 133);
            txtPackageItems.Name = "txtPackageItems";
            txtPackageItems.Size = new Size(360, 25);
            txtPackageItems.TabIndex = 6;
            // 
            // lblPackageID
            // 
            lblPackageID.Dock = DockStyle.Fill;
            lblPackageID.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblPackageID.ForeColor = SystemColors.ControlLightLight;
            lblPackageID.Location = new Point(13, 170);
            lblPackageID.Name = "lblPackageID";
            lblPackageID.Size = new Size(190, 40);
            lblPackageID.TabIndex = 7;
            lblPackageID.Text = "Package ID :";
            lblPackageID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPackageID
            // 
            txtPackageID.Dock = DockStyle.Fill;
            txtPackageID.Font = new Font("Segoe UI", 10F);
            txtPackageID.Location = new Point(209, 173);
            txtPackageID.Name = "txtPackageID";
            txtPackageID.Size = new Size(360, 25);
            txtPackageID.TabIndex = 8;
            // 
            // lblDescription
            // 
            lblDescription.Dock = DockStyle.Fill;
            lblDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            lblDescription.ForeColor = SystemColors.ControlLightLight;
            lblDescription.Location = new Point(13, 210);
            lblDescription.Name = "lblDescription";
            lblDescription.Padding = new Padding(0, 8, 0, 0);
            lblDescription.Size = new Size(190, 320);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description :";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(209, 213);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(360, 314);
            txtDescription.TabIndex = 10;
            txtDescription.Text = "";
            // 
            // buttonPanel
            // 
            rightPanel.SetColumnSpan(buttonPanel, 2);
            buttonPanel.Controls.Add(add);
            buttonPanel.Controls.Add(update);
            buttonPanel.Controls.Add(delete);
            buttonPanel.Controls.Add(clear);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(13, 533);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(5);
            buttonPanel.Size = new Size(556, 44);
            buttonPanel.TabIndex = 11;
            // 
            // add
            // 
            add.BackColor = Color.ForestGreen;
            add.FlatStyle = FlatStyle.Flat;
            add.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            add.ForeColor = Color.White;
            add.Location = new Point(8, 8);
            add.Name = "add";
            add.Size = new Size(100, 35);
            add.TabIndex = 0;
            add.Text = "➕ ADD";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // update
            // 
            update.BackColor = Color.SteelBlue;
            update.FlatStyle = FlatStyle.Flat;
            update.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            update.ForeColor = Color.White;
            update.Location = new Point(114, 8);
            update.Name = "update";
            update.Size = new Size(100, 35);
            update.TabIndex = 1;
            update.Text = "✏️ UPDATE";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Crimson;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            delete.ForeColor = Color.White;
            delete.Location = new Point(220, 8);
            delete.Name = "delete";
            delete.Size = new Size(100, 35);
            delete.TabIndex = 2;
            delete.Text = "🗑️ DELETE";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.SlateGray;
            clear.FlatStyle = FlatStyle.Flat;
            clear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            clear.ForeColor = Color.White;
            clear.Location = new Point(326, 8);
            clear.Name = "clear";
            clear.Size = new Size(100, 35);
            clear.TabIndex = 3;
            clear.Text = "🔄 CLEAR";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // Package
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1200, 700);
            Controls.Add(mainTableLayout);
            Name = "Package";
            Text = "Package Management";
            WindowState = FormWindowState.Maximized;
            Load += Package_Load;
            mainTableLayout.ResumeLayout(false);
            mainTableLayout.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contentPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            totalPanel.ResumeLayout(false);
            totalPanel.PerformLayout();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }



        private TableLayoutPanel mainTableLayout;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem bookingToolStripMenuItem;
        private ToolStripMenuItem packagesToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem sToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private Label packagemanagement;
        private TableLayoutPanel contentPanel;
        private TableLayoutPanel leftPanel;
        private TableLayoutPanel searchPanel;
        private PictureBox pictureBox1;
        private TextBox txtSearch;
        private Button searchPackage;
        private DataGridView dataGridView2;
        private TableLayoutPanel totalPanel;
        private Label label3;
        private TextBox txtTotalPackage;
        private TableLayoutPanel rightPanel;
        private Label addpackage;
        private Label lblPackageName;
        private TextBox txtPackageName;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblPackageItems;
        private TextBox txtPackageItems;
        private Label lblPackageID;
        private TextBox txtPackageID;
        private Label lblDescription;
        private RichTextBox txtDescription;
        private FlowLayoutPanel buttonPanel;
        private Button add;
        private Button update;
        private Button delete;
        private Button clear;
    }
}