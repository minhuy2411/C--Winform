using Business.Entities;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserAccountService
    {
        public UserAccount? CheckLogin(string email, string password)
        {
            UserAccountRepository repo = new UserAccountRepository();

            UserAccount account = repo.Get(email);

            return account != null && account.UserPassword == password ? account : null;
        }
        public void Create(UserAccount account)
        {
            UserAccountRepository repo = new UserAccountRepository();
            repo.Create(account);
        }
    }
}
