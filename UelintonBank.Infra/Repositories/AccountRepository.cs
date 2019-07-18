using UelintonBank.Domain;
using UelintonBank.Domain.Entities;
using UelintonBank.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using UelintonBank.Domain.Interfaces;
using UelintonBankAPI.Domain.Entities;

namespace UelintonBank.Infra.Repositories
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public Account GetAccount(int NumberAccount, int NumberAgency, int NumberDigit)
        {
            return db.Account.Where(p => p.NumberAccount == NumberAccount && p.NumberAgency == NumberAgency && p.NumberDigit == NumberDigit).SingleOrDefault();
        }
    }
}
