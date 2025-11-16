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
    public partial class EditBookForm : Form
    {
        public string BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }
        public string Status { get; set; }

        public bool EditSuccessful { get; private set; } = false;
        public EditBookForm()
        {
            InitializeComponent();
        }

        private void EditBookForm_Load(object sender, EventArgs e)
        {
            txtBookID.Text = this.BookID;
            txtTitle.Text = this.Title;
            txtAuthor.Text = this.Author;
            txtYear.Text = this.Year;
            cmbStatus.SelectedItem = this.Status;

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string newTitle = txtTitle.Text;
            string newAuthor = txtAuthor.Text;
            string newYear = txtYear.Text;
            string newStatus = cmbStatus.SelectedItem.ToString();

            // Simple validation
            if (string.IsNullOrWhiteSpace(newTitle) || string.IsNullOrWhiteSpace(newAuthor))
            {
                MessageBox.Show("Title and Author fields cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get connection string
            string str = "server=localhost;user=root;pwd=aadhil;database=library";

            using (MySqlConnection con = new MySqlConnection(str))
            {
                try
                {
                    con.Open();

                    // This SQL command updates all the fields
                    string query = @"UPDATE users SET 
                                        TITLE = @Title, 
                                        AUTHOR = @Author, 
                                        YEAR = @Year, 
                                        STATUS = @Status 
                                     WHERE 
                                        BOOKID = @BookID";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    // Add all parameters (safe from SQL Injection)
                    cmd.Parameters.AddWithValue("@Title", newTitle);
                    cmd.Parameters.AddWithValue("@Author", newAuthor);
                    cmd.Parameters.AddWithValue("@Year", newYear);
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@BookID", this.BookID); // The ID we are editing

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Book details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.EditSuccessful = true; // Report success
                    this.Close(); // Close this form
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A database error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.EditSuccessful = false; // Report failure
                }
            }
        }
    }

}
    

