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
    public partial class staff : Form
    {
        string connectionString = "server=localhost;database=EventDecorationDB;uid=root;pwd=;";
        private string currentStaffId = "";
        private bool isNewStaff = true;

        public staff()
        {
            InitializeComponent();

            // Setup DataGridView for Staff
            if (dataGridView1 != null)
            {
                dataGridView1.ReadOnly = true;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            }

            // CONNECT BUTTONS - THIS IS WHAT MAKES THEM WORK
            if (add != null)
            {
                add.Click += new EventHandler(add_Click);
            }
            if (update != null)
            {
                update.Click += new EventHandler(update_Click);
            }
            if (delete != null)
            {
                delete.Click += new EventHandler(delete_Click);
            }
            if (clear != null)
            {
                clear.Click += new EventHandler(clear_Click);
            }
            if (assign != null)
            {
                assign.Click += new EventHandler(assign_Click);
            }

            LoadStaff();
            LoadPositions();
            LoadEventComboBox();
            LoadStaffComboBox();
            ClearFields();
        }

        // ==================== LOAD DATA METHODS ====================

        private void LoadStaff()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT * FROM Staff ORDER BY StaffID";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPositions()
        {
            try
            {
                if (positionbox != null)
                {
                    positionbox.Items.Clear();
                    positionbox.Items.Add("Event Manager");
                    positionbox.Items.Add("Coordinator");
                    positionbox.Items.Add("Photographer");
                    positionbox.Items.Add("Videographer");
                    positionbox.Items.Add("Decorator");
                    positionbox.Items.Add("Caterer");
                    positionbox.Items.Add("DJ / Sound Operator");
                    positionbox.Items.Add("Security Officer");
                    positionbox.Items.Add("Receptionist");
                    positionbox.Items.Add("Driver");
                    positionbox.Items.Add("Waiter");
                    positionbox.Items.Add("Cleaner");
                    positionbox.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading positions: " + ex.Message);
            }
        }

        private void LoadEventComboBox()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT BookingID FROM Bookings ORDER BY BookingID";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (eventidbox != null)
                    {
                        eventidbox.DisplayMember = "BookingID";
                        eventidbox.ValueMember = "BookingID";
                        eventidbox.DataSource = dt;
                        eventidbox.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading events: " + ex.Message);
            }
        }

        private void LoadStaffComboBox()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT StaffID, FullName FROM Staff ORDER BY FullName";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // FIX: Changed comboBox4 to staffComboBox
                    if (staffComboBox != null)
                    {
                        staffComboBox.DisplayMember = "FullName";
                        staffComboBox.ValueMember = "StaffID";
                        staffComboBox.DataSource = dt;
                        staffComboBox.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff for assignment: " + ex.Message);
            }
        }

        // ==================== CLEAR FIELDS ====================

        private void ClearFields()
        {
            if (staffidbox != null) staffidbox.Clear();
            if (fullnamebox != null) fullnamebox.Clear();
            if (positionbox != null) positionbox.SelectedIndex = -1;
            if (emailbox != null) emailbox.Clear();
            if (mobilenumberbox != null) mobilenumberbox.Clear();
            if (addressbox != null) addressbox.Clear();
            if (eventidbox != null) eventidbox.SelectedIndex = -1;

            // FIX: Changed comboBox4 to staffComboBox
            if (staffComboBox != null) staffComboBox.SelectedIndex = -1;

            currentStaffId = "";
            isNewStaff = true;
            if (staffidbox != null)
            {
                staffidbox.Enabled = true;
                staffidbox.BackColor = System.Drawing.Color.White;
            }

            if (dataGridView1 != null)
            {
                dataGridView1.ClearSelection();
            }
        }

        // ==================== VALIDATION METHODS ====================

        private bool ValidateFields()
        {
            // StaffID - Required (varchar(20))
            if (staffidbox == null || string.IsNullOrWhiteSpace(staffidbox.Text))
            {
                MessageBox.Show("Staff ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (staffidbox != null) staffidbox.Focus();
                return false;
            }

            if (staffidbox.Text.Length > 20)
            {
                MessageBox.Show("Staff ID cannot exceed 20 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                staffidbox.Focus();
                staffidbox.SelectAll();
                return false;
            }

            // FullName - Required (varchar(100))
            if (fullnamebox == null || string.IsNullOrWhiteSpace(fullnamebox.Text))
            {
                MessageBox.Show("Full Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (fullnamebox != null) fullnamebox.Focus();
                return false;
            }

            if (fullnamebox.Text.Length > 100)
            {
                MessageBox.Show("Full Name cannot exceed 100 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fullnamebox.Focus();
                fullnamebox.SelectAll();
                return false;
            }

            // Position - Required (varchar(50))
            if (positionbox == null || positionbox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(positionbox.Text))
            {
                MessageBox.Show("Please select a Position.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (positionbox != null) positionbox.Focus();
                return false;
            }

            if (positionbox.Text.Length > 50)
            {
                MessageBox.Show("Position cannot exceed 50 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                positionbox.Focus();
                positionbox.SelectAll();
                return false;
            }

            // Email - Optional (varchar(100))
            if (emailbox != null && !string.IsNullOrWhiteSpace(emailbox.Text))
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

            // MobileNumber - Required (varchar(15))
            if (mobilenumberbox == null || string.IsNullOrWhiteSpace(mobilenumberbox.Text))
            {
                MessageBox.Show("Mobile Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (mobilenumberbox != null) mobilenumberbox.Focus();
                return false;
            }

            if (mobilenumberbox.Text.Length > 15)
            {
                MessageBox.Show("Mobile Number cannot exceed 15 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mobilenumberbox.Focus();
                mobilenumberbox.SelectAll();
                return false;
            }

            // Address - Optional (varchar(255))
            if (addressbox != null && !string.IsNullOrWhiteSpace(addressbox.Text))
            {
                if (addressbox.Text.Length > 255)
                {
                    MessageBox.Show("Address cannot exceed 255 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    addressbox.Focus();
                    addressbox.SelectAll();
                    return false;
                }
            }

            return true;
        }

        private bool CheckStaffExists(string staffId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM Staff WHERE StaffID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", staffId.Trim());
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking staff: " + ex.Message);
                return false;
            }
        }

        private bool CheckAssignmentExists(string eventId, string staffId)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM AssignedStaff WHERE EventID = @event AND StaffID = @staff";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@event", eventId.Trim());
                    cmd.Parameters.AddWithValue("@staff", staffId.Trim());
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking assignment: " + ex.Message);
                return false;
            }
        }

        // ==================== STAFF CRUD OPERATIONS ====================

        // ADD STAFF
        private void add_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            if (CheckStaffExists(staffidbox.Text.Trim()))
            {
                MessageBox.Show("Staff ID already exists. Please use a different ID.",
                    "Duplicate ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                staffidbox.Focus();
                staffidbox.SelectAll();
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO Staff
                            (StaffID, FullName, Position, Email, MobileNumber, Address)
                            VALUES
                            (@id, @name, @position, @email, @mobile, @address)";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", staffidbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", fullnamebox.Text.Trim());
                    cmd.Parameters.AddWithValue("@position", positionbox.Text.Trim());

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

                    MessageBox.Show("Staff Member Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStaff();
                    LoadStaffComboBox();
                    ClearFields();
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Staff ID already exists. Please use a different ID.",
                        "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding staff member: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // UPDATE STAFF
        private void update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(staffidbox.Text))
            {
                MessageBox.Show("Please select a staff member to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateFields())
                return;

            if (!CheckStaffExists(staffidbox.Text.Trim()))
            {
                MessageBox.Show("Staff ID not found. Please add the staff member first.",
                    "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"UPDATE Staff
                            SET FullName = @name,
                                Position = @position,
                                Email = @email,
                                MobileNumber = @mobile,
                                Address = @address
                            WHERE StaffID = @id";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@id", staffidbox.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", fullnamebox.Text.Trim());
                    cmd.Parameters.AddWithValue("@position", positionbox.Text.Trim());

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
                        MessageBox.Show("Staff Member Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStaff();
                        LoadStaffComboBox();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("No staff member found with the specified ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating staff member: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DELETE STAFF
        private void delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(staffidbox.Text))
            {
                MessageBox.Show("Please select a staff member to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CheckStaffExists(staffidbox.Text.Trim()))
            {
                MessageBox.Show("Staff ID not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                $"Are you sure you want to delete staff member {staffidbox.Text.Trim()} - {fullnamebox.Text}?",
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

                    string query = "DELETE FROM Staff WHERE StaffID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", staffidbox.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Staff Member Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStaff();
                        LoadStaffComboBox();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("No staff member found with the specified ID.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show("Cannot delete this staff member because they are assigned to events.",
                        "Delete Restricted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting staff member: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CLEAR STAFF FIELDS
        private void clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // ==================== STAFF ASSIGNMENT OPERATIONS ====================

        // ASSIGN STAFF TO EVENT
        private void assign_Click(object sender, EventArgs e)
        {
            if (eventidbox == null || eventidbox.SelectedValue == null || string.IsNullOrWhiteSpace(eventidbox.SelectedValue.ToString()))
            {
                MessageBox.Show("Please select an Event.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (eventidbox != null) eventidbox.Focus();
                return;
            }

            // FIX: Changed comboBox4 to staffComboBox
            if (staffComboBox == null || staffComboBox.SelectedValue == null || string.IsNullOrWhiteSpace(staffComboBox.SelectedValue.ToString()))
            {
                MessageBox.Show("Please select a Staff Member.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (staffComboBox != null) staffComboBox.Focus();
                return;
            }

            string eventId = eventidbox.SelectedValue.ToString();
            // FIX: Changed comboBox4 to staffComboBox
            string staffId = staffComboBox.SelectedValue.ToString();

            if (CheckAssignmentExists(eventId, staffId))
            {
                MessageBox.Show("This staff member is already assigned to this event.",
                    "Duplicate Assignment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"INSERT INTO AssignedStaff
                            (EventID, StaffID)
                            VALUES
                            (@event, @staff)";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@event", eventId);
                    cmd.Parameters.AddWithValue("@staff", staffId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Staff Assigned Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAssignedStaff();
                    eventidbox.SelectedIndex = -1;
                    // FIX: Changed comboBox4 to staffComboBox
                    staffComboBox.SelectedIndex = -1;
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1452)
                {
                    MessageBox.Show("Invalid Event ID or Staff ID. Please check and try again.",
                        "Foreign Key Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAssignedStaff()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT a.*, 
                                    s.FullName, s.Position
                                    FROM AssignedStaff a
                                    LEFT JOIN Staff s ON a.StaffID = s.StaffID
                                    ORDER BY a.AssignID";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assigned staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== DATAGRIDVIEW EVENTS ====================

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    if (row.Cells["StaffID"].Value != null)
                    {
                        staffidbox.Text = row.Cells["StaffID"].Value.ToString();
                        fullnamebox.Text = row.Cells["FullName"].Value?.ToString() ?? "";

                        string position = row.Cells["Position"].Value?.ToString() ?? "";
                        if (!string.IsNullOrEmpty(position))
                        {
                            positionbox.Text = position;
                        }
                        else
                        {
                            positionbox.SelectedIndex = -1;
                        }

                        emailbox.Text = row.Cells["Email"].Value?.ToString() ?? "";
                        mobilenumberbox.Text = row.Cells["MobileNumber"].Value?.ToString() ?? "";
                        addressbox.Text = row.Cells["Address"].Value?.ToString() ?? "";

                        currentStaffId = staffidbox.Text;
                        isNewStaff = false;

                        staffidbox.Enabled = false;
                        staffidbox.BackColor = System.Drawing.Color.LightGray;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting staff member: " + ex.Message);
            }
        }

        // ==================== NAVIGATION MENU ITEMS ====================

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
            LoadStaff();
        }

        // ==================== OTHER EVENT HANDLERS ====================

        private void staff_Load(object sender, EventArgs e)
        {
            LoadStaff();
            LoadPositions();
            LoadEventComboBox();
            LoadStaffComboBox();
        }

        private void sfaffmanagement_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void customer_FormClosing(object sender, FormClosingEventArgs e) { }

        private void sfaffmanagement_Click_1(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports reports=new reports();
            reports.Show();
            this.Close();
        }
    }
}