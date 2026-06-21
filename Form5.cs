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
    public partial class Booking : Form
    {
        string connectionString = "server=localhost;database=EventDecorationDB;uid=root;pwd=;";
        private string currentBookingId = "";
        private bool isNewBooking = true;

        public Booking()
        {
            InitializeComponent();

            // Setup DataGridView
            if (dataGridView1 != null)
            {
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            }

            LoadBookings();
            ClearFields();
            LoadPackageComboBox();
            LoadPaymentStatus();

            // Attach event to calculate balance
            txtAdvance.TextChanged += new EventHandler(txtAdvance_TextChanged);
            txtTotalAmount.TextChanged += new EventHandler(txtTotalAmount_TextChanged);
        }

        private void LoadBookings()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT b.*, 
                                    c.FirstName, c.LastName, 
                                    p.PackageName 
                                    FROM Bookings b
                                    LEFT JOIN Customers c ON b.CustomerID = c.CustomerID
                                    LEFT JOIN Packages p ON b.PackageID = p.PackageID
                                    ORDER BY b.BookingID";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPackageComboBox()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT PackageID, PackageName FROM Packages ORDER BY PackageName";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbPackageID.DisplayMember = "PackageName";
                    cmbPackageID.ValueMember = "PackageID";
                    cmbPackageID.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading packages: " + ex.Message);
            }
        }

        private void LoadPaymentStatus()
        {
            cmbPaymentStatus.Items.Clear();
            cmbPaymentStatus.Items.Add("Paid");
            cmbPaymentStatus.Items.Add("Pending");
            cmbPaymentStatus.Items.Add("Partial");
        }

        private void CalculateBalance()
        {
            try
            {
                decimal totalAmount = 0;
                decimal advance = 0;
                decimal balance = 0;

                if (!string.IsNullOrWhiteSpace(txtTotalAmount.Text))
                {
                    decimal.TryParse(txtTotalAmount.Text, out totalAmount);
                }

                if (!string.IsNullOrWhiteSpace(txtAdvance.Text))
                {
                    decimal.TryParse(txtAdvance.Text, out advance);
                }

                balance = totalAmount - advance;
                txtBalance.Text = balance.ToString("0.00");

                if (balance == 0 && totalAmount > 0)
                {
                    cmbPaymentStatus.SelectedItem = "Paid";
                }
                else if (advance > 0 && balance > 0)
                {
                    cmbPaymentStatus.SelectedItem = "Partial";
                }
                else if (advance == 0 && totalAmount > 0)
                {
                    cmbPaymentStatus.SelectedItem = "Pending";
                }
            }
            catch (Exception ex)
            {
                // Ignore calculation errors
            }
        }

        private void txtAdvance_TextChanged(object sender, EventArgs e)
        {
            CalculateBalance();
        }

        private void txtTotalAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateBalance();
        }

        private void ClearFields()
        {
            txtBookingID.Clear();
            txtCustomerID.Clear();
            cmbPackageID.SelectedIndex = -1;
            dtpEventDate.Value = DateTime.Now;
            dtpEventTime.Value = DateTime.Now;
            txtMobileNumber.Clear();
            txtTotalAmount.Clear();
            txtAdvance.Clear();
            txtBalance.Text = "0.00";
            cmbPaymentStatus.SelectedIndex = -1;

            currentBookingId = "";
            isNewBooking = true;
            txtBookingID.Enabled = true;
            txtBookingID.BackColor = System.Drawing.Color.White;
            txtCustomerID.Enabled = true;
            txtCustomerID.BackColor = System.Drawing.Color.White;

            if (dataGridView1 != null)
            {
                dataGridView1.ClearSelection();
            }
        }

        private bool ValidateCustomerExists(string customerId)
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
                MessageBox.Show("Error validating customer: " + ex.Message);
                return false;
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtBookingID.Text))
            {
                MessageBox.Show("Booking ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookingID.Focus();
                return false;
            }

            if (txtBookingID.Text.Length > 20)
            {
                MessageBox.Show("Booking ID cannot exceed 20 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookingID.Focus();
                txtBookingID.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCustomerID.Text))
            {
                MessageBox.Show("Customer ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerID.Focus();
                return false;
            }

            if (txtCustomerID.Text.Length > 20)
            {
                MessageBox.Show("Customer ID cannot exceed 20 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerID.Focus();
                txtCustomerID.SelectAll();
                return false;
            }

            if (!ValidateCustomerExists(txtCustomerID.Text.Trim()))
            {
                MessageBox.Show("Customer ID does not exist. Please enter a valid Customer ID.",
                    "Invalid Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustomerID.Focus();
                txtCustomerID.SelectAll();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtMobileNumber.Text) && txtMobileNumber.Text.Length > 15)
            {
                MessageBox.Show("Mobile Number cannot exceed 15 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMobileNumber.Focus();
                txtMobileNumber.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTotalAmount.Text))
            {
                MessageBox.Show("Total Amount is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalAmount.Focus();
                return false;
            }

            decimal amount;
            if (!decimal.TryParse(txtTotalAmount.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount (numeric value).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalAmount.Focus();
                txtTotalAmount.SelectAll();
                return false;
            }

            if (amount < 0)
            {
                MessageBox.Show("Total Amount cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalAmount.Focus();
                txtTotalAmount.SelectAll();
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtAdvance.Text))
            {
                decimal advance;
                if (!decimal.TryParse(txtAdvance.Text, out advance))
                {
                    MessageBox.Show("Please enter a valid advance amount (numeric value).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAdvance.Focus();
                    txtAdvance.SelectAll();
                    return false;
                }

                if (advance < 0)
                {
                    MessageBox.Show("Advance cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAdvance.Focus();
                    txtAdvance.SelectAll();
                    return false;
                }

                if (advance > amount)
                {
                    MessageBox.Show("Advance cannot be greater than Total Amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAdvance.Focus();
                    txtAdvance.SelectAll();
                    return false;
                }
            }

            if (cmbPaymentStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Payment Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPaymentStatus.Focus();
                return false;
            }

            return true;
        }

        private bool CheckBookingExists(string bookingId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Bookings WHERE BookingID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", bookingId.Trim());
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking booking: " + ex.Message);
                return false;
            }
        }

        // ADD BUTTON
        private void add_Click_1(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            if (CheckBookingExists(txtBookingID.Text.Trim()))
            {
                MessageBox.Show("Booking ID already exists. Please use a different ID.",
                    "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookingID.Focus();
                txtBookingID.SelectAll();
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO Bookings
                            (BookingID, CustomerID, PackageID, EventDate, EventTime, 
                             MobileNumber, TotalAmount, Advance, PaymentStatus)
                            VALUES
                            (@id, @customer, @package, @eventdate, @eventtime, 
                             @mobile, @amount, @advance, @status)";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", txtBookingID.Text.Trim());
                    cmd.Parameters.AddWithValue("@customer", txtCustomerID.Text.Trim());

                    if (cmbPackageID.SelectedValue == null || string.IsNullOrWhiteSpace(cmbPackageID.SelectedValue.ToString()))
                        cmd.Parameters.AddWithValue("@package", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@package", cmbPackageID.SelectedValue.ToString());

                    cmd.Parameters.AddWithValue("@eventdate", dtpEventDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@eventtime", dtpEventTime.Value.ToString("HH:mm:ss"));

                    if (string.IsNullOrWhiteSpace(txtMobileNumber.Text))
                        cmd.Parameters.AddWithValue("@mobile", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@mobile", txtMobileNumber.Text.Trim());

                    cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(txtTotalAmount.Text.Trim()));

                    if (string.IsNullOrWhiteSpace(txtAdvance.Text))
                        cmd.Parameters.AddWithValue("@advance", 0.00);
                    else
                        cmd.Parameters.AddWithValue("@advance", Convert.ToDecimal(txtAdvance.Text.Trim()));

                    cmd.Parameters.AddWithValue("@status", cmbPaymentStatus.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Booking Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookings();
                    ClearFields();
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Booking ID already exists. Please use a different ID.",
                        "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Number == 1452)
                {
                    MessageBox.Show("Invalid Customer ID or Package ID. Please check and try again.",
                        "Foreign Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // UPDATE BUTTON
        private void update_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookingID.Text))
            {
                MessageBox.Show("Please select a booking to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateFields())
                return;

            if (!CheckBookingExists(txtBookingID.Text.Trim()))
            {
                MessageBox.Show("Booking ID not found. Please add the booking first.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"UPDATE Bookings
                            SET CustomerID = @customer,
                                PackageID = @package,
                                EventDate = @eventdate,
                                EventTime = @eventtime,
                                MobileNumber = @mobile,
                                TotalAmount = @amount,
                                Advance = @advance,
                                PaymentStatus = @status
                            WHERE BookingID = @id";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", txtBookingID.Text.Trim());
                    cmd.Parameters.AddWithValue("@customer", txtCustomerID.Text.Trim());

                    if (cmbPackageID.SelectedValue == null || string.IsNullOrWhiteSpace(cmbPackageID.SelectedValue.ToString()))
                        cmd.Parameters.AddWithValue("@package", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@package", cmbPackageID.SelectedValue.ToString());

                    cmd.Parameters.AddWithValue("@eventdate", dtpEventDate.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@eventtime", dtpEventTime.Value.ToString("HH:mm:ss"));

                    if (string.IsNullOrWhiteSpace(txtMobileNumber.Text))
                        cmd.Parameters.AddWithValue("@mobile", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@mobile", txtMobileNumber.Text.Trim());

                    cmd.Parameters.AddWithValue("@amount", Convert.ToDecimal(txtTotalAmount.Text.Trim()));

                    if (string.IsNullOrWhiteSpace(txtAdvance.Text))
                        cmd.Parameters.AddWithValue("@advance", 0.00);
                    else
                        cmd.Parameters.AddWithValue("@advance", Convert.ToDecimal(txtAdvance.Text.Trim()));

                    cmd.Parameters.AddWithValue("@status", cmbPaymentStatus.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Booking Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBookings();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("No booking found with the specified ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1452)
                {
                    MessageBox.Show("Invalid Customer ID or Package ID. Please check and try again.",
                        "Foreign Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DELETE BUTTON
        private void delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookingID.Text))
            {
                MessageBox.Show("Please select a booking to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckBookingExists(txtBookingID.Text.Trim()))
            {
                MessageBox.Show("Booking ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                $"Are you sure you want to delete booking {txtBookingID.Text.Trim()}?",
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

                    string query = "DELETE FROM Bookings WHERE BookingID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", txtBookingID.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Booking Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBookings();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("No booking found with the specified ID.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show("Cannot delete this booking because it has related records in other tables.",
                        "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting booking: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CLEAR BUTTON
        private void clear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        // SEARCH FUNCTION
        private void searchcustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    LoadBookings();
                    return;
                }

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT b.*, 
                                    c.FirstName, c.LastName, 
                                    p.PackageName 
                                    FROM Bookings b
                                    LEFT JOIN Customers c ON b.CustomerID = c.CustomerID
                                    LEFT JOIN Packages p ON b.PackageID = p.PackageID
                                    WHERE b.BookingID LIKE @search
                                    OR b.CustomerID LIKE @search
                                    OR b.PackageID LIKE @search
                                    OR c.FirstName LIKE @search
                                    OR c.LastName LIKE @search
                                    OR p.PackageName LIKE @search
                                    ORDER BY b.BookingID";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No bookings found matching your search.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching bookings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    if (row.Cells["BookingID"].Value != null)
                    {
                        txtBookingID.Text = row.Cells["BookingID"].Value.ToString();
                        txtCustomerID.Text = row.Cells["CustomerID"].Value?.ToString() ?? "";

                        string packageID = row.Cells["PackageID"].Value?.ToString() ?? "";
                        if (!string.IsNullOrEmpty(packageID))
                        {
                            cmbPackageID.SelectedValue = packageID;
                        }
                        else
                        {
                            cmbPackageID.SelectedIndex = -1;
                        }

                        if (row.Cells["EventDate"].Value != null && row.Cells["EventDate"].Value != DBNull.Value)
                        {
                            dtpEventDate.Value = Convert.ToDateTime(row.Cells["EventDate"].Value);
                        }

                        if (row.Cells["EventTime"].Value != null && row.Cells["EventTime"].Value != DBNull.Value)
                        {
                            dtpEventTime.Value = Convert.ToDateTime(row.Cells["EventTime"].Value);
                        }

                        txtMobileNumber.Text = row.Cells["MobileNumber"].Value?.ToString() ?? "";
                        txtTotalAmount.Text = row.Cells["TotalAmount"].Value?.ToString() ?? "";
                        txtAdvance.Text = row.Cells["Advance"].Value?.ToString() ?? "0.00";

                        CalculateBalance();

                        string paymentStatus = row.Cells["PaymentStatus"].Value?.ToString() ?? "";
                        if (!string.IsNullOrEmpty(paymentStatus))
                        {
                            cmbPaymentStatus.Text = paymentStatus;
                        }

                        currentBookingId = txtBookingID.Text;
                        isNewBooking = false;

                        txtBookingID.Enabled = false;
                        txtBookingID.BackColor = System.Drawing.Color.LightGray;
                        txtCustomerID.Enabled = false;
                        txtCustomerID.BackColor = System.Drawing.Color.LightGray;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting booking: " + ex.Message);
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
            customer customer = new customer();
            customer.Show();
            this.Hide();
        }

        private void packagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Package package = new Package();
            package.Show();
            this.Hide();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff staff = new staff();
            staff.Show();
            this.Hide();
        }

        // OTHER EVENT HANDLERS
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void customer_FormClosing(object sender, FormClosingEventArgs e) { }

        // LOAD EVENT
        private void Booking_Load(object sender, EventArgs e)
        {
            LoadBookings();
            LoadPackageComboBox();
            LoadPaymentStatus();
            ClearFields();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports reports= new reports();
            reports.Show();
            this.Close();
        }
    }
}