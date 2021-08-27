using System;
using System.Collections.Generic;
using System.Text;

namespace Risto.Core
{
    public interface IAccountRepository : IRepository<Account>
    {
        Account GetByUsername(string username);
    }
}
