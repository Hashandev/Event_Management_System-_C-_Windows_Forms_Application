using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class loging : Form
    {
        string connectionString = "server=localhost;database=EventDecorationDB;uid=root;pwd=;";

        public loging()
        {
            InitializeComponent();
            SetupFormStyles();
        }

        private void SetupFormStyles()
        {
            // Set form properties
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "Login - Event Decoration";

            // Setup picture box with placeholder image
            SetupPictureBox();

            // Setup textboxes with placeholder text
            SetupTextBoxes();

            // Style the login button
            StyleLoginButton();
        }

        private void SetupPictureBox()
        {
            // Create a placeholder image for the picture box
            Bitmap placeholderImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(placeholderImage))
            {
                // Gradient background
                Rectangle rect = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
                LinearGradientBrush gradient = new LinearGradientBrush(
                    rect,
                    Color.FromArgb(41, 55, 72),
                    Color.FromArgb(52, 73, 94),
                    LinearGradientMode.Vertical
                );
                g.FillRectangle(gradient, rect);

                // Draw decoration icon
                Pen whitePen = new Pen(Color.White, 3);
                Pen lightPen = new Pen(Color.FromArgb(189, 195, 199), 2);
                Font iconFont = new Font("Segoe UI", 48, FontStyle.Bold);
                Brush whiteBrush = new SolidBrush(Color.White);
                Brush lightBrush = new SolidBrush(Color.FromArgb(189, 195, 199));

                // Draw decorative elements
                int centerX = pictureBox1.Width / 2;
                int centerY = pictureBox1.Height / 2 - 20;

                // Draw a ribbon/decoration symbol
                g.DrawString("✦", new Font("Segoe UI", 72, FontStyle.Bold),
                    whiteBrush, new PointF(centerX - 40, centerY - 60));

                // Draw circles
                g.DrawEllipse(whitePen, centerX - 60, centerY - 40, 120, 120);
                g.DrawEllipse(lightPen, centerX - 50, centerY - 30, 100, 100);

                // Draw text
                g.DrawString("EVENT", new Font("Segoe UI", 18, FontStyle.Bold),
                    whiteBrush, new PointF(centerX - 60, centerY + 70));
                g.DrawString("DECORATION", new Font("Segoe UI", 14, FontStyle.Regular),
                    lightBrush, new PointF(centerX - 70, centerY + 100));
            }
            pictureBox1.Image = placeholderImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void SetupTextBoxes()
        {
            // Style username textbox
            txtUsername.BackColor = Color.FromArgb(245, 247, 249);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.ForeColor = Color.DimGray;
            txtUsername.Text = "Enter your username";
            txtUsername.Enter += TxtUsername_Enter;
            txtUsername.Leave += TxtUsername_Leave;

            // Style password textbox
            txtPassword.BackColor = Color.FromArgb(245, 247, 249);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Text = "Enter your password";
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.Enter += TxtPassword_Enter;
            txtPassword.Leave += TxtPassword_Leave;
        }

        private void StyleLoginButton()
        {
            logingbutton.BackColor = Color.FromArgb(41, 55, 72);
            logingbutton.FlatStyle = FlatStyle.Flat;
            logingbutton.FlatAppearance.BorderSize = 0;
            logingbutton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            logingbutton.ForeColor = Color.White;
            logingbutton.Size = new Size(263, 45);
            logingbutton.Location = new Point(494, 300);
            logingbutton.Cursor = Cursors.Hand;
            logingbutton.MouseEnter += Logingbutton_MouseEnter;
            logingbutton.MouseLeave += Logingbutton_MouseLeave;

            // Update form controls layout
            UpdateFormLayout();
        }

        private void UpdateFormLayout()
        {
            // Update labels to be more modern
            username.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            username.ForeColor = Color.FromArgb(41, 55, 72);
            username.Location = new Point(494, 125);

            password.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            password.ForeColor = Color.FromArgb(41, 55, 72);
            password.Location = new Point(494, 206);

            // Update "LOGIN HERE" label
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 55, 72);
            label1.Location = new Point(540, 40);
            label1.Text = "Welcome Back!";
            label1.Size = new Size(200, 32);

            // Change form background
            this.BackColor = Color.FromArgb(236, 240, 241);

            // Update picture box position
            pictureBox1.Location = new Point(30, 30);
            pictureBox1.Size = new Size(400, 400);
        }

        // Textbox event handlers
        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter your username")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void TxtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Enter your username";
                txtUsername.ForeColor = Color.DimGray;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter your password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Enter your password";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        // Button hover effects
        private void Logingbutton_MouseEnter(object sender, EventArgs e)
        {
            logingbutton.BackColor = Color.FromArgb(52, 73, 94);
        }

        private void Logingbutton_MouseLeave(object sender, EventArgs e)
        {
            logingbutton.BackColor = Color.FromArgb(41, 55, 72);
        }

        private void loging_Load(object sender, EventArgs e)
        {
            // Load event - password char is handled by placeholder logic
        }

        private void logingbutton_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Check if fields are empty or contain placeholder text
            if (username == "" || username == "Enter your username" ||
                password == "" || password == "Enter your password")
            {
                MessageBox.Show("Please enter username and password.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Login Successful!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dashboard frm = new dashboard();
                        frm.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password!",
                            "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Reset password field
                        txtPassword.Text = "Enter your password";
                        txtPassword.ForeColor = Color.DimGray;
                        txtPassword.UseSystemPasswordChar = false;
                        txtPassword.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}