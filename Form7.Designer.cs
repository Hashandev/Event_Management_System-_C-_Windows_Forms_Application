namespace WinFormsApp1
{
    partial class inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventory));
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem = new ToolStripMenuItem();
            packagesToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            sToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label7 = new Label();
            panel3 = new Panel();
            btnAdd = new Button();
            txtItemQty = new TextBox();
            label2 = new Label();
            txtItemName = new TextBox();
            label1 = new Label();
            dgvInventory = new DataGridView();
            panel2 = new Panel();
            btnRemoveAssigned = new Button();
            dgvAssignedItems = new DataGridView();
            lblAssignedCount = new Label();
            btnAssign = new Button();
            txtAssignQty = new TextBox();
            label5 = new Label();
            cmbItem = new ComboBox();
            label4 = new Label();
            cmbBooking = new ComboBox();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignedItems).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 10F);
            menuStrip1.ForeColor = Color.Black;
            menuStrip1.Items.AddRange(new ToolStripItem[] {
                dashboardToolStripMenuItem,
                customersToolStripMenuItem,
                bookingToolStripMenuItem,
                packagesToolStripMenuItem,
                inventoryToolStripMenuItem,
                sToolStripMenuItem,
                reportsToolStripMenuItem
            });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1200, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.BackColor = Color.White;
            dashboardToolStripMenuItem.ForeColor = Color.Black;
            dashboardToolStripMenuItem.Image = (Image)resources.GetObject("dashboardToolStripMenuItem.Image");
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(76, 24);
            dashboardToolStripMenuItem.Text = "Home";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.BackColor = Color.White;
            customersToolStripMenuItem.ForeColor = Color.Black;
            customersToolStripMenuItem.Image = (Image)resources.GetObject("customersToolStripMenuItem.Image");
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(100, 24);
            customersToolStripMenuItem.Text = "Customers";
            customersToolStripMenuItem.Click += customersToolStripMenuItem_Click;
            // 
            // bookingToolStripMenuItem
            // 
            bookingToolStripMenuItem.BackColor = Color.White;
            bookingToolStripMenuItem.ForeColor = Color.Black;
            bookingToolStripMenuItem.Image = (Image)resources.GetObject("bookingToolStripMenuItem.Image");
            bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            bookingToolStripMenuItem.Size = new Size(87, 24);
            bookingToolStripMenuItem.Text = "Booking";
            bookingToolStripMenuItem.Click += bookingToolStripMenuItem_Click;
            // 
            // packagesToolStripMenuItem
            // 
            packagesToolStripMenuItem.BackColor = Color.White;
            packagesToolStripMenuItem.ForeColor = Color.Black;
            packagesToolStripMenuItem.Image = (Image)resources.GetObject("packagesToolStripMenuItem.Image");
            packagesToolStripMenuItem.Name = "packagesToolStripMenuItem";
            packagesToolStripMenuItem.Size = new Size(92, 24);
            packagesToolStripMenuItem.Text = "Packages";
            packagesToolStripMenuItem.Click += packagesToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.BackColor = Color.White;
            inventoryToolStripMenuItem.ForeColor = Color.Black;
            inventoryToolStripMenuItem.Image = (Image)resources.GetObject("inventoryToolStripMenuItem.Image");
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(93, 24);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // sToolStripMenuItem
            // 
            sToolStripMenuItem.BackColor = Color.White;
            sToolStripMenuItem.ForeColor = Color.Black;
            sToolStripMenuItem.Image = (Image)resources.GetObject("sToolStripMenuItem.Image");
            sToolStripMenuItem.Name = "sToolStripMenuItem";
            sToolStripMenuItem.Size = new Size(65, 24);
            sToolStripMenuItem.Text = "Staff";
            sToolStripMenuItem.Click += sToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.BackColor = Color.White;
            reportsToolStripMenuItem.ForeColor = Color.Black;
            reportsToolStripMenuItem.Image = (Image)resources.GetObject("reportsToolStripMenuItem.Image");
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(83, 24);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dgvInventory);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 30);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(1200, 650);
            panel1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(430, 5);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 5;
            label7.Text = "Inventory";
            // 
            // panel3 - Add Items (Left Side - Top)
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(txtItemQty);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtItemName);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(20, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 230);
            panel3.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(15, 180);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(270, 35);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD ITEM";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAddItem_Click;
            btnAdd.MouseEnter += (s, e) => { btnAdd.BackColor = Color.FromArgb(39, 174, 96); };
            btnAdd.MouseLeave += (s, e) => { btnAdd.BackColor = Color.FromArgb(46, 204, 113); };
            // 
            // txtItemQty
            // 
            txtItemQty.Font = new Font("Segoe UI", 10F);
            txtItemQty.Location = new Point(15, 140);
            txtItemQty.Name = "txtItemQty";
            txtItemQty.Size = new Size(270, 25);
            txtItemQty.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(15, 120);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantity :";
            // 
            // txtItemName
            // 
            txtItemName.Font = new Font("Segoe UI", 10F);
            txtItemName.Location = new Point(15, 85);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(270, 25);
            txtItemName.TabIndex = 1;
            txtItemName.Text = "Enter item name";
            txtItemName.ForeColor = Color.Gray;
            txtItemName.Enter += (s, e) => { if (txtItemName.Text == "Enter item name") { txtItemName.Text = ""; txtItemName.ForeColor = Color.Black; } };
            txtItemName.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtItemName.Text)) { txtItemName.Text = "Enter item name"; txtItemName.ForeColor = Color.Gray; } };
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "Add Items";
            // 
            // dgvInventory - DataGridView (Right Side - Top)
            // 
            dgvInventory.BackgroundColor = Color.White;
            dgvInventory.BorderStyle = BorderStyle.None;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new Point(340, 30);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.Size = new Size(840, 230);
            dgvInventory.TabIndex = 4;
            // 
            // panel2 - Assign Items (Bottom - Full Width)
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnRemoveAssigned);
            panel2.Controls.Add(dgvAssignedItems);
            panel2.Controls.Add(lblAssignedCount);
            panel2.Controls.Add(btnAssign);
            panel2.Controls.Add(txtAssignQty);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cmbItem);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cmbBooking);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(20, 280);
            panel2.Name = "panel2";
            panel2.Size = new Size(1160, 350);
            panel2.TabIndex = 3;
            // 
            // btnRemoveAssigned
            // 
            btnRemoveAssigned.BackColor = Color.FromArgb(231, 76, 60);
            btnRemoveAssigned.FlatStyle = FlatStyle.Flat;
            btnRemoveAssigned.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRemoveAssigned.ForeColor = Color.White;
            btnRemoveAssigned.Location = new Point(15, 305);
            btnRemoveAssigned.Name = "btnRemoveAssigned";
            btnRemoveAssigned.Size = new Size(300, 30);
            btnRemoveAssigned.TabIndex = 12;
            btnRemoveAssigned.Text = "REMOVE SELECTED";
            btnRemoveAssigned.UseVisualStyleBackColor = false;
            btnRemoveAssigned.Click += btnRemoveAssigned_Click;
            btnRemoveAssigned.MouseEnter += (s, e) => { btnRemoveAssigned.BackColor = Color.FromArgb(192, 57, 43); };
            btnRemoveAssigned.MouseLeave += (s, e) => { btnRemoveAssigned.BackColor = Color.FromArgb(231, 76, 60); };
            // 
            // dgvAssignedItems
            // 
            dgvAssignedItems.BackgroundColor = Color.White;
            dgvAssignedItems.BorderStyle = BorderStyle.None;
            dgvAssignedItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignedItems.Location = new Point(340, 30);
            dgvAssignedItems.Name = "dgvAssignedItems";
            dgvAssignedItems.ReadOnly = true;
            dgvAssignedItems.RowHeadersVisible = false;
            dgvAssignedItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAssignedItems.Size = new Size(800, 305);
            dgvAssignedItems.TabIndex = 11;
            // 
            // lblAssignedCount
            // 
            lblAssignedCount.AutoSize = true;
            lblAssignedCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAssignedCount.ForeColor = Color.FromArgb(44, 62, 80);
            lblAssignedCount.Location = new Point(340, 5);
            lblAssignedCount.Name = "lblAssignedCount";
            lblAssignedCount.Size = new Size(112, 19);
            lblAssignedCount.TabIndex = 10;
            lblAssignedCount.Text = "Assigned Items: 0";
            // 
            // btnAssign
            // 
            btnAssign.BackColor = Color.FromArgb(52, 152, 219);
            btnAssign.FlatStyle = FlatStyle.Flat;
            btnAssign.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAssign.ForeColor = Color.White;
            btnAssign.Location = new Point(15, 260);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(300, 35);
            btnAssign.TabIndex = 9;
            btnAssign.Text = "ASSIGN ITEM";
            btnAssign.UseVisualStyleBackColor = false;
            btnAssign.Click += btnAssignItem_Click;
            btnAssign.MouseEnter += (s, e) => { btnAssign.BackColor = Color.FromArgb(41, 128, 185); };
            btnAssign.MouseLeave += (s, e) => { btnAssign.BackColor = Color.FromArgb(52, 152, 219); };
            // 
            // txtAssignQty
            // 
            txtAssignQty.Font = new Font("Segoe UI", 10F);
            txtAssignQty.Location = new Point(15, 225);
            txtAssignQty.Name = "txtAssignQty";
            txtAssignQty.Size = new Size(300, 25);
            txtAssignQty.TabIndex = 8;
            txtAssignQty.Text = "Enter quantity";
            txtAssignQty.ForeColor = Color.Gray;
            txtAssignQty.Enter += (s, e) => { if (txtAssignQty.Text == "Enter quantity") { txtAssignQty.Text = ""; txtAssignQty.ForeColor = Color.Black; } };
            txtAssignQty.Leave += (s, e) => { if (string.IsNullOrWhiteSpace(txtAssignQty.Text)) { txtAssignQty.Text = "Enter quantity"; txtAssignQty.ForeColor = Color.Gray; } };
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(15, 205);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 7;
            label5.Text = "Quantity :";
            // 
            // cmbItem
            // 
            cmbItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbItem.Font = new Font("Segoe UI", 10F);
            cmbItem.FormattingEnabled = true;
            cmbItem.Location = new Point(15, 170);
            cmbItem.Name = "cmbItem";
            cmbItem.Size = new Size(300, 25);
            cmbItem.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(15, 150);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 5;
            label4.Text = "Item :";
            // 
            // cmbBooking
            // 
            cmbBooking.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBooking.Font = new Font("Segoe UI", 10F);
            cmbBooking.FormattingEnabled = true;
            cmbBooking.Location = new Point(15, 115);
            cmbBooking.Name = "cmbBooking";
            cmbBooking.Size = new Size(300, 25);
            cmbBooking.TabIndex = 4;
            cmbBooking.SelectedIndexChanged += cmbBooking_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(15, 20);
            label3.Name = "label3";
            label3.Size = new Size(164, 20);
            label3.TabIndex = 3;
            label3.Text = "Assign Items to Booking";
            // 
            // inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 680);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Management";
            WindowState = FormWindowState.Maximized;
            Load += inventory_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAssignedItems).EndInit();
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
        private Panel panel2;
        private Panel panel3;
        private DataGridView dgvInventory;
        private Label label7;

        private Label label1;
        private TextBox txtItemName;
        private Label label2;
        private TextBox txtItemQty;
        private Button btnAdd;

        private Label label3;
        private ComboBox cmbBooking;
        private Label label4;
        private ComboBox cmbItem;
        private Label label5;
        private TextBox txtAssignQty;
        private Button btnAssign;
        private DataGridView dgvAssignedItems;
        private Label lblAssignedCount;
        private Button btnRemoveAssigned;
    }
}