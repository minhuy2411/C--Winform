namespace e_Journal
{
    partial class CreateUserForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnCreate = new Button();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            txtGmail = new TextBox();
            txtUserName = new TextBox();
            label5 = new Label();
            errorProviderGmail = new ErrorProvider(components);
            errorProviderPhone = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderGmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPhone).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 46);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 134);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Gmail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 46);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 134);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtGmail);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(45, 70);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(621, 249);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Detail";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(263, 206);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(82, 22);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(427, 134);
            txtPhone.Margin = new Padding(3, 2, 3, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(110, 23);
            txtPhone.TabIndex = 7;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(427, 46);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(110, 23);
            txtPassword.TabIndex = 6;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(164, 132);
            txtGmail.Margin = new Padding(3, 2, 3, 2);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(110, 23);
            txtGmail.TabIndex = 5;
            txtGmail.TextChanged += txtGmail_TextChanged;
            txtGmail.Validating += txtGmail_Validating;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(164, 46);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(110, 23);
            txtUserName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(308, 23);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 5;
            label5.Text = "Sign In";
            // 
            // errorProviderGmail
            // 
            errorProviderGmail.ContainerControl = this;
            // 
            // errorProviderPhone
            // 
            errorProviderPhone.ContainerControl = this;
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CreateUserForm";
            Text = "CreateUserForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProviderGmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPhone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtGmail;
        private TextBox txtUserName;
        private Label label5;
        private Button btnCreate;
        private TextBox txtPhone;
        private ErrorProvider errorProviderGmail;
        private ErrorProvider errorProviderPhone;
        private TextBox txtPassword;
    }
}