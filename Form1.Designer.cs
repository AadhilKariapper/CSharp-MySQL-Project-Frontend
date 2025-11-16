namespace LIBRARY_BOOK_TRACKER
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddbook = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtTiltle = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.Label();
            this.txtBookid = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(702, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIBRARY BOOK TRACKER";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(321, 85);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnReturnBook);
            this.splitContainer1.Panel2.Controls.Add(this.btnEditBook);
            this.splitContainer1.Panel2.Controls.Add(this.btnIssueBook);
            this.splitContainer1.Panel2.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddbook);
            this.splitContainer1.Panel2.Controls.Add(this.btndelete);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.txt2);
            this.splitContainer1.Panel2.Controls.Add(this.textBox3);
            this.splitContainer1.Panel2.Controls.Add(this.txtTiltle);
            this.splitContainer1.Panel2.Controls.Add(this.txtID);
            this.splitContainer1.Panel2.Controls.Add(this.txtYear);
            this.splitContainer1.Panel2.Controls.Add(this.txtBookid);
            this.splitContainer1.Panel2.Controls.Add(this.txtStatus);
            this.splitContainer1.Panel2.Controls.Add(this.txtAuthor);
            this.splitContainer1.Panel2.Controls.Add(this.txtTitle);
            this.errorProvider1.SetIconAlignment(this.splitContainer1.Panel2, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1058, 592);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReturnBook.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnReturnBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturnBook.Location = new System.Drawing.Point(759, 231);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(186, 41);
            this.btnReturnBook.TabIndex = 18;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditBook.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditBook.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditBook.Location = new System.Drawing.Point(615, 148);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(247, 46);
            this.btnEditBook.TabIndex = 2;
            this.btnEditBook.Text = "Edit Book";
            this.btnEditBook.UseVisualStyleBackColor = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIssueBook.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnIssueBook.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBook.Location = new System.Drawing.Point(487, 231);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(240, 41);
            this.btnIssueBook.TabIndex = 17;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.UseVisualStyleBackColor = false;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(680, 63);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 47);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Clear All";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddbook
            // 
            this.btnAddbook.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddbook.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddbook.Location = new System.Drawing.Point(495, 63);
            this.btnAddbook.Name = "btnAddbook";
            this.btnAddbook.Size = new System.Drawing.Size(148, 45);
            this.btnAddbook.TabIndex = 16;
            this.btnAddbook.Text = "Add Book";
            this.btnAddbook.UseVisualStyleBackColor = false;
            this.btnAddbook.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Location = new System.Drawing.Point(865, 67);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(148, 43);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "Delete Book";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.comboBox1.Location = new System.Drawing.Point(126, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 36);
            this.comboBox1.TabIndex = 15;
            // 
            // txt2
            // 
            this.txt2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt2.Location = new System.Drawing.Point(126, 198);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(173, 35);
            this.txt2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.Location = new System.Drawing.Point(126, 141);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(173, 35);
            this.textBox3.TabIndex = 12;
            // 
            // txtTiltle
            // 
            this.txtTiltle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTiltle.Location = new System.Drawing.Point(126, 87);
            this.txtTiltle.Name = "txtTiltle";
            this.txtTiltle.Size = new System.Drawing.Size(173, 35);
            this.txtTiltle.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Location = new System.Drawing.Point(126, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(173, 35);
            this.txtID.TabIndex = 14;
            // 
            // txtYear
            // 
            this.txtYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtYear.AutoSize = true;
            this.txtYear.Location = new System.Drawing.Point(36, 205);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(61, 28);
            this.txtYear.TabIndex = 8;
            this.txtYear.Text = "Year:";
            // 
            // txtBookid
            // 
            this.txtBookid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBookid.AutoSize = true;
            this.txtBookid.Location = new System.Drawing.Point(13, 46);
            this.txtBookid.Name = "txtBookid";
            this.txtBookid.Size = new System.Drawing.Size(96, 28);
            this.txtBookid.TabIndex = 9;
            this.txtBookid.Text = "Book ID:";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(13, 263);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(84, 28);
            this.txtStatus.TabIndex = 10;
            this.txtStatus.Text = "Status:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAuthor.AutoSize = true;
            this.txtAuthor.Location = new System.Drawing.Point(13, 148);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(88, 28);
            this.txtAuthor.TabIndex = 7;
            this.txtAuthor.Text = "Author:";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTitle.AutoSize = true;
            this.txtTitle.Location = new System.Drawing.Point(36, 94);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(61, 28);
            this.txtTitle.TabIndex = 6;
            this.txtTitle.Text = "Title:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1055, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1779, 758);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "LIBRARY BOOK TRACKER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtTiltle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label txtYear;
        private System.Windows.Forms.Label txtBookid;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label txtAuthor;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnAddbook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnReturnBook;
    }
}

