using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class dashboard : Form
    {
        // *** ඔබගේ Database Name එක හරි ගන්න ***
        string connectionString = "server=localhost;database=eventdecoratondb;uid=root;pwd=;";

        public dashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadDashboardData();
            SetupDashboardStyles();
        }

        private void SetupDashboardStyles()
        {
            // Set form properties
            this.Text = "Dashboard - Event Decoration Management";
            this.BackColor = Color.MidnightBlue;

            // Style the menu strip - White Background with Black Text
            menuStrip1.BackColor = Color.White;
            menuStrip1.ForeColor = Color.Black;
            menuStrip1.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            // Style menu items
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.ForeColor = Color.Black;
                item.BackColor = Color.White;
                item.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                item.MouseEnter += (s, e) => { item.BackColor = Color.FromArgb(240, 240, 240); };
                item.MouseLeave += (s, e) => { item.BackColor = Color.White; };
            }

            // Style panel1 with Midnight Blue background
            panel1.BackColor = Color.MidnightBlue;
            panel1.Padding = new Padding(30);

            // Style the cards
            StyleCard(labelCustomers, cus, Color.FromArgb(52, 152, 219), 30, 30);
            StyleCard(labelBookings, boo, Color.FromArgb(46, 204, 113), 260, 30);
            StyleCard(labelPackages, pac, Color.FromArgb(155, 89, 182), 490, 30);
            StyleCard(labelStaff, sta, Color.FromArgb(231, 76, 60), 720, 30);
        }

        private void StyleCard(Label titleLabel, Label valueLabel, Color color, int x, int y)
        {
            // Create a panel for each card
            Panel cardPanel = new Panel
            {
                BackColor = Color.White,
                Size = new Size(200, 160),
                Location = new Point(x, y),
                BorderStyle = BorderStyle.None,
                Padding = new Padding(15)
            };

            // Add border
            cardPanel.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, cardPanel.ClientRectangle,
                    Color.FromArgb(200, 200, 200), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(200, 200, 200), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(200, 200, 200), 1, ButtonBorderStyle.Solid,
                    Color.FromArgb(200, 200, 200), 1, ButtonBorderStyle.Solid);
            };

            // Move title label inside card
            titleLabel.Location = new Point(15, 15);
            titleLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            titleLabel.ForeColor = Color.FromArgb(44, 62, 80);
            titleLabel.Text = titleLabel.Text;
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;

            // Style value label
            valueLabel.Location = new Point(15, 60);
            valueLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            valueLabel.ForeColor = color;
            valueLabel.TextAlign = ContentAlignment.MiddleCenter;
            valueLabel.AutoSize = false;
            valueLabel.Size = new Size(170, 60);

            // Add a colored line on top of card
            Panel colorBar = new Panel
            {
                BackColor = color,
                Size = new Size(200, 5),
                Location = new Point(0, 0)
            };

            // Add controls to card
            cardPanel.Controls.Add(colorBar);
            cardPanel.Controls.Add(titleLabel);
            cardPanel.Controls.Add(valueLabel);

            // Add card to panel
            panel1.Controls.Add(cardPanel);

            // Remove old labels from panel
            panel1.Controls.Remove(titleLabel);
            panel1.Controls.Remove(valueLabel);

            // Add hover effect
            cardPanel.MouseEnter += (s, e) =>
            {
                cardPanel.BackColor = Color.FromArgb(248, 249, 250);
                cardPanel.Size = new Size(205, 165);
            };
            cardPanel.MouseLeave += (s, e) =>
            {
                cardPanel.BackColor = Color.White;
                cardPanel.Size = new Size(200, 160);
            };
        }

        private void LoadDashboardData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    // Total Customers
                    string queryCus = "SELECT COUNT(*) FROM Customers";
                    MySqlCommand cmdCus = new MySqlCommand(queryCus, con);
                    int totalCus = Convert.ToInt32(cmdCus.ExecuteScalar());
                    cus.Text = totalCus.ToString();

                    // Total Bookings
                    string queryBoo = "SELECT COUNT(*) FROM Bookings";
                    MySqlCommand cmdBoo = new MySqlCommand(queryBoo, con);
                    int totalBoo = Convert.ToInt32(cmdBoo.ExecuteScalar());
                    boo.Text = totalBoo.ToString();

                    // Total Packages
                    string queryPac = "SELECT COUNT(*) FROM Packages";
                    MySqlCommand cmdPac = new MySqlCommand(queryPac, con);
                    int totalPac = Convert.ToInt32(cmdPac.ExecuteScalar());
                    pac.Text = totalPac.ToString();

                    // Total Staff
                    string querySta = "SELECT COUNT(*) FROM Staff";
                    MySqlCommand cmdSta = new MySqlCommand(querySta, con);
                    int totalSta = Convert.ToInt32(cmdSta.ExecuteScalar());
                    sta.Text = totalSta.ToString();

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Navigation Menu Items
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer customer = new customer();
            customer.Show();
            this.Hide();
        }

        private void packagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Package packages = new Package();
            packages.Show();
            this.Hide();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.Show();
            this.Hide();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff staff = new staff();
            staff.Show();
            this.Hide();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventory inv = new inventory();
            inv.Show();
            this.Hide();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           reports reports= new reports();
            reports.Show();
            this.Close();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}