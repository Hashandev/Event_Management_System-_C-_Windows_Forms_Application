namespace WinFormsApp1
{
    partial class customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            customersToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem = new ToolStripMenuItem();
            packagesToolStripMenuItem = new ToolStripMenuItem();
            inventoryToolStripMenuItem = new ToolStripMenuItem();
            sToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            searchcustomer = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            addressbox = new TextBox();
            address = new Label();
            mobilenumberbox = new TextBox();
            mobilenumber = new Label();
            emailbox = new TextBox();
            email = new Label();
            lastnamebox = new TextBox();
            lastname = new Label();
            firstnamebox = new TextBox();
            adduser = new Label();
            fristname = new Label();
            cuslable01 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, customersToolStripMenuItem, bookingToolStripMenuItem, packagesToolStripMenuItem, inventoryToolStripMenuItem, sToolStripMenuItem, reportsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 24);
            menuStrip1.TabIndex = 36;
            menuStrip1.Text = "menuStripdash";
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(searchcustomer);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(3, 33);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(544, 501);
            panel1.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 26);
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // searchcustomer
            // 
            searchcustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchcustomer.Location = new Point(464, 12);
            searchcustomer.Name = "searchcustomer";
            searchcustomer.Size = new Size(68, 23);
            searchcustomer.TabIndex = 44;
            searchcustomer.Text = "Search";
            searchcustomer.UseVisualStyleBackColor = true;
            searchcustomer.Click += searchcustomer_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(39, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(419, 23);
            textBox1.TabIndex = 43;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 42);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(527, 449);
            dataGridView1.TabIndex = 42;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(addressbox);
            panel2.Controls.Add(address);
            panel2.Controls.Add(mobilenumberbox);
            panel2.Controls.Add(mobilenumber);
            panel2.Controls.Add(emailbox);
            panel2.Controls.Add(email);
            panel2.Controls.Add(lastnamebox);
            panel2.Controls.Add(lastname);
            panel2.Controls.Add(firstnamebox);
            panel2.Controls.Add(adduser);
            panel2.Controls.Add(fristname);
            panel2.Location = new Point(553, 33);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(444, 501);
            panel2.TabIndex = 39;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.SlateGray;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(347, 460);
            button3.Name = "button3";
            button3.Size = new Size(80, 30);
            button3.TabIndex = 74;
            button3.Text = "CLEAR";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Crimson;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(262, 460);
            button2.Name = "button2";
            button2.Size = new Size(80, 30);
            button2.TabIndex = 73;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.SteelBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(177, 460);
            button1.Name = "button1";
            button1.Size = new Size(80, 30);
            button1.TabIndex = 72;
            button1.Text = "UPDATE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.ForestGreen;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(92, 460);
            button4.Name = "button4";
            button4.Size = new Size(80, 30);
            button4.TabIndex = 71;
            button4.Text = "ADD";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(177, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 25);
            textBox2.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 60);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 69;
            label1.Text = "User ID :";
            // 
            // addressbox
            // 
            addressbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressbox.BackColor = Color.White;
            addressbox.BorderStyle = BorderStyle.FixedSingle;
            addressbox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressbox.ForeColor = Color.Black;
            addressbox.Location = new Point(177, 257);
            addressbox.Name = "addressbox";
            addressbox.Size = new Size(245, 25);
            addressbox.TabIndex = 68;
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            address.ForeColor = Color.White;
            address.Location = new Point(14, 260);
            address.Name = "address";
            address.Size = new Size(71, 19);
            address.TabIndex = 67;
            address.Text = "Address :";
            // 
            // mobilenumberbox
            // 
            mobilenumberbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mobilenumberbox.BackColor = Color.White;
            mobilenumberbox.BorderStyle = BorderStyle.FixedSingle;
            mobilenumberbox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mobilenumberbox.ForeColor = Color.Black;
            mobilenumberbox.Location = new Point(177, 217);
            mobilenumberbox.Name = "mobilenumberbox";
            mobilenumberbox.Size = new Size(245, 25);
            mobilenumberbox.TabIndex = 66;
            // 
            // mobilenumber
            // 
            mobilenumber.AutoSize = true;
            mobilenumber.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mobilenumber.ForeColor = Color.White;
            mobilenumber.Location = new Point(14, 220);
            mobilenumber.Name = "mobilenumber";
            mobilenumber.Size = new Size(123, 19);
            mobilenumber.TabIndex = 65;
            mobilenumber.Text = "Mobile Number :";
            // 
            // emailbox
            // 
            emailbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            emailbox.BackColor = Color.White;
            emailbox.BorderStyle = BorderStyle.FixedSingle;
            emailbox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailbox.ForeColor = Color.Black;
            emailbox.Location = new Point(177, 177);
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(245, 25);
            emailbox.TabIndex = 64;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email.ForeColor = Color.White;
            email.Location = new Point(14, 180);
            email.Name = "email";
            email.Size = new Size(53, 19);
            email.TabIndex = 63;
            email.Text = "Email :";
            // 
            // lastnamebox
            // 
            lastnamebox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lastnamebox.BackColor = Color.White;
            lastnamebox.BorderStyle = BorderStyle.FixedSingle;
            lastnamebox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastnamebox.ForeColor = Color.Black;
            lastnamebox.Location = new Point(177, 137);
            lastnamebox.Name = "lastnamebox";
            lastnamebox.Size = new Size(245, 25);
            lastnamebox.TabIndex = 62;
            // 
            // lastname
            // 
            lastname.AutoSize = true;
            lastname.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastname.ForeColor = Color.White;
            lastname.Location = new Point(14, 140);
            lastname.Name = "lastname";
            lastname.Size = new Size(87, 19);
            lastname.TabIndex = 61;
            lastname.Text = "Last Name :";
            // 
            // firstnamebox
            // 
            firstnamebox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            firstnamebox.BackColor = Color.White;
            firstnamebox.BorderStyle = BorderStyle.FixedSingle;
            firstnamebox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstnamebox.ForeColor = Color.Black;
            firstnamebox.Location = new Point(177, 97);
            firstnamebox.Name = "firstnamebox";
            firstnamebox.Size = new Size(245, 25);
            firstnamebox.TabIndex = 60;
            // 
            // adduser
            // 
            adduser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            adduser.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adduser.ForeColor = Color.White;
            adduser.Location = new Point(14, 10);
            adduser.Name = "adduser";
            adduser.Size = new Size(408, 35);
            adduser.TabIndex = 59;
            adduser.Text = "Add User";
            adduser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fristname
            // 
            fristname.AutoSize = true;
            fristname.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fristname.ForeColor = Color.White;
            fristname.Location = new Point(14, 100);
            fristname.Name = "fristname";
            fristname.Size = new Size(89, 19);
            fristname.TabIndex = 58;
            fristname.Text = "First Name :";
            // 
            // cuslable01
            // 
            cuslable01.Anchor = AnchorStyles.Top;
            cuslable01.AutoSize = true;
            cuslable01.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuslable01.ForeColor = Color.White;
            cuslable01.Location = new Point(305, 18);
            cuslable01.Name = "cuslable01";
            cuslable01.Size = new Size(319, 37);
            cuslable01.TabIndex = 40;
            cuslable01.Text = "Customer Management";
            cuslable01.TextAlign = ContentAlignment.MiddleCenter;
            cuslable01.Click += cuslable01_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1000, 537);
            tableLayoutPanel1.TabIndex = 41;
            // 
            // customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1000, 561);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(cuslable01);
            Controls.Add(menuStrip1);
            MinimumSize = new Size(800, 600);
            Name = "customer";
            Text = "customer";
            WindowState = FormWindowState.Maximized;
            Resize += customer_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
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
        private Label cuslable01;
        private PictureBox pictureBox1;
        private Button searchcustomer;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private TextBox textBox2;
        private Label label1;
        private TextBox addressbox;
        private Label address;
        private TextBox mobilenumberbox;
        private Label mobilenumber;
        private TextBox emailbox;
        private Label email;
        private TextBox lastnamebox;
        private Label lastname;
        private TextBox firstnamebox;
        private Label adduser;
        private Label fristname;
        private TableLayoutPanel tableLayoutPanel1;
    }
}