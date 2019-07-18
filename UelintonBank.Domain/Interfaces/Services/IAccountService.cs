using UelintonBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using UelintonBankAPI.Domain.Entities;

namespace UelintonBank.Domain.Interfaces.Services
{
  public  interface IAccountService : IServiceBase<Account>
    {
       Account GetAccouts(int NumberAccount, int NumberAgency, int NumberDigit);
    }
}
