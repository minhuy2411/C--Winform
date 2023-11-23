using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UserAccountRepository
    {
        public UserAccount? Get(string email)
        {
            BookScienceContext db = new BookScienceContext();
            return db.UserAccounts.FirstOrDefault(x => x.UserAddress == email);
        }
        public void Create(UserAccount userAccount)
        {
            BookScienceContext context = new BookScienceContext();
            context.Add(userAccount);
            context.SaveChanges();
        }
    }
}
