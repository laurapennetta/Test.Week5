using Risto.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Risto.EF
{
    public class AccountEF : IAccountRepository
    {
        private readonly RistoContext ctx;

        public AccountEF(RistoContext context)
        {
            this.ctx = context;
        }
        public bool AddItem(Account newItem)
        {
            if (newItem == null)
            {
                throw new ArgumentNullException("Invalid item");
            }
            try
            {
                ctx.Accounts.Add(newItem);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditItem(Account itemToEdit)
        {
            throw new NotImplementedException();
        }

        public List<Account> FetchAll()
        {
            throw new NotImplementedException();
        }

        public Account GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Account GetByUsername(string username)
        {
            if (String.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Invalid username");
            }
            try
            {
                return ctx.Accounts.FirstOrDefault(x => x.Username.Equals(username));
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
