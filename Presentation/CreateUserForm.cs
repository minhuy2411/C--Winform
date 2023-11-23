using Business.Entities;

using DataAccess.Repositories;
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

namespace e_Journal
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text) ||
                String.IsNullOrEmpty(txtGmail.Text) ||
                String.IsNullOrEmpty(txtPassword.Text) ||
                String.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Required all fields!");
                return;
            }
            if (!IsValidGmail(txtGmail.Text) || !IsValidDigits(txtPhone.Text)) 
            {
                MessageBox.Show("Invalid format");
                return;

            }
            var user = new UserAccount();
            user.UserName = txtUserName.Text;
            user.UserAddress = txtGmail.Text;
            user.UserPassword = txtPassword.Text;
            user.UserPhone = txtPhone.Text;
            user.RoleId = 2;
            UserAccountRepository repo = new UserAccountRepository();
            repo.Create(user);
            MessageBox.Show("Create Successfully!");
            this.Close();


        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtGmail_Validating(object sender, EventArgs e)
        {
            string errorMessage = "length 5 – 90,Must be end with @gmail.com or @fpt.edu.vn";
            if (!IsValidGmail(txtGmail.Text))
            {
                this.errorProviderGmail.SetError(txtGmail, errorMessage);
            }
            else
            {
                errorProviderGmail.SetError(txtGmail, null);
            }
        }

        private void txtPhone_Validating(object sender, EventArgs e)
        {
            string errorMessage = "Phone must be all digits";
            if (!IsValidDigits(txtPhone.Text))
            {

                this.errorProviderPhone.SetError(txtPhone, errorMessage);
            }
            else
            {

                errorProviderGmail.SetError(txtPhone, null);

            }
        }
        private bool IsValidGmail(string email)
        {
            const string validDomainSuffix = "@";

            const string gmailDomain = "gmail.com";
            const string fptDomain = "fpt.edu.vn";

 
            string domain = email.Substring(email.LastIndexOf(validDomainSuffix) + 1);

            return domain.Equals(gmailDomain, StringComparison.OrdinalIgnoreCase) ||
                   domain.Equals(fptDomain, StringComparison.OrdinalIgnoreCase);
        }

        private bool IsValidDigits(string input)
        {
            const string pattern = @"^\d*$";
            return Regex.IsMatch(input, pattern);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
