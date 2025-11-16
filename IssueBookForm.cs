using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LIBRARY_BOOK_TRACKER
{
    public partial class IssueBookForm : Form
    {
        
        public string BookID { get; set; }
        public string BookTitle { get; set; }

        
        public bool IssueSuccessful { get; private set; } = false;
        public IssueBookForm()
        {
            InitializeComponent();
        }
        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            // Take the data from the public properties and put it in the textboxes
            txtBookID.Text = this.BookID;
            txtTitle.Text = this.BookTitle;

            // Set the date to today
            dtpIssueDate.Value = DateTime.Now;
        }

        
        private void btnConfirmIssue_Click(object sender, EventArgs e)
        {
            // Get data from the form
            string borrowerName = txtBorrowerName.Text;
            DateTime issueDate = dtpIssueDate.Value;

            // Simple validation
            if (string.IsNullOrWhiteSpace(borrowerName))
            {
                MessageBox.Show("Please enter a borrower name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get connection string
            string str = "server=localhost;user=root;pwd=aadhil;database=library";

            using (MySqlConnection con = new MySqlConnection(str))
            {
                try
                {
                    con.Open();

                    // --- DATABASE COMMAND 1: Add a record to the new 'issued_books' log ---
                    string query1 = "INSERT INTO issued_books (book_id, borrower_name, issue_date) " +
                                    "VALUES (@BookID, @Borrower, @IssueDate)";

                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    cmd1.Parameters.AddWithValue("@BookID", this.BookID);
                    cmd1.Parameters.AddWithValue("@Borrower", borrowerName);
                    cmd1.Parameters.AddWithValue("@IssueDate", issueDate);

                    cmd1.ExecuteNonQuery();

                    // --- DATABASE COMMAND 2: Update the 'users' table status ---
                    string query2 = "UPDATE users SET STATUS = 'Not Available' WHERE BOOKID = @BookID";

                    MySqlCommand cmd2 = new MySqlCommand(query2, con);
                    cmd2.Parameters.AddWithValue("@BookID", this.BookID);

                    cmd2.ExecuteNonQuery();

                    // If both commands succeed:
                    MessageBox.Show("Book issued successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.IssueSuccessful = true; // Report success
                    this.Close(); // Close this form
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A database error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.IssueSuccessful = false; // Report failure
                }
            }
        }

    }
}
