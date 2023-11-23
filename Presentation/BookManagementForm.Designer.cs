namespace e_Journal
{
    partial class BookManagementForm
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            isActive = new CheckBox();
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
            btnLoad = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dgvBookList = new DataGridView();
            bookServiceBindingSource = new BindingSource(components);
            btnClose = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookServiceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(isActive);
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
            groupBox1.Location = new Point(10, 11);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(909, 229);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Infomation";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // isActive
            // 
            isActive.AutoSize = true;
            isActive.Location = new Point(117, 176);
            isActive.Margin = new Padding(3, 4, 3, 4);
            isActive.Name = "isActive";
            isActive.Size = new Size(82, 24);
            isActive.TabIndex = 12;
            isActive.Text = "isActive";
            isActive.UseVisualStyleBackColor = true;
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(117, 123);
            dtpReleaseDate.Margin = new Padding(2, 3, 2, 3);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(241, 27);
            dtpReleaseDate.TabIndex = 11;
            dtpReleaseDate.ValueChanged += dtpReleaseDate_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(456, 37);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 9;
            label5.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 128);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 8;
            label4.Text = "Release Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(437, 85);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 84);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 6;
            label2.Text = "Book Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 5;
            label1.Text = "Book ID";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(522, 81);
            txtDescription.Margin = new Padding(2, 3, 2, 3);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(335, 145);
            txtDescription.TabIndex = 4;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(522, 36);
            txtAuthor.Margin = new Padding(2, 3, 2, 3);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(335, 27);
            txtAuthor.TabIndex = 3;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(117, 79);
            txtBookName.Margin = new Padding(2, 3, 2, 3);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(241, 27);
            txtBookName.TabIndex = 2;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(117, 36);
            txtBookID.Margin = new Padding(2, 3, 2, 3);
            txtBookID.Name = "txtBookID";
            txtBookID.ReadOnly = true;
            txtBookID.Size = new Size(241, 27);
            txtBookID.TabIndex = 0;
            txtBookID.TextChanged += txtBookID_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Linen;
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(btnLoad);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(10, 245);
            groupBox2.Margin = new Padding(2, 3, 2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 3, 2, 3);
            groupBox2.Size = new Size(909, 53);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "To-do";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtSearch.Location = new Point(365, 21);
            txtSearch.Margin = new Padding(2, 3, 2, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Type Book Name here ...";
            txtSearch.Size = new Size(254, 25);
            txtSearch.TabIndex = 5;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(640, 21);
            btnSearch.Margin = new Padding(2, 3, 2, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 27);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(747, 21);
            btnLoad.Margin = new Padding(2, 3, 2, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(90, 27);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(253, 21);
            btnUpdate.Margin = new Padding(2, 3, 2, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 27);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(139, 21);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 27);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(27, 21);
            btnAdd.Margin = new Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 27);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add ";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(10, 303);
            dgvBookList.Margin = new Padding(2, 3, 2, 3);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 62;
            dgvBookList.RowTemplate.Height = 33;
            dgvBookList.Size = new Size(909, 260);
            dgvBookList.TabIndex = 2;
            dgvBookList.CellContentClick += dgvBookList_CellContentClick;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(842, 21);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(51, 28);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Clicked;
            // 
            // BookManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 573);
            Controls.Add(dgvBookList);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "BookManagementForm";
            Text = "Publication";
            FormClosed += BookManagementForm_FormClosed;
            Load += BookManagementForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookServiceBindingSource).EndInit();
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
        private Button btnLoad;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dgvBookList;
        private TextBox txtSearch;
        private Button btnSearch;
        private DateTimePicker dtpReleaseDate;
        private BindingSource bookServiceBindingSource;
        private CheckBox isActive;
        private Button btnClose;
    }
}