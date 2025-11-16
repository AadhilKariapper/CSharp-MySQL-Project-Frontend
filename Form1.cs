using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace LIBRARY_BOOK_TRACKER
{
    public partial class Form1 : Form
    {
        MySqlConnection con;
        public Form1()
        {
            InitializeComponent();
            try
            {
                string str = "server=localhost;user=root;pwd=aadhil;database=library";
                con = new MySqlConnection(str);
                //con.Open();
                // MessageBox.Show("Database Connected");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     

        private void Form1_Load(object sender, EventArgs e)


        {
       

            loadGrid();

        }

     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            validateBOOKID();
            validateTIlTLE();
            validateYEAR();


            try
            {
                
                string sql = "insert into users (BOOKID,TITLE,AUTHOR,YEAR,STATUS) values ('"+txtID.Text+"','" + txtTiltle.Text +"', '" + textBox3.Text + "','" + txt2.Text + "','" + comboBox1.Text + "')";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Added Success");
                btnUpdate_Click(sender, e);
                loadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        protected bool validateBOOKID()
        {
            bool chk = false;

            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Enter The BOOK ID");
                chk = true;
            }
            else errorProvider1.SetError(txtID, "");
            return chk;

        }

        protected bool validateTIlTLE()
        {
            bool chk = false;

            if (txtTiltle.Text == "")
            {
                errorProvider1.SetError(txtID, "Enter The Valid Title");
                chk = true;
            }
            else errorProvider1.SetError(txtTiltle, "");
            return chk;

        }

        protected bool validateAUTHOUR()
        {
            bool chk = false;

            if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Enter The Authour Name");
                chk = true;
            }
            else errorProvider1.SetError(txtTiltle, "");
            return chk;

        }

        protected bool validateYEAR()
        {
            bool chk = false;
            Regex r = new Regex(@"^\d{4}$");


            if (txt2.Text == "")
            {
                errorProvider1.SetError(txt2, "Enter The year");
                chk = true;
            }
            else errorProvider1.SetError(txt2, "");
            return chk;

            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTiltle.Text = "";
            textBox3.Text = "";
            txt2.Text = "";
            comboBox1.Text = "";


        }
        // loadGride Code

        void loadGrid()
        {
            string sql = @"
        SELECT 
            u.BOOKID, 
            u.TITLE, 
            u.AUTHOR, 
            u.YEAR, 
            u.STATUS,

            -- This is the new logic:
            CASE 
                WHEN u.STATUS = 'Not Available' 
                THEN (SELECT borrower_name FROM issued_books ib 
                      WHERE ib.book_id = u.BOOKID 
                      ORDER BY ib.issue_date DESC LIMIT 1)
                ELSE NULL 
            END AS 'Borrower',

            -- This is the new logic:
            CASE 
                WHEN u.STATUS = 'Not Available' 
                THEN (SELECT issue_date FROM issued_books ib 
                      WHERE ib.book_id = u.BOOKID 
                      ORDER BY ib.issue_date DESC LIMIT 1)
                ELSE NULL 
            END AS 'Issue Date'
        FROM 
            users u
        ORDER BY 
            u.BOOKID;";

            string str = "server=localhost;user=root;pwd=aadhil;database=library";

            using (MySqlConnection con = new MySqlConnection(str))
            {
                try
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading grid data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           
            {
            // 1. Check if any rows are selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // 2. Ask for confirmation
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to permanently delete this book and ALL of its loan history?",
                    "Confirm Permanent Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    // Get your connection string
                    string str = "server=localhost;user=root;pwd=aadhil;database=library";
                    List<DataGridViewRow> rowsToDelete = new List<DataGridViewRow>();

                    using (MySqlConnection con = new MySqlConnection(str))
                    {
                        try
                        {
                            con.Open();

                            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                            {
                                // Get the BookID from the first cell (index 0)
                                string bookIDToDelete = row.Cells[0].Value.ToString();

                                // --- THIS IS THE NEW CODE ---
                                // COMMAND 1: Delete all records from the child table (issued_books) first
                                string deleteHistoryQuery = "DELETE FROM issued_books WHERE book_id = @BookID";
                                MySqlCommand cmdHistory = new MySqlCommand(deleteHistoryQuery, con);
                                cmdHistory.Parameters.AddWithValue("@BookID", bookIDToDelete);
                                cmdHistory.ExecuteNonQuery();
                                // --------------------------

                                // COMMAND 2: Now it's safe to delete from the parent table (users)
                                string deleteBookQuery = "DELETE FROM users WHERE BOOKID = @BookID";
                                MySqlCommand cmdBook = new MySqlCommand(deleteBookQuery, con);
                                cmdBook.Parameters.AddWithValue("@BookID", bookIDToDelete);

                                int rowsAffected = cmdBook.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    rowsToDelete.Add(row);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(
                                "An error occurred while deleting from the database: " + ex.Message,
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                        }
                    } // Connection is automatically closed here

                    // Now, remove the successfully deleted rows from the visual grid
                    if (rowsToDelete.Count > 0)
                    {
                        foreach (DataGridViewRow row in rowsToDelete)
                        {
                            dataGridView1.Rows.Remove(row);
                        }
                        MessageBox.Show(
                            rowsToDelete.Count + " book(s) and all associated history deleted.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a book from the table to delete.",
                    "No Book Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }


           
       

        }

        // IssueBook Code

            private void btnIssueBook_Click(object sender, EventArgs e)
        {
            // 
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                
                string bookID = selectedRow.Cells[0].Value.ToString();
                string title = selectedRow.Cells[1].Value.ToString();
                string currentStatus = selectedRow.Cells[4].Value.ToString();

                
                if (currentStatus.Equals("Not Available", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This book is already issued and not available.",
                                    "Issue Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; // Stop the code
                }

                
                using (IssueBookForm issueForm = new IssueBookForm())
                {
                  
                    issueForm.BookID = bookID;
                    issueForm.BookTitle = title;

                    issueForm.ShowDialog();

                    
                    if (issueForm.IssueSuccessful)
                    {
                        
                        loadGrid();
                    }
                }
            }
            else
            {
             
                MessageBox.Show("Please select a book from the table to issue.",
                                "No Book Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

               
                
                string bookID = selectedRow.Cells[0].Value.ToString();
                string title = selectedRow.Cells[1].Value.ToString();
                string author = selectedRow.Cells[2].Value.ToString();
                string year = selectedRow.Cells[3].Value.ToString();
                string status = selectedRow.Cells[4].Value.ToString();

                
                using (EditBookForm editForm = new EditBookForm())
                {
                   
                    editForm.BookID = bookID;
                    editForm.Title = title;
                    editForm.Author = author;
                    editForm.Year = year;
                    editForm.Status = status;

                    
                    editForm.ShowDialog();

                   
                    if (editForm.EditSuccessful)
                    {
                        
                        loadGrid();
                    }
                }
            }
            else
            {
                
                MessageBox.Show("Please select a book from the table to edit.",
                                "No Book Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            // Return Book Button

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                
                string bookID = selectedRow.Cells[0].Value.ToString();
                string currentStatus = selectedRow.Cells[4].Value.ToString();

              
                if (currentStatus.Equals("Available", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This book is already marked as available.",
                                    "Return Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; // Stop the code here
                }

                
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to return this book?",
                    "Confirm Return",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    
                    string str = "server=localhost;user=root;pwd=aadhil;database=library";
                    string updateQuery = "UPDATE users SET STATUS = @NewStatus WHERE BOOKID = @BookID";

                    using (MySqlConnection con = new MySqlConnection(str))
                    {
                        try
                        {
                            con.Open();
                            MySqlCommand cmd = new MySqlCommand(updateQuery, con);

                            cmd.Parameters.AddWithValue("@NewStatus", "Available");
                            cmd.Parameters.AddWithValue("@BookID", bookID);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Book returned successfully.",
                                                "Success",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);

                                
                                loadGrid();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Database error: " + ex.Message,
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                // If no row is selected
                MessageBox.Show("Please select a book from the table to return.",
                                "No Book Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
       
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }
    



 