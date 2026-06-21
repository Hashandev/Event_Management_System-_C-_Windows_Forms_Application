using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class inventory : Form
    {
        // *** ඔබගේ Database Name එක හරි ගන්න ***
        string connectionString = "server=localhost;database=eventdecorationdb;uid=root;pwd=;";

        public inventory()
        {
            InitializeComponent();
            LoadInventoryData();
            LoadBookings();
            LoadItems();
            LoadBookingItems();
            SetupFormStyles();
        }

        private void SetupFormStyles()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.MidnightBlue;
        }

        private void LoadInventoryData()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT ItemID, ItemName, Quantity FROM Inventory";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvInventory.DataSource = dt;

                    dgvInventory.Columns["ItemID"].HeaderText = "ID";
                    dgvInventory.Columns["ItemName"].HeaderText = "Item Name";
                    dgvInventory.Columns["Quantity"].HeaderText = "Quantity";

                    dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvInventory.BackgroundColor = Color.White;
                    dgvInventory.RowHeadersVisible = false;
                    dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvInventory.AllowUserToAddRows = false;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBookings()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT BookingID, EventType, CustomerID FROM Bookings";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No bookings found in the database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbBooking.DataSource = null;
                        return;
                    }

                    cmbBooking.DataSource = dt;
                    cmbBooking.DisplayMember = "EventType";
                    cmbBooking.ValueMember = "BookingID";
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadItems()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT ItemID, ItemName, Quantity FROM Inventory WHERE Quantity > 0";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbItem.DataSource = dt;
                    cmbItem.DisplayMember = "ItemName";
                    cmbItem.ValueMember = "ItemID";
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBookingItems()
        {
            try
            {
                if (cmbBooking.SelectedValue == null)
                {
                    dgvAssignedItems.DataSource = null;
                    lblAssignedCount.Text = "Assigned Items: 0";
                    return;
                }

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"SELECT bi.BookingItemID, i.ItemName, bi.Quantity 
                                    FROM BookingItems bi 
                                    INNER JOIN Inventory i ON bi.ItemID = i.ItemID 
                                    WHERE bi.BookingID = @bookingID";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@bookingID", cmbBooking.SelectedValue);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvAssignedItems.DataSource = dt;

                    if (dt.Rows.Count > 0)
                    {
                        dgvAssignedItems.Columns["BookingItemID"].HeaderText = "ID";
                        dgvAssignedItems.Columns["ItemName"].HeaderText = "Item Name";
                        dgvAssignedItems.Columns["Quantity"].HeaderText = "Quantity";
                    }

                    dgvAssignedItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvAssignedItems.BackgroundColor = Color.White;
                    dgvAssignedItems.RowHeadersVisible = false;
                    dgvAssignedItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgvAssignedItems.AllowUserToAddRows = false;

                    con.Close();
                    lblAssignedCount.Text = $"Assigned Items: {dt.Rows.Count}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading assigned items: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text.Trim();
            string quantity = txtItemQty.Text.Trim();

            if (string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(quantity))
            {
                MessageBox.Show("Please enter item name and quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(quantity, out int qty) || qty < 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    string query = "INSERT INTO Inventory (ItemName, Quantity) VALUES (@itemName, @quantity)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@itemName", itemName);
                    cmd.Parameters.AddWithValue("@quantity", qty);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtItemName.Clear();
                        txtItemQty.Clear();
                        LoadInventoryData();
                        LoadItems();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAssignItem_Click(object sender, EventArgs e)
        {
            if (cmbBooking.SelectedValue == null)
            {
                MessageBox.Show("Please select a booking.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbItem.SelectedValue == null)
            {
                MessageBox.Show("Please select an item.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string assignQty = txtAssignQty.Text.Trim();
            if (string.IsNullOrEmpty(assignQty))
            {
                MessageBox.Show("Please enter quantity to assign.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(assignQty, out int qty) || qty < 1)
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();

                    // Create BookingItems table if not exists
                    string createTableQuery = @"CREATE TABLE IF NOT EXISTS BookingItems (
                        BookingItemID INT PRIMARY KEY AUTO_INCREMENT,
                        BookingID VARCHAR(20) NOT NULL,
                        ItemID INT NOT NULL,
                        Quantity INT NOT NULL,
                        AssignedDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY (BookingID) REFERENCES Bookings(BookingID) ON DELETE CASCADE,
                        FOREIGN KEY (ItemID) REFERENCES Inventory(ItemID) ON DELETE CASCADE
                    )";
                    MySqlCommand createCmd = new MySqlCommand(createTableQuery, con);
                    createCmd.ExecuteNonQuery();

                    // Check available quantity
                    string checkQtyQuery = "SELECT Quantity FROM Inventory WHERE ItemID = @itemID";
                    MySqlCommand checkQtyCmd = new MySqlCommand(checkQtyQuery, con);
                    checkQtyCmd.Parameters.AddWithValue("@itemID", cmbItem.SelectedValue);
                    int currentQty = Convert.ToInt32(checkQtyCmd.ExecuteScalar());

                    if (currentQty < qty)
                    {
                        MessageBox.Show($"Not enough quantity available. Available: {currentQty}", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        con.Close();
                        return;
                    }

                    // Insert into BookingItems
                    string insertQuery = @"INSERT INTO BookingItems (BookingID, ItemID, Quantity) VALUES (@bookingID, @itemID, @quantity)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, con);
                    insertCmd.Parameters.AddWithValue("@bookingID", cmbBooking.SelectedValue);
                    insertCmd.Parameters.AddWithValue("@itemID", cmbItem.SelectedValue);
                    insertCmd.Parameters.AddWithValue("@quantity", qty);
                    insertCmd.ExecuteNonQuery();

                    // Update Inventory
                    string updateQuery = "UPDATE Inventory SET Quantity = Quantity - @qty WHERE ItemID = @itemID";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);
                    updateCmd.Parameters.AddWithValue("@qty", qty);
                    updateCmd.Parameters.AddWithValue("@itemID", cmbItem.SelectedValue);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Item assigned to booking successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAssignQty.Clear();
                    LoadInventoryData();
                    LoadItems();
                    LoadBookingItems();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error assigning item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBookingItems();
        }

        private void btnRemoveAssigned_Click(object sender, EventArgs e)
        {
            if (dgvAssignedItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an assigned item to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!dgvAssignedItems.Columns.Contains("BookingItemID"))
            {
                MessageBox.Show("Please select a valid assigned item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int bookingItemID = Convert.ToInt32(dgvAssignedItems.SelectedRows[0].Cells["BookingItemID"].Value);
            string itemName = dgvAssignedItems.SelectedRows[0].Cells["ItemName"].Value.ToString();
            int quantity = Convert.ToInt32(dgvAssignedItems.SelectedRows[0].Cells["Quantity"].Value);

            DialogResult result = MessageBox.Show($"Remove '{itemName}' (Quantity: {quantity}) from this booking?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        con.Open();
                        string getInfoQuery = "SELECT ItemID FROM BookingItems WHERE BookingItemID = @bookingItemID";
                        MySqlCommand getCmd = new MySqlCommand(getInfoQuery, con);
                        getCmd.Parameters.AddWithValue("@bookingItemID", bookingItemID);
                        int itemID = Convert.ToInt32(getCmd.ExecuteScalar());

                        string deleteQuery = "DELETE FROM BookingItems WHERE BookingItemID = @bookingItemID";
                        MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, con);
                        deleteCmd.Parameters.AddWithValue("@bookingItemID", bookingItemID);
                        deleteCmd.ExecuteNonQuery();

                        string updateQuery = "UPDATE Inventory SET Quantity = Quantity + @qty WHERE ItemID = @itemID";
                        MySqlCommand updateCmd = new MySqlCommand(updateQuery, con);
                        updateCmd.Parameters.AddWithValue("@qty", quantity);
                        updateCmd.Parameters.AddWithValue("@itemID", itemID);
                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Item removed from booking successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadInventoryData();
                        LoadItems();
                        LoadBookingItems();
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Navigation
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashboard dashbord = new dashboard();
            dashbord.Show();
            this.Close();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer cus = new customer();
            cus.Show();
            this.Close();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.Show();
            this.Close();
        }

        private void packagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Package packages = new Package();
            packages.Show();
            this.Close();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff staff = new staff();
            staff.Show();
            this.Close();
        }

        private void inventory_Load(object sender, EventArgs e) { }
    }
}