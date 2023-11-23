namespace e_Journal
{
    partial class User_BookForm
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
            groupBox1 = new GroupBox();
            dtpReleaseDate = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDescription = new TextBox();
            txtAuthor = new TextBox();
            txtBookName = new TextBox();
            txtBookID = new TextBox();
            groupBox2 = new GroupBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClose = new Button();
            dgvBook = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBook).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(dtpReleaseDate);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(txtBookName);
            groupBox1.Controls.Add(txtBookID);
            groupBox1.Location = new Point(8, 7);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(795, 173);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(909, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Infomation";
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(102, 92);
            dtpReleaseDate.Margin = new Padding(2, 2, 2, 2);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(211, 23);
            dtpReleaseDate.Location = new Point(116, 123);
            dtpReleaseDate.Margin = new Padding(2);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(241, 27);
            dtpReleaseDate.TabIndex = 11;
            dtpReleaseDate.ValueChanged += dateRelease_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 29);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.Location = new Point(456, 38);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 9;
            label5.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 96);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.Location = new Point(22, 128);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 8;
            label4.Text = "Release Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 64);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.Location = new Point(436, 86);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 64);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.Location = new Point(27, 86);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 6;
            label2.Text = "Book Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.Location = new Point(50, 36);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 5;
            label1.Text = "Book ID";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(457, 61);
            txtDescription.Margin = new Padding(2, 2, 2, 2);
            txtDescription.Location = new Point(522, 81);
            txtDescription.Margin = new Padding(2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(294, 110);
            txtDescription.Size = new Size(336, 146);
            txtDescription.TabIndex = 4;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(457, 27);
            txtAuthor.Margin = new Padding(2, 2, 2, 2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.ReadOnly = true;
            txtAuthor.Size = new Size(294, 23);
            txtAuthor.Location = new Point(522, 36);
            txtAuthor.Margin = new Padding(2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.ReadOnly = true;
            txtAuthor.Size = new Size(336, 27);
            txtAuthor.TabIndex = 3;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(102, 61);
            txtBookName.Margin = new Padding(2, 2, 2, 2);
            txtBookName.Name = "txtBookName";
            txtBookName.ReadOnly = true;
            txtBookName.Size = new Size(211, 23);
            txtBookName.Location = new Point(116, 81);
            txtBookName.Margin = new Padding(2);
            txtBookName.Name = "txtBookName";
            txtBookName.ReadOnly = true;
            txtBookName.Size = new Size(241, 27);
            txtBookName.TabIndex = 2;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(102, 27);
            txtBookID.Margin = new Padding(2, 2, 2, 2);
            txtBookID.Name = "txtBookID";
            txtBookID.ReadOnly = true;
            txtBookID.Size = new Size(211, 23);
            txtBookID.Location = new Point(116, 36);
            txtBookID.Margin = new Padding(2);
            txtBookID.Name = "txtBookID";
            txtBookID.ReadOnly = true;
            txtBookID.Size = new Size(241, 27);
            txtBookID.TabIndex = 0;
            txtBookID.TextChanged += txtBookID_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Linen;
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(btnClose);
            groupBox2.Location = new Point(8, 184);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(795, 40);
            groupBox2.Location = new Point(10, 245);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(909, 54);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "To-do";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtSearch.Location = new Point(178, 16);
            txtSearch.Margin = new Padding(2, 2, 2, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Type Book Name here ...";
            txtSearch.Size = new Size(319, 21);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(536, 12);
            btnSearch.Margin = new Padding(2, 2, 2, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(78, 20);
            // btnSearch
            // 
            btnSearch.Location = new Point(612, 16);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 27);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(672, 12);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(78, 20);
            btnClose.Location = new Point(768, 16);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 27);
            btnClose.TabIndex = 3;
            btnClose.Text = "Logout";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnLogout_Click;
            // 
            // dgvBook
            // 
            dgvBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBook.Location = new Point(8, 227);
            dgvBook.Margin = new Padding(2, 2, 2, 2);
            dgvBook.Name = "dgvBook";
            dgvBook.RowHeadersWidth = 62;
            dgvBook.RowTemplate.Height = 33;
            dgvBook.Size = new Size(795, 195);
            dgvBook.Location = new Point(10, 303);
            dgvBook.Margin = new Padding(2);
            dgvBook.Name = "dgvBook";
            dgvBook.RowHeadersWidth = 62;
            dgvBook.RowTemplate.Height = 33;
            dgvBook.Size = new Size(909, 260);
            dgvBook.TabIndex = 2;
            dgvBook.CellContentClick += dataGridView1_CellContentClick;
            // 
            // User_BookForm
            // 

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 430);
            Controls.Add(dgvBook);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 573);
            Controls.Add(dgvBook);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2);

            Name = "User_BookForm";
            Text = "Book";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBook).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDescription;
        private TextBox txtAuthor;
        private TextBox txtBookName;
        private TextBox txtBookID;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnClose;
        private DataGridView dgvBook;
        private Button btnSearch;
        private DateTimePicker dtpReleaseDate;
        private TextBox txtSearch;
    }
}
