namespace WinFormsApp1
{
    partial class Booking
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            mainTableLayout = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem = new ToolStripMenuItem();
            packagesToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            sToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            sfaffmanagement = new Label();
            contentPanel = new TableLayoutPanel();
            leftPanel = new TableLayoutPanel();
            searchPanel = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            txtSearch = new TextBox();
            searchcustomer = new Button();
            dataGridView1 = new DataGridView();
            rightPanel = new TableLayoutPanel();
            adduser = new Label();
            lblBookingID = new Label();
            txtBookingID = new TextBox();
            lblCustomerID = new Label();
            txtCustomerID = new TextBox();
            lblPackage = new Label();
            cmbPackageID = new ComboBox();
            lblEventDate = new Label();
            dtpEventDate = new DateTimePicker();
            lblEventTime = new Label();
            dtpEventTime = new DateTimePicker();
            lblMobile = new Label();
            txtMobileNumber = new TextBox();
            lblTotal = new Label();
            txtTotalAmount = new TextBox();
            lblAdvance = new Label();
            txtAdvance = new TextBox();
            lblBalance = new Label();
            txtBalance = new TextBox();
            lblPaymentStatus = new Label();
            cmbPaymentStatus = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            mainTableLayout.Controls.Add(sfaffmanagement, 0, 1);
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
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(52, 20);
            dashboardToolStripMenuItem.Text = "Home";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(76, 20);
            customersToolStripMenuItem.Text = "Customers";
            customersToolStripMenuItem.Click += customersToolStripMenuItem_Click;
            // 
            // bookingToolStripMenuItem
            // 
            bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            bookingToolStripMenuItem.Size = new Size(63, 20);
            bookingToolStripMenuItem.Text = "Booking";
            bookingToolStripMenuItem.Click += bookingToolStripMenuItem_Click;
            // 
            // packagesToolStripMenuItem
            // 
            packagesToolStripMenuItem.Name = "packagesToolStripMenuItem";
            packagesToolStripMenuItem.Size = new Size(68, 20);
            packagesToolStripMenuItem.Text = "Packages";
            packagesToolStripMenuItem.Click += packagesToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(69, 20);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // sToolStripMenuItem
            // 
            sToolStripMenuItem.Name = "sToolStripMenuItem";
            sToolStripMenuItem.Size = new Size(43, 20);
            sToolStripMenuItem.Text = "Staff";
            sToolStripMenuItem.Click += sToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(59, 20);
            reportsToolStripMenuItem.Text = "Reports";
            reportsToolStripMenuItem.Click += reportsToolStripMenuItem_Click;
            // 
            // sfaffmanagement
            // 
            sfaffmanagement.AutoSize = true;
            sfaffmanagement.Dock = DockStyle.Fill;
            sfaffmanagement.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            sfaffmanagement.ForeColor = SystemColors.ControlLightLight;
            sfaffmanagement.Location = new Point(3, 30);
            sfaffmanagement.Name = "sfaffmanagement";
            sfaffmanagement.Size = new Size(1194, 50);
            sfaffmanagement.TabIndex = 1;
            sfaffmanagement.Text = "Booking Management";
            sfaffmanagement.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.MidnightBlue;
            contentPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            contentPanel.ColumnCount = 2;
            contentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            contentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
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
            leftPanel.ColumnCount = 3;
            leftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            leftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            leftPanel.Controls.Add(searchPanel, 0, 0);
            leftPanel.Controls.Add(dataGridView1, 0, 1);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(12, 12);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(8);
            leftPanel.RowCount = 2;
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            leftPanel.Size = new Size(522, 590);
            leftPanel.TabIndex = 0;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.Navy;
            searchPanel.ColumnCount = 3;
            leftPanel.SetColumnSpan(searchPanel, 3);
            searchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35F));
            searchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            searchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            searchPanel.Controls.Add(pictureBox1, 0, 0);
            searchPanel.Controls.Add(txtSearch, 1, 0);
            searchPanel.Controls.Add(searchcustomer, 2, 0);
            searchPanel.Dock = DockStyle.Fill;
            searchPanel.Location = new Point(11, 11);
            searchPanel.Name = "searchPanel";
            searchPanel.RowCount = 1;
            searchPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            searchPanel.Size = new Size(500, 39);
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
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(38, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(379, 25);
            txtSearch.TabIndex = 1;
            // 
            // searchcustomer
            // 
            searchcustomer.Dock = DockStyle.Fill;
            searchcustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            searchcustomer.Location = new Point(423, 3);
            searchcustomer.Name = "searchcustomer";
            searchcustomer.Size = new Size(74, 33);
            searchcustomer.TabIndex = 2;
            searchcustomer.Text = "🔍 Search";
            searchcustomer.UseVisualStyleBackColor = true;
            searchcustomer.Click += searchcustomer_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            leftPanel.SetColumnSpan(dataGridView1, 3);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(11, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(500, 523);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.Navy;
            rightPanel.ColumnCount = 2;
            rightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            rightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            rightPanel.Controls.Add(adduser, 0, 0);
            rightPanel.Controls.Add(lblBookingID, 0, 1);
            rightPanel.Controls.Add(txtBookingID, 1, 1);
            rightPanel.Controls.Add(lblCustomerID, 0, 2);
            rightPanel.Controls.Add(txtCustomerID, 1, 2);
            rightPanel.Controls.Add(lblPackage, 0, 3);
            rightPanel.Controls.Add(cmbPackageID, 1, 3);
            rightPanel.Controls.Add(lblEventDate, 0, 4);
            rightPanel.Controls.Add(dtpEventDate, 1, 4);
            rightPanel.Controls.Add(lblEventTime, 0, 5);
            rightPanel.Controls.Add(dtpEventTime, 1, 5);
            rightPanel.Controls.Add(lblMobile, 0, 6);
            rightPanel.Controls.Add(txtMobileNumber, 1, 6);
            rightPanel.Controls.Add(lblTotal, 0, 7);
            rightPanel.Controls.Add(txtTotalAmount, 1, 7);
            rightPanel.Controls.Add(lblAdvance, 0, 8);
            rightPanel.Controls.Add(txtAdvance, 1, 8);
            rightPanel.Controls.Add(lblBalance, 0, 9);
            rightPanel.Controls.Add(txtBalance, 1, 9);
            rightPanel.Controls.Add(lblPaymentStatus, 0, 10);
            rightPanel.Controls.Add(cmbPaymentStatus, 1, 10);
            rightPanel.Controls.Add(buttonPanel, 0, 11);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(541, 12);
            rightPanel.Name = "rightPanel";
            rightPanel.Padding = new Padding(10);
            rightPanel.RowCount = 12;
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rightPanel.Size = new Size(641, 590);
            rightPanel.TabIndex = 1;
            // 
            // adduser
            // 
            rightPanel.SetColumnSpan(adduser, 2);
            adduser.Dock = DockStyle.Fill;
            adduser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            adduser.ForeColor = SystemColors.ControlLightLight;
            adduser.Location = new Point(13, 10);
            adduser.Name = "adduser";
            adduser.Size = new Size(615, 40);
            adduser.TabIndex = 0;
            adduser.Text = "📋 Add New Booking";
            adduser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblBookingID
            // 
            lblBookingID.Dock = DockStyle.Fill;
            lblBookingID.Font = new Font("Segoe UI", 9.75F);
            lblBookingID.ForeColor = SystemColors.ControlLightLight;
            lblBookingID.Location = new Point(13, 50);
            lblBookingID.Name = "lblBookingID";
            lblBookingID.Size = new Size(211, 40);
            lblBookingID.TabIndex = 1;
            lblBookingID.Text = "Booking ID :";
            lblBookingID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBookingID
            // 
            txtBookingID.Dock = DockStyle.Fill;
            txtBookingID.Font = new Font("Segoe UI", 10F);
            txtBookingID.Location = new Point(230, 53);
            txtBookingID.Name = "txtBookingID";
            txtBookingID.Size = new Size(398, 25);
            txtBookingID.TabIndex = 2;
            // 
            // lblCustomerID
            // 
            lblCustomerID.Dock = DockStyle.Fill;
            lblCustomerID.Font = new Font("Segoe UI", 9.75F);
            lblCustomerID.ForeColor = SystemColors.ControlLightLight;
            lblCustomerID.Location = new Point(13, 90);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(211, 40);
            lblCustomerID.TabIndex = 3;
            lblCustomerID.Text = "Customer Name /ID :";
            lblCustomerID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Dock = DockStyle.Fill;
            txtCustomerID.Font = new Font("Segoe UI", 10F);
            txtCustomerID.Location = new Point(230, 93);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(398, 25);
            txtCustomerID.TabIndex = 4;
            // 
            // lblPackage
            // 
            lblPackage.Dock = DockStyle.Fill;
            lblPackage.Font = new Font("Segoe UI", 9.75F);
            lblPackage.ForeColor = SystemColors.ControlLightLight;
            lblPackage.Location = new Point(13, 130);
            lblPackage.Name = "lblPackage";
            lblPackage.Size = new Size(211, 40);
            lblPackage.TabIndex = 5;
            lblPackage.Text = "Package Type :";
            lblPackage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbPackageID
            // 
            cmbPackageID.Dock = DockStyle.Fill;
            cmbPackageID.Font = new Font("Segoe UI", 10F);
            cmbPackageID.FormattingEnabled = true;
            cmbPackageID.Location = new Point(230, 133);
            cmbPackageID.Name = "cmbPackageID";
            cmbPackageID.Size = new Size(398, 25);
            cmbPackageID.TabIndex = 6;
            // 
            // lblEventDate
            // 
            lblEventDate.Dock = DockStyle.Fill;
            lblEventDate.Font = new Font("Segoe UI", 9.75F);
            lblEventDate.ForeColor = SystemColors.ControlLightLight;
            lblEventDate.Location = new Point(13, 170);
            lblEventDate.Name = "lblEventDate";
            lblEventDate.Size = new Size(211, 40);
            lblEventDate.TabIndex = 7;
            lblEventDate.Text = "Event Date :";
            lblEventDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpEventDate
            // 
            dtpEventDate.Dock = DockStyle.Fill;
            dtpEventDate.Format = DateTimePickerFormat.Short;
            dtpEventDate.Location = new Point(230, 173);
            dtpEventDate.Name = "dtpEventDate";
            dtpEventDate.Size = new Size(398, 23);
            dtpEventDate.TabIndex = 8;
            // 
            // lblEventTime
            // 
            lblEventTime.Dock = DockStyle.Fill;
            lblEventTime.Font = new Font("Segoe UI", 9.75F);
            lblEventTime.ForeColor = SystemColors.ControlLightLight;
            lblEventTime.Location = new Point(13, 210);
            lblEventTime.Name = "lblEventTime";
            lblEventTime.Size = new Size(211, 40);
            lblEventTime.TabIndex = 9;
            lblEventTime.Text = "Event Time :";
            lblEventTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpEventTime
            // 
            dtpEventTime.Dock = DockStyle.Fill;
            dtpEventTime.Format = DateTimePickerFormat.Time;
            dtpEventTime.Location = new Point(230, 213);
            dtpEventTime.Name = "dtpEventTime";
            dtpEventTime.Size = new Size(398, 23);
            dtpEventTime.TabIndex = 10;
            // 
            // lblMobile
            // 
            lblMobile.Dock = DockStyle.Fill;
            lblMobile.Font = new Font("Segoe UI", 9.75F);
            lblMobile.ForeColor = SystemColors.ControlLightLight;
            lblMobile.Location = new Point(13, 250);
            lblMobile.Name = "lblMobile";
            lblMobile.Size = new Size(211, 40);
            lblMobile.TabIndex = 11;
            lblMobile.Text = "Mobile Number :";
            lblMobile.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMobileNumber
            // 
            txtMobileNumber.Dock = DockStyle.Fill;
            txtMobileNumber.Font = new Font("Segoe UI", 10F);
            txtMobileNumber.Location = new Point(230, 253);
            txtMobileNumber.Name = "txtMobileNumber";
            txtMobileNumber.Size = new Size(398, 25);
            txtMobileNumber.TabIndex = 12;
            // 
            // lblTotal
            // 
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Font = new Font("Segoe UI", 9.75F);
            lblTotal.ForeColor = SystemColors.ControlLightLight;
            lblTotal.Location = new Point(13, 290);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(211, 40);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total Amount :";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Dock = DockStyle.Fill;
            txtTotalAmount.Font = new Font("Segoe UI", 10F);
            txtTotalAmount.Location = new Point(230, 293);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(398, 25);
            txtTotalAmount.TabIndex = 14;
            txtTotalAmount.TextChanged += txtTotalAmount_TextChanged;
            // 
            // lblAdvance
            // 
            lblAdvance.Dock = DockStyle.Fill;
            lblAdvance.Font = new Font("Segoe UI", 9.75F);
            lblAdvance.ForeColor = SystemColors.ControlLightLight;
            lblAdvance.Location = new Point(13, 330);
            lblAdvance.Name = "lblAdvance";
            lblAdvance.Size = new Size(211, 40);
            lblAdvance.TabIndex = 15;
            lblAdvance.Text = "Advance :";
            lblAdvance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAdvance
            // 
            txtAdvance.Dock = DockStyle.Fill;
            txtAdvance.Font = new Font("Segoe UI", 10F);
            txtAdvance.Location = new Point(230, 333);
            txtAdvance.Name = "txtAdvance";
            txtAdvance.Size = new Size(398, 25);
            txtAdvance.TabIndex = 16;
            txtAdvance.TextChanged += txtAdvance_TextChanged;
            // 
            // lblBalance
            // 
            lblBalance.Dock = DockStyle.Fill;
            lblBalance.Font = new Font("Segoe UI", 9.75F);
            lblBalance.ForeColor = SystemColors.ControlLightLight;
            lblBalance.Location = new Point(13, 370);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(211, 40);
            lblBalance.TabIndex = 17;
            lblBalance.Text = "Balance :";
            lblBalance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBalance
            // 
            txtBalance.BackColor = Color.LightGray;
            txtBalance.Dock = DockStyle.Fill;
            txtBalance.Enabled = false;
            txtBalance.Font = new Font("Segoe UI", 10F);
            txtBalance.ForeColor = Color.Black;
            txtBalance.Location = new Point(230, 373);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(398, 25);
            txtBalance.TabIndex = 18;
            txtBalance.Text = "0.00";
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.Dock = DockStyle.Fill;
            lblPaymentStatus.Font = new Font("Segoe UI", 9.75F);
            lblPaymentStatus.ForeColor = SystemColors.ControlLightLight;
            lblPaymentStatus.Location = new Point(13, 410);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new Size(211, 40);
            lblPaymentStatus.TabIndex = 19;
            lblPaymentStatus.Text = "Payment Status :";
            lblPaymentStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.Dock = DockStyle.Fill;
            cmbPaymentStatus.Font = new Font("Segoe UI", 10F);
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Location = new Point(230, 413);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(398, 25);
            cmbPaymentStatus.TabIndex = 20;
            // 
            // buttonPanel
            // 
            rightPanel.SetColumnSpan(buttonPanel, 2);
            buttonPanel.Controls.Add(add);
            buttonPanel.Controls.Add(update);
            buttonPanel.Controls.Add(delete);
            buttonPanel.Controls.Add(clear);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(13, 453);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(5);
            buttonPanel.Size = new Size(615, 124);
            buttonPanel.TabIndex = 21;
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
            add.Click += add_Click_1;
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
            update.Click += update_Click_1;
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
            clear.Click += clear_Click_1;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1200, 700);
            Controls.Add(mainTableLayout);
            Name = "Booking";
            Text = "Booking Management";
            WindowState = FormWindowState.Maximized;
            Load += Booking_Load;
            mainTableLayout.ResumeLayout(false);
            mainTableLayout.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contentPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            rightPanel.ResumeLayout(false);
            rightPanel.PerformLayout();
            buttonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayout;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem customersToolStripMenuItem;
        private ToolStripMenuItem bookingToolStripMenuItem;
        private ToolStripMenuItem packagesToolStripMenuItem;
        private ToolStripMenuItem inventoryToolStripMenuItem;
        private ToolStripMenuItem sToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private Label sfaffmanagement;
        private TableLayoutPanel contentPanel;
        private TableLayoutPanel leftPanel;
        private TableLayoutPanel searchPanel;
        private PictureBox pictureBox1;
        private TextBox txtSearch;
        private Button searchcustomer;
        private DataGridView dataGridView1;
        private TableLayoutPanel rightPanel;
        private Label adduser;
        private Label lblBookingID;
        private TextBox txtBookingID;
        private Label lblCustomerID;
        private TextBox txtCustomerID;
        private Label lblPackage;
        private ComboBox cmbPackageID;
        private Label lblEventDate;
        private DateTimePicker dtpEventDate;
        private Label lblEventTime;
        private DateTimePicker dtpEventTime;
        private Label lblMobile;
        private TextBox txtMobileNumber;
        private Label lblTotal;
        private TextBox txtTotalAmount;
        private Label lblAdvance;
        private TextBox txtAdvance;
        private Label lblBalance;
        private TextBox txtBalance;
        private Label lblPaymentStatus;
        private ComboBox cmbPaymentStatus;
        private FlowLayoutPanel buttonPanel;
        private Button add;
        private Button update;
        private Button delete;
        private Button clear;
    }
}