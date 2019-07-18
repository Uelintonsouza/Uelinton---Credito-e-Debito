using System;
using System.Collections.Generic;
using System.Text;
using UelintonBank.Application.Interface;
using UelintonBank.Domain.Interfaces.Services;
using UelintonBankAPI.Domain.Entities;

namespace UelintonBank.Application
{
    public class AccountAppService : AppServiceBase<Account>, IAccountAppService
    {
        private readonly IAccountService _accountService;

        public AccountAppService(IAccountService accountService) : base(accountService)
        {
            _accountService = accountService;
        }

        public Account GetAccouts(int NumberAccount, int NumberAgency, int NumberDigit)
        {
            return _accountService.GetAccouts(NumberAccount, NumberAgency, NumberDigit);
        }
    }
}
