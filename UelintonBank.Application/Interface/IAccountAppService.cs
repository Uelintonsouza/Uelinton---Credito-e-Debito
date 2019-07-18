using System;
using System.Collections.Generic;
using System.Text;
using UelintonBankAPI.Domain.Entities;

namespace UelintonBank.Application.Interface
{
    public interface IAccountAppService : IAppServiceBase<Account>
    {

        Account GetAccouts(int NumberAccount, int NumberAgency, int NumberDigit);
    }
}
