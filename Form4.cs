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
    public partial class Package : Form
    {
        string connectionString = "server=localhost;database=EventDecorationDB;uid=root;pwd=;";
        private string currentPackageId = "";
        private bool isNewPackage = true;

        public Package()
        {
            InitializeComponent();

            // Make DataGridView ReadOnly
            if (dataGridView2 != null)
            {
                dataGridView2.ReadOnly = true;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView2.MultiSelect = false;
                dataGridView2.CellClick += new DataGridViewCellEventHandler(dataGridView2_CellClick);
            }

            LoadPackages();
            ClearFields();
        }

        // LOAD EVENT
        private void Package_Load(object sender, EventArgs e)
        {
            LoadPackages();
            ClearFields();
        }

        // Load Packages Method
        private void LoadPackages()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Packages ORDER BY PackageID";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;

                    // Update total package count
                    if (txtTotalPackage != null)
                    {
                        txtTotalPackage.Text = dt.Rows.Count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading packages: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtPackageID.Clear();
            txtPackageName.Clear();
            txtPrice.Clear();
            txtPackageItems.Clear();
            txtDescription.Clear();
            txtTotalPackage.Text = "0";

            currentPackageId = "";
            isNewPackage = true;
            txtPackageID.Enabled = true;
            txtPackageID.BackColor = System.Drawing.Color.White;

            if (dataGridView2 != null)
            {
                dataGridView2.ClearSelection();
            }
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtPackageID.Text))
            {
                MessageBox.Show("Package ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPackageID.Focus();
                return false;
            }

            if (txtPackageID.Text.Length > 20)
            {
                MessageBox.Show("Package ID cannot exceed 20 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPackageID.Focus();
                txtPackageID.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPackageName.Text))
            {
                MessageBox.Show("Package Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPackageName.Focus();
                return false;
            }

            if (txtPackageName.Text.Length > 100)
            {
                MessageBox.Show("Package Name cannot exceed 100 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPackageName.Focus();
                txtPackageName.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Price is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            decimal price;
            if (!decimal.TryParse(txtPrice.Text, out price))
            {
                MessageBox.Show("Please enter a valid price (numeric value).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                txtPrice.SelectAll();
                return false;
            }

            if (price < 0)
            {
                MessageBox.Show("Price cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                txtPrice.SelectAll();
                return false;
            }

            return true;
        }

        private bool CheckPackageExists(string packageId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Packages WHERE PackageID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", packageId.Trim());
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking package: " + ex.Message);
                return false;
            }
        }

        // ADD BUTTON
        private void add_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            if (CheckPackageExists(txtPackageID.Text.Trim()))
            {
                MessageBox.Show("Package ID already exists. Please use a different ID.",
                    "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPackageID.Focus();
                txtPackageID.SelectAll();
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO Packages
                            (PackageID, PackageName, Price, PackageItems, Description)
                            VALUES
                            (@id, @name, @price, @items, @desc)";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", txtPackageID.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", txtPackageName.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text.Trim()));

                    if (string.IsNullOrWhiteSpace(txtPackageItems.Text))
                        cmd.Parameters.AddWithValue("@items", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@items", txtPackageItems.Text.Trim());

                    if (string.IsNullOrWhiteSpace(txtDescription.Text))
                        cmd.Parameters.AddWithValue("@desc", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Package Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPackages();
                    ClearFields();
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Package ID already exists. Please use a different ID.",
                        "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding package: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // UPDATE BUTTON
        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPackageID.Text))
            {
                MessageBox.Show("Please select a package to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateFields())
                return;

            if (!CheckPackageExists(txtPackageID.Text.Trim()))
            {
                MessageBox.Show("Package ID not found. Please add the package first.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"UPDATE Packages
                            SET PackageName = @name,
                                Price = @price,
                                PackageItems = @items,
                                Description = @desc
                            WHERE PackageID = @id";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", txtPackageID.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", txtPackageName.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text.Trim()));

                    if (string.IsNullOrWhiteSpace(txtPackageItems.Text))
                        cmd.Parameters.AddWithValue("@items", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@items", txtPackageItems.Text.Trim());

                    if (string.IsNullOrWhiteSpace(txtDescription.Text))
                        cmd.Parameters.AddWithValue("@desc", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Package Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPackages();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("No package found with the specified ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating package: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DELETE BUTTON
        private void delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPackageID.Text))
            {
                MessageBox.Show("Please select a package to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckPackageExists(txtPackageID.Text.Trim()))
            {
                MessageBox.Show("Package ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                $"Are you sure you want to delete package {txtPackageID.Text.Trim()} - {txtPackageName.Text}?",
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

                    string query = "DELETE FROM Packages WHERE PackageID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", txtPackageID.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Package Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPackages();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("No package found with the specified ID.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show("Cannot delete this package because it has related records in other tables.",
                        "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting package: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CLEAR BUTTON
        private void clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // SEARCH BUTTON
        private void searchPackage_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchTerm))
                {
                    LoadPackages();
                    return;
                }

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT *
                             FROM Packages
                             WHERE PackageID LIKE @search
                             OR PackageName LIKE @search
                             OR Price LIKE @search
                             OR PackageItems LIKE @search
                             OR Description LIKE @search";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView2.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No packages found matching your search.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching packages: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DATAGRIDVIEW CELL CLICK
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView2.Rows.Count)
                {
                    DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                    if (row.Cells["PackageID"].Value != null)
                    {
                        txtPackageID.Text = row.Cells["PackageID"].Value.ToString();
                        txtPackageName.Text = row.Cells["PackageName"].Value?.ToString() ?? "";
                        txtPrice.Text = row.Cells["Price"].Value?.ToString() ?? "";
                        txtPackageItems.Text = row.Cells["PackageItems"].Value?.ToString() ?? "";
                        txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? "";

                        currentPackageId = txtPackageID.Text;
                        isNewPackage = false;

                        txtPackageID.Enabled = false;
                        txtPackageID.BackColor = System.Drawing.Color.LightGray;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting package: " + ex.Message);
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
            LoadPackages();
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

        // OTHER EVENT HANDLERS
        private void packagemanagement_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void txtPrice_TextChanged(object sender, EventArgs e) { }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void customer_FormClosing(object sender, FormClosingEventArgs e) { }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports reports= new reports();
            reports.Show();
            this.Close();
        }
    }
}