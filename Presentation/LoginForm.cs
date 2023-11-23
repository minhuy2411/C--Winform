using Business.Entities;
using DataAccess;

namespace e_Journal
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text; 
            UserAccountService se = new UserAccountService(); ;

            UserAccount account = se.CheckLogin(email,password);
            if (account == null)
            {
                MessageBox.Show("Login failed. Please check your credentials",
                                 "Wrong credentials", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }
            else if (account.RoleId == 1)
            {
                BookManagementForm bookMg = new BookManagementForm();
                bookMg.Show();
                this.Hide();

            }
            else if (account.RoleId == 2)
            {
                User_BookForm bookForm = new User_BookForm();
                try
                {
                    bookForm.Show();
                    this.Hide();
                }
                catch (Exception)
                {

                    throw;
                }

            }
            else if (account.RoleId == 3)
            {
                AddBookForm addBook = new AddBookForm();
                addBook.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You are not allowed to access this function!",
                                    "Access denied", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                return;
            }



        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.Show();

        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}