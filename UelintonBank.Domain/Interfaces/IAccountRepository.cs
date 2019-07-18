using UelintonBank.Domain.Entities;
using UelintonBank.Domain.Interfaces;
using System;
using System.Collections.Generic;
using UelintonBankAPI.Domain.Entities;

namespace UelintonBank.Domain.Interfaces
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        Account GetAccount(int NumberAccount, int NumberAgency, int NumberDigit);
    }
}
