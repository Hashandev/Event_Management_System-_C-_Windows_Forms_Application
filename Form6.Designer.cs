namespace WinFormsApp1
{
    partial class staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staff));
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
            adduser = new Label();
            fullname = new Label();
            fullnamebox = new TextBox();
            staffid = new Label();
            staffidbox = new TextBox();
            position = new Label();
            positionbox = new ComboBox();
            email = new Label();
            emailbox = new TextBox();
            mobilenumber = new Label();
            mobilenumberbox = new TextBox();
            address = new Label();
            addressContainer = new TableLayoutPanel();
            addressbox = new RichTextBox();
            buttonPanel = new FlowLayoutPanel();
            add = new Button();
            update = new Button();
            delete = new Button();
            clear = new Button();
            rightPanel = new TableLayoutPanel();
            assignTitle = new Label();
            eventLabel = new Label();
            eventidbox = new ComboBox();
            staffLabel = new Label();
            assignContainer = new TableLayoutPanel();
            staffComboBox = new ComboBox();
            assign = new Button();
            dataGridView1 = new DataGridView();
            mainTableLayout.SuspendLayout();
            menuStrip1.SuspendLayout();
            contentPanel.SuspendLayout();
            leftPanel.SuspendLayout();
            addressContainer.SuspendLayout();
            buttonPanel.SuspendLayout();
            rightPanel.SuspendLayout();
            assignContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            mainTableLayout.Size = new Size(900, 600);
            mainTableLayout.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, customersToolStripMenuItem, bookingToolStripMenuItem, packagesToolStripMenuItem, inventoryToolStripMenuItem, sToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(900, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardToolStripMenuItem.Image = (Image)resources.GetObject("dashboardToolStripMenuItem.Image");
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(68, 20);
            dashboardToolStripMenuItem.Text = "Home";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // customersToolStripMenuItem
            // 
            customersToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customersToolStripMenuItem.Image = (Image)resources.GetObject("customersToolStripMenuItem.Image");
            customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            customersToolStripMenuItem.Size = new Size(92, 20);
            customersToolStripMenuItem.Text = "Customers";
            customersToolStripMenuItem.Click += customersToolStripMenuItem_Click;
            // 
            // bookingToolStripMenuItem
            // 
            bookingToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookingToolStripMenuItem.Image = (Image)resources.GetObject("bookingToolStripMenuItem.Image");
            bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            bookingToolStripMenuItem.Size = new Size(79, 20);
            bookingToolStripMenuItem.Text = "Booking";
            bookingToolStripMenuItem.Click += bookingToolStripMenuItem_Click;
            // 
            // packagesToolStripMenuItem
            // 
            packagesToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            packagesToolStripMenuItem.Image = (Image)resources.GetObject("packagesToolStripMenuItem.Image");
            packagesToolStripMenuItem.Name = "packagesToolStripMenuItem";
            packagesToolStripMenuItem.Size = new Size(84, 20);
            packagesToolStripMenuItem.Text = "Packages";
            packagesToolStripMenuItem.Click += packagesToolStripMenuItem_Click;
            // 
            // inventoryToolStripMenuItem
            // 
            inventoryToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventoryToolStripMenuItem.Image = (Image)resources.GetObject("inventoryToolStripMenuItem.Image");
            inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            inventoryToolStripMenuItem.Size = new Size(85, 20);
            inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // sToolStripMenuItem
            // 
            sToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sToolStripMenuItem.Image = (Image)resources.GetObject("sToolStripMenuItem.Image");
            sToolStripMenuItem.Name = "sToolStripMenuItem";
            sToolStripMenuItem.Size = new Size(59, 20);
            sToolStripMenuItem.Text = "Staff";
            sToolStripMenuItem.Click += sToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reportsToolStripMenuItem.Image = (Image)resources.GetObject("reportsToolStripMenuItem.Image");
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(75, 20);
            reportsToolStripMenuItem.Text = "Reports";
            reportsToolStripMenuItem.Click += reportsToolStripMenuItem_Click;
            // 
            // sfaffmanagement
            // 
            sfaffmanagement.AutoSize = true;
            sfaffmanagement.Dock = DockStyle.Fill;
            sfaffmanagement.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sfaffmanagement.ForeColor = SystemColors.ControlLightLight;
            sfaffmanagement.Location = new Point(3, 30);
            sfaffmanagement.Name = "sfaffmanagement";
            sfaffmanagement.Size = new Size(894, 50);
            sfaffmanagement.TabIndex = 1;
            sfaffmanagement.Text = "Staff Management";
            sfaffmanagement.TextAlign = ContentAlignment.MiddleCenter;
            sfaffmanagement.Click += sfaffmanagement_Click_1;
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
            contentPanel.Padding = new Padding(10);
            contentPanel.RowCount = 1;
            contentPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contentPanel.Size = new Size(894, 514);
            contentPanel.TabIndex = 2;
            // 
            // leftPanel
            // 
            leftPanel.BackColor = Color.Navy;
            leftPanel.ColumnCount = 1;
            leftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            leftPanel.Controls.Add(adduser, 0, 0);
            leftPanel.Controls.Add(fullname, 0, 1);
            leftPanel.Controls.Add(fullnamebox, 0, 2);
            leftPanel.Controls.Add(staffid, 0, 3);
            leftPanel.Controls.Add(staffidbox, 0, 4);
            leftPanel.Controls.Add(position, 0, 5);
            leftPanel.Controls.Add(positionbox, 0, 6);
            leftPanel.Controls.Add(email, 0, 7);
            leftPanel.Controls.Add(emailbox, 0, 8);
            leftPanel.Controls.Add(mobilenumber, 0, 9);
            leftPanel.Controls.Add(mobilenumberbox, 0, 10);
            leftPanel.Controls.Add(address, 0, 11);
            leftPanel.Controls.Add(addressContainer, 0, 12);
            leftPanel.Dock = DockStyle.Fill;
            leftPanel.Location = new Point(14, 14);
            leftPanel.Name = "leftPanel";
            leftPanel.Padding = new Padding(10);
            leftPanel.RowCount = 13;
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            leftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            leftPanel.Size = new Size(429, 486);
            leftPanel.TabIndex = 0;
            // 
            // adduser
            // 
            adduser.Dock = DockStyle.Fill;
            adduser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            adduser.ForeColor = SystemColors.ControlLightLight;
            adduser.Location = new Point(13, 10);
            adduser.Name = "adduser";
            adduser.Size = new Size(403, 35);
            adduser.TabIndex = 0;
            adduser.Text = "Add Staff Member";
            adduser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fullname
            // 
            fullname.Dock = DockStyle.Fill;
            fullname.Font = new Font("Segoe UI", 9.75F);
            fullname.ForeColor = SystemColors.ControlLightLight;
            fullname.Location = new Point(13, 45);
            fullname.Name = "fullname";
            fullname.Size = new Size(403, 25);
            fullname.TabIndex = 1;
            fullname.Text = "Full Name :";
            fullname.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fullnamebox
            // 
            fullnamebox.Dock = DockStyle.Fill;
            fullnamebox.Location = new Point(13, 73);
            fullnamebox.Name = "fullnamebox";
            fullnamebox.Size = new Size(403, 23);
            fullnamebox.TabIndex = 2;
            // 
            // staffid
            // 
            staffid.Dock = DockStyle.Fill;
            staffid.Font = new Font("Segoe UI", 9.75F);
            staffid.ForeColor = SystemColors.ControlLightLight;
            staffid.Location = new Point(13, 100);
            staffid.Name = "staffid";
            staffid.Size = new Size(403, 25);
            staffid.TabIndex = 3;
            staffid.Text = "Staff ID :";
            staffid.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // staffidbox
            // 
            staffidbox.Dock = DockStyle.Fill;
            staffidbox.Location = new Point(13, 128);
            staffidbox.Name = "staffidbox";
            staffidbox.Size = new Size(403, 23);
            staffidbox.TabIndex = 4;
            // 
            // position
            // 
            position.Dock = DockStyle.Fill;
            position.Font = new Font("Segoe UI", 9.75F);
            position.ForeColor = SystemColors.ControlLightLight;
            position.Location = new Point(13, 155);
            position.Name = "position";
            position.Size = new Size(403, 25);
            position.TabIndex = 5;
            position.Text = "Position :";
            position.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // positionbox
            // 
            positionbox.Dock = DockStyle.Fill;
            positionbox.Items.AddRange(new object[] { "Event Manager", "Coordinator", "Photographer", "Videographer", "Decorator", "Caterer", "DJ / Sound Operator", "Security Officer", "Receptionist", "Driver", "Waiter", "Cleaner" });
            positionbox.Location = new Point(13, 183);
            positionbox.Name = "positionbox";
            positionbox.Size = new Size(403, 23);
            positionbox.TabIndex = 6;
            // 
            // email
            // 
            email.Dock = DockStyle.Fill;
            email.Font = new Font("Segoe UI", 9.75F);
            email.ForeColor = SystemColors.ControlLightLight;
            email.Location = new Point(13, 210);
            email.Name = "email";
            email.Size = new Size(403, 25);
            email.TabIndex = 7;
            email.Text = "Email :";
            email.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // emailbox
            // 
            emailbox.Dock = DockStyle.Fill;
            emailbox.Location = new Point(13, 238);
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(403, 23);
            emailbox.TabIndex = 8;
            // 
            // mobilenumber
            // 
            mobilenumber.Dock = DockStyle.Fill;
            mobilenumber.Font = new Font("Segoe UI", 9.75F);
            mobilenumber.ForeColor = SystemColors.ControlLightLight;
            mobilenumber.Location = new Point(13, 265);
            mobilenumber.Name = "mobilenumber";
            mobilenumber.Size = new Size(403, 25);
            mobilenumber.TabIndex = 9;
            mobilenumber.Text = "Mobile Number :";
            mobilenumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mobilenumberbox
            // 
            mobilenumberbox.Dock = DockStyle.Fill;
            mobilenumberbox.Location = new Point(13, 293);
            mobilenumberbox.Name = "mobilenumberbox";
            mobilenumberbox.Size = new Size(403, 23);
            mobilenumberbox.TabIndex = 10;
            // 
            // address
            // 
            address.Dock = DockStyle.Fill;
            address.Font = new Font("Segoe UI", 9.75F);
            address.ForeColor = SystemColors.ControlLightLight;
            address.Location = new Point(13, 320);
            address.Name = "address";
            address.Size = new Size(403, 25);
            address.TabIndex = 11;
            address.Text = "Address :";
            address.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // addressContainer
            // 
            addressContainer.ColumnCount = 1;
            addressContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            addressContainer.Controls.Add(addressbox, 0, 0);
            addressContainer.Controls.Add(buttonPanel, 0, 1);
            addressContainer.Dock = DockStyle.Fill;
            addressContainer.Location = new Point(13, 348);
            addressContainer.Name = "addressContainer";
            addressContainer.RowCount = 2;
            addressContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));
            addressContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            addressContainer.Size = new Size(403, 125);
            addressContainer.TabIndex = 12;
            // 
            // addressbox
            // 
            addressbox.Dock = DockStyle.Fill;
            addressbox.Location = new Point(3, 3);
            addressbox.Name = "addressbox";
            addressbox.Size = new Size(397, 75);
            addressbox.TabIndex = 0;
            addressbox.Text = "";
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(add);
            buttonPanel.Controls.Add(update);
            buttonPanel.Controls.Add(delete);
            buttonPanel.Controls.Add(clear);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(3, 84);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Padding = new Padding(0, 5, 0, 5);
            buttonPanel.Size = new Size(397, 38);
            buttonPanel.TabIndex = 1;
            // 
            // add
            // 
            add.BackColor = Color.ForestGreen;
            add.FlatStyle = FlatStyle.Flat;
            add.ForeColor = Color.White;
            add.Location = new Point(3, 8);
            add.Name = "add";
            add.Size = new Size(75, 28);
            add.TabIndex = 0;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            // 
            // update
            // 
            update.BackColor = Color.SteelBlue;
            update.FlatStyle = FlatStyle.Flat;
            update.ForeColor = Color.White;
            update.Location = new Point(84, 8);
            update.Name = "update";
            update.Size = new Size(75, 28);
            update.TabIndex = 1;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Crimson;
            delete.FlatStyle = FlatStyle.Flat;
            delete.ForeColor = Color.White;
            delete.Location = new Point(165, 8);
            delete.Name = "delete";
            delete.Size = new Size(75, 28);
            delete.TabIndex = 2;
            delete.Text = "DELETE";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // clear
            // 
            clear.BackColor = Color.SlateGray;
            clear.FlatStyle = FlatStyle.Flat;
            clear.ForeColor = Color.White;
            clear.Location = new Point(246, 8);
            clear.Name = "clear";
            clear.Size = new Size(75, 28);
            clear.TabIndex = 3;
            clear.Text = "CLEAR";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // rightPanel
            // 
            rightPanel.BackColor = Color.Navy;
            rightPanel.ColumnCount = 1;
            rightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rightPanel.Controls.Add(assignTitle, 0, 0);
            rightPanel.Controls.Add(eventLabel, 0, 1);
            rightPanel.Controls.Add(eventidbox, 0, 2);
            rightPanel.Controls.Add(staffLabel, 0, 3);
            rightPanel.Controls.Add(assignContainer, 0, 4);
            rightPanel.Controls.Add(dataGridView1, 0, 5);
            rightPanel.Dock = DockStyle.Fill;
            rightPanel.Location = new Point(450, 14);
            rightPanel.Name = "rightPanel";
            rightPanel.Padding = new Padding(10);
            rightPanel.RowCount = 6;
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            rightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rightPanel.Size = new Size(430, 486);
            rightPanel.TabIndex = 1;
            // 
            // assignTitle
            // 
            assignTitle.Dock = DockStyle.Fill;
            assignTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            assignTitle.ForeColor = SystemColors.ControlLightLight;
            assignTitle.Location = new Point(13, 10);
            assignTitle.Name = "assignTitle";
            assignTitle.Size = new Size(404, 35);
            assignTitle.TabIndex = 0;
            assignTitle.Text = "Assign Staff Member";
            assignTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // eventLabel
            // 
            eventLabel.Dock = DockStyle.Fill;
            eventLabel.Font = new Font("Segoe UI", 9.75F);
            eventLabel.ForeColor = SystemColors.ControlLightLight;
            eventLabel.Location = new Point(13, 45);
            eventLabel.Name = "eventLabel";
            eventLabel.Size = new Size(404, 25);
            eventLabel.TabIndex = 1;
            eventLabel.Text = "Event ID :";
            eventLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // eventidbox
            // 
            eventidbox.Dock = DockStyle.Fill;
            eventidbox.Location = new Point(13, 73);
            eventidbox.Name = "eventidbox";
            eventidbox.Size = new Size(404, 23);
            eventidbox.TabIndex = 2;
            // 
            // staffLabel
            // 
            staffLabel.Dock = DockStyle.Fill;
            staffLabel.Font = new Font("Segoe UI", 9.75F);
            staffLabel.ForeColor = SystemColors.ControlLightLight;
            staffLabel.Location = new Point(13, 100);
            staffLabel.Name = "staffLabel";
            staffLabel.Size = new Size(404, 25);
            staffLabel.TabIndex = 3;
            staffLabel.Text = "Staff ID :";
            staffLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // assignContainer
            // 
            assignContainer.ColumnCount = 2;
            assignContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            assignContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            assignContainer.Controls.Add(staffComboBox, 0, 0);
            assignContainer.Controls.Add(assign, 1, 0);
            assignContainer.Dock = DockStyle.Fill;
            assignContainer.Location = new Point(13, 128);
            assignContainer.Name = "assignContainer";
            assignContainer.RowCount = 1;
            assignContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            assignContainer.Size = new Size(404, 29);
            assignContainer.TabIndex = 4;
            // 
            // staffComboBox
            // 
            staffComboBox.Dock = DockStyle.Fill;
            staffComboBox.Location = new Point(3, 3);
            staffComboBox.Name = "staffComboBox";
            staffComboBox.Size = new Size(276, 23);
            staffComboBox.TabIndex = 0;
            // 
            // assign
            // 
            assign.BackColor = Color.DarkGreen;
            assign.Dock = DockStyle.Fill;
            assign.FlatStyle = FlatStyle.Flat;
            assign.ForeColor = Color.White;
            assign.Location = new Point(285, 3);
            assign.Name = "assign";
            assign.Size = new Size(116, 23);
            assign.TabIndex = 1;
            assign.Text = "Assign";
            assign.UseVisualStyleBackColor = false;
            assign.Click += assign_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(13, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(404, 310);
            dataGridView1.TabIndex = 5;
            // 
            // staff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(900, 600);
            Controls.Add(mainTableLayout);
            Name = "staff";
            Text = "Staff Management";
            WindowState = FormWindowState.Maximized;
            Load += staff_Load;
            mainTableLayout.ResumeLayout(false);
            mainTableLayout.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contentPanel.ResumeLayout(false);
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            addressContainer.ResumeLayout(false);
            buttonPanel.ResumeLayout(false);
            rightPanel.ResumeLayout(false);
            assignContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label adduser;
        private Label fullname;
        private TextBox fullnamebox;
        private Label staffid;
        private TextBox staffidbox;
        private Label position;
        private ComboBox positionbox;
        private Label email;
        private TextBox emailbox;
        private Label mobilenumber;
        private TextBox mobilenumberbox;
        private Label address;
        private TableLayoutPanel addressContainer;
        private RichTextBox addressbox;
        private FlowLayoutPanel buttonPanel;
        private Button add;
        private Button update;
        private Button delete;
        private Button clear;
        private TableLayoutPanel rightPanel;
        private Label assignTitle;
        private Label eventLabel;
        private ComboBox eventidbox;
        private Label staffLabel;
        private TableLayoutPanel assignContainer;
        private ComboBox staffComboBox;
        private Button assign;
        private DataGridView dataGridView1;
    }
}