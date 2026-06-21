using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class customer : Form
    {
        string connectionString = "server=localhost;database=EventDecorationDB;uid=root;pwd=;";
        private string currentCustomerId = "";
        private bool isNewCustomer = true;

        public customer()
        {
            InitializeComponent();
            LoadCustomers();
            ClearFields();

            // Connect CellClick event for DataGridView
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);

            // Set minimum size
            this.MinimumSize = new Size(800, 600);
        }

        private void LoadCustomers()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Customers ORDER BY CustomerID";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            textBox2.Clear();
            firstnamebox.Clear();
            lastnamebox.Clear();
            emailbox.Clear();
            mobilenumberbox.Clear();
            addressbox.Clear();
            textBox1.Clear();
            currentCustomerId = "";
            isNewCustomer = true;
            textBox2.Enabled = true;
            textBox2.BackColor = Color.White;
            dataGridView1.ClearSelection();
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Customer ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return false;
            }

            if (textBox2.Text.Length > 20)
            {
                MessageBox.Show("Customer ID cannot exceed 20 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                textBox2.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(firstnamebox.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstnamebox.Focus();
                return false;
            }

            if (firstnamebox.Text.Length > 50)
            {
                MessageBox.Show("First Name cannot exceed 50 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstnamebox.Focus();
                firstnamebox.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(lastnamebox.Text))
            {
                MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lastnamebox.Focus();
                return false;
            }

            if (lastnamebox.Text.Length > 50)
            {
                MessageBox.Show("Last Name cannot exceed 50 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lastnamebox.Focus();
                lastnamebox.SelectAll();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(emailbox.Text))
            {
                if (emailbox.Text.Length > 100)
                {
                    MessageBox.Show("Email cannot exceed 100 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailbox.Focus();
                    emailbox.SelectAll();
                    return false;
                }

                if (!emailbox.Text.Contains("@") || !emailbox.Text.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailbox.Focus();
                    emailbox.SelectAll();
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(mobilenumberbox.Text))
            {
                MessageBox.Show("Mobile Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mobilenumberbox.Focus();
                return false;
            }

            if (mobilenumberbox.Text.Length > 15)
            {
                MessageBox.Show("Mobile Number cannot exceed 15 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mobilenumberbox.Focus();
                mobilenumberbox.SelectAll();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(addressbox.Text) && addressbox.Text.Length > 255)
            {
                MessageBox.Show("Address cannot exceed 255 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addressbox.Focus();
                addressbox.SelectAll();
                return false;
            }

            return true;
        }

        private bool CheckCustomerExists(string customerId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Customers WHERE CustomerID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", customerId.Trim());
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking customer: " + ex.Message);
                return false;
            }
        }

        // ADD BUTTON - button4
        private void button4_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            if (CheckCustomerExists(textBox2.Text.Trim()))
            {
                MessageBox.Show("Customer ID already exists. Please use a different ID.",
                    "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                textBox2.SelectAll();
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO Customers
                            (CustomerID, FirstName, LastName, Email, MobileNumber, Address)
                            VALUES
                            (@id, @fname, @lname, @email, @mobile, @address)";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@fname", firstnamebox.Text.Trim());
                    cmd.Parameters.AddWithValue("@lname", lastnamebox.Text.Trim());

                    if (string.IsNullOrWhiteSpace(emailbox.Text))
                        cmd.Parameters.AddWithValue("@email", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@email", emailbox.Text.Trim());

                    cmd.Parameters.AddWithValue("@mobile", mobilenumberbox.Text.Trim());

                    if (string.IsNullOrWhiteSpace(addressbox.Text))
                        cmd.Parameters.AddWithValue("@address", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@address", addressbox.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Customer Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomers();
                    ClearFields();
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Customer ID already exists. Please use a different ID.",
                        "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // UPDATE BUTTON - button1
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please select a customer to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateFields())
                return;

            if (!CheckCustomerExists(textBox2.Text.Trim()))
            {
                MessageBox.Show("Customer ID not found. Please add the customer first.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"UPDATE Customers
                            SET FirstName = @fname,
                                LastName = @lname,
                                Email = @email,
                                MobileNumber = @mobile,
                                Address = @address
                            WHERE CustomerID = @id";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", textBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@fname", firstnamebox.Text.Trim());
                    cmd.Parameters.AddWithValue("@lname", lastnamebox.Text.Trim());

                    if (string.IsNullOrWhiteSpace(emailbox.Text))
                        cmd.Parameters.AddWithValue("@email", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@email", emailbox.Text.Trim());

                    cmd.Parameters.AddWithValue("@mobile", mobilenumberbox.Text.Trim());

                    if (string.IsNullOrWhiteSpace(addressbox.Text))
                        cmd.Parameters.AddWithValue("@address", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@address", addressbox.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCustomers();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("No customer found with the specified ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DELETE BUTTON - button2
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please select a customer to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckCustomerExists(textBox2.Text.Trim()))
            {
                MessageBox.Show("Customer ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                $"Are you sure you want to delete customer {textBox2.Text.Trim()} - {firstnamebox.Text} {lastnamebox.Text}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.No)
                return;

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = "DELETE FROM Customers WHERE CustomerID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", textBox2.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCustomers();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("No customer found with the specified ID.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show("Cannot delete this customer because they have related records in other tables.",
                        "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CLEAR BUTTON - button3
        private void button3_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // SEARCH FUNCTION
        private void searchcustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = textBox1.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    LoadCustomers();
                    return;
                }

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT *
                             FROM Customers
                             WHERE CustomerID LIKE @search
                             OR FirstName LIKE @search
                             OR LastName LIKE @search
                             OR Email LIKE @search
                             OR MobileNumber LIKE @search
                             OR Address LIKE @search";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No customers found matching your search.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching customers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DATAGRIDVIEW CELL CLICK
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    if (row.Cells["CustomerID"].Value != null)
                    {
                        textBox2.Text = row.Cells["CustomerID"].Value.ToString();
                        firstnamebox.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
                        lastnamebox.Text = row.Cells["LastName"].Value?.ToString() ?? "";
                        emailbox.Text = row.Cells["Email"].Value?.ToString() ?? "";
                        mobilenumberbox.Text = row.Cells["MobileNumber"].Value?.ToString() ?? "";
                        addressbox.Text = row.Cells["Address"].Value?.ToString() ?? "";

                        currentCustomerId = textBox2.Text;
                        isNewCustomer = false;

                        textBox2.Enabled = false;
                        textBox2.BackColor = Color.LightGray;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting customer: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handled by CellClick event above
        }

        // RESIZE EVENT - Makes the form responsive
        private void customer_Resize(object sender, EventArgs e)
        {
            // Scale font size based on form width
            float baseWidth = 1000f;
            float currentWidth = this.ClientSize.Width;
            float scaleFactor = Math.Max(0.6f, Math.Min(1.5f, currentWidth / baseWidth));

            // Scale the title label
            float newFontSize = 20.25f * scaleFactor;
            if (newFontSize >= 10f && newFontSize <= 36f)
            {
                cuslable01.Font = new Font(cuslable01.Font.FontFamily, newFontSize, FontStyle.Bold);
            }

            // Scale the "Add User" label
            float newAddUserSize = 12f * scaleFactor;
            if (newAddUserSize >= 8f && newAddUserSize <= 24f)
            {
                adduser.Font = new Font(adduser.Font.FontFamily, newAddUserSize, FontStyle.Bold);
            }

            // Scale field labels
            float newLabelSize = 9.75f * scaleFactor;
            if (newLabelSize >= 7f && newLabelSize <= 16f)
            {
                foreach (Control control in panel2.Controls)
                {
                    if (control is Label label && control != adduser && control != label1)
                    {
                        label.Font = new Font(label.Font.FontFamily, newLabelSize, FontStyle.Regular);
                    }
                }
            }
        }

        // NAVIGATION MENU ITEMS
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.Show();
            this.Hide();
        }

        private void packagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Package package = new Package();
            package.Show();
            this.Hide();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff staff = new staff();
            staff.Show();
            this.Hide();
        }

        // OTHER EVENT HANDLERS
        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void cuslable01_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void customer_FormClosing(object sender, FormClosingEventArgs e) { }

        private void adduser_Click(object sender, EventArgs e)
        {
            button4_Click(sender, e);
        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void emailbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mobilenumber_Click(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports reports= new reports();
            reports.Show();
            this.Close();
        }
    }
}