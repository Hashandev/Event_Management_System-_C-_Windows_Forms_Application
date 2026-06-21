using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace WinFormsApp1
{
    public partial class reports : Form
    {
        string connectionString = "server=localhost;database=eventdecorationdb;uid=root;pwd=;";

        public reports()
        {
            InitializeComponent();
            SetupStyles();
        }

        private void SetupStyles()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Reports - Event Decoration Management";

            // Style menu strip
            menuStrip1.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            menuStrip1.ForeColor = System.Drawing.Color.White;

            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.ForeColor = System.Drawing.Color.White;
                item.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            }

            // Green color for all download buttons
            System.Drawing.Color greenColor = System.Drawing.Color.FromArgb(46, 204, 113);

            // Customer Download Button
            download.BackColor = greenColor;
            download.ForeColor = System.Drawing.Color.White;
            download.FlatStyle = FlatStyle.Flat;
            download.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            download.Size = new System.Drawing.Size(100, 35);
            download.MouseEnter += (s, e) => { download.BackColor = System.Drawing.Color.FromArgb(39, 174, 96); };
            download.MouseLeave += (s, e) => { download.BackColor = greenColor; };

            // Booking Download Button
            downloadBooking.BackColor = greenColor;
            downloadBooking.ForeColor = System.Drawing.Color.White;
            downloadBooking.FlatStyle = FlatStyle.Flat;
            downloadBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            downloadBooking.Size = new System.Drawing.Size(100, 35);
            downloadBooking.MouseEnter += (s, e) => { downloadBooking.BackColor = System.Drawing.Color.FromArgb(39, 174, 96); };
            downloadBooking.MouseLeave += (s, e) => { downloadBooking.BackColor = greenColor; };

            // Packages Download Button
            downloadPackages.BackColor = greenColor;
            downloadPackages.ForeColor = System.Drawing.Color.White;
            downloadPackages.FlatStyle = FlatStyle.Flat;
            downloadPackages.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            downloadPackages.Size = new System.Drawing.Size(100, 35);
            downloadPackages.MouseEnter += (s, e) => { downloadPackages.BackColor = System.Drawing.Color.FromArgb(39, 174, 96); };
            downloadPackages.MouseLeave += (s, e) => { downloadPackages.BackColor = greenColor; };

            // Inventory Download Button
            downloadInventory.BackColor = greenColor;
            downloadInventory.ForeColor = System.Drawing.Color.White;
            downloadInventory.FlatStyle = FlatStyle.Flat;
            downloadInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            downloadInventory.Size = new System.Drawing.Size(100, 35);
            downloadInventory.MouseEnter += (s, e) => { downloadInventory.BackColor = System.Drawing.Color.FromArgb(39, 174, 96); };
            downloadInventory.MouseLeave += (s, e) => { downloadInventory.BackColor = greenColor; };

            // Staff Download Button
            downloadStaff.BackColor = greenColor;
            downloadStaff.ForeColor = System.Drawing.Color.White;
            downloadStaff.FlatStyle = FlatStyle.Flat;
            downloadStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            downloadStaff.Size = new System.Drawing.Size(100, 35);
            downloadStaff.MouseEnter += (s, e) => { downloadStaff.BackColor = System.Drawing.Color.FromArgb(39, 174, 96); };
            downloadStaff.MouseLeave += (s, e) => { downloadStaff.BackColor = greenColor; };

            // Style labels
            customer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            customer.ForeColor = System.Drawing.Color.White;

            label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.White;

            label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.White;

            label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.White;

            label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.White;
        }

        // ==================== CUSTOMER DOWNLOAD ====================
        private void download_Click(object sender, EventArgs e)
        {
            ExportReport("Customers", "SELECT CustomerID, FirstName, LastName, Email, MobileNumber, Address FROM customers");
        }

        // ==================== BOOKING DOWNLOAD ====================
        private void downloadBooking_Click(object sender, EventArgs e)
        {
            ExportReport("Bookings", "SELECT BookingID, CustomerID, PackageID, EventType, EventDate, EventTime, MobileNumber, TotalAmount, Advance, PaymentStatus FROM bookings");
        }

        // ==================== PACKAGES DOWNLOAD ====================
        private void downloadPackages_Click(object sender, EventArgs e)
        {
            ExportReport("Packages", "SELECT PackageID, PackageName, Price, PackageItems, Description FROM packages");
        }

        // ==================== INVENTORY DOWNLOAD ====================
        private void downloadInventory_Click(object sender, EventArgs e)
        {
            ExportReport("Inventory", "SELECT ItemID, ItemName, Quantity FROM inventory");
        }

        // ==================== STAFF DOWNLOAD ====================
        private void downloadStaff_Click(object sender, EventArgs e)
        {
            ExportReport("Staff", "SELECT StaffID, FullName, Position, Email, MobileNumber, Address FROM staff");
        }

        // ==================== MAIN EXPORT FUNCTION ====================
        private void ExportReport(string reportName, string query)
        {
            try
            {
                DataTable dt = new DataTable();

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    da.Fill(dt);
                    con.Close();
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show($"No {reportName.ToLower()} found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveDialog.FileName = $"{reportName}_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToPDF(dt, reportName, saveDialog.FileName);
                    MessageBox.Show($"{reportName} exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting {reportName}: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==================== EXPORT TO PDF ====================
        private void ExportToPDF(DataTable dt, string reportName, string filePath)
        {
            // Create PDF Document
            iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate(), 10, 10, 10, 10);
            iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // Fonts
            iTextSharp.text.Font titleFont = iTextSharp.text.FontFactory.GetFont("Arial", 18, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font headerFont = iTextSharp.text.FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font dataFont = iTextSharp.text.FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL);

            // Title
            doc.Add(new iTextSharp.text.Paragraph("Event Decoration Management", titleFont));
            doc.Add(new iTextSharp.text.Paragraph($"Report: {reportName}", headerFont));
            doc.Add(new iTextSharp.text.Paragraph($"Date: {DateTime.Now.ToString("dd/MM/yyyy HH:mm")}", headerFont));
            doc.Add(new iTextSharp.text.Paragraph(" "));

            // Create Table
            iTextSharp.text.pdf.PdfPTable table = new iTextSharp.text.pdf.PdfPTable(dt.Columns.Count);
            table.WidthPercentage = 100;

            // Headers
            foreach (DataColumn col in dt.Columns)
            {
                iTextSharp.text.pdf.PdfPCell cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(col.ColumnName, headerFont));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(200, 200, 200);
                table.AddCell(cell);
            }

            // Data Rows
            foreach (DataRow row in dt.Rows)
            {
                foreach (object item in row.ItemArray)
                {
                    table.AddCell(new iTextSharp.text.Phrase(item?.ToString() ?? "", dataFont));
                }
            }

            doc.Add(table);
            doc.Close();
        }

        // ==================== NAVIGATION ====================
        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashboard dash = new dashboard();
            dash.Show();
            this.Close();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer cust = new customer();
            cust.Show();
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

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inventory inv = new inventory();
            inv.Show();
            this.Close();
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            staff stf = new staff();
            stf.Show();
            this.Close();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}