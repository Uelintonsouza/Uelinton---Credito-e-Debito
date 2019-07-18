using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UelintonBank.Domain.Entities;
using UelintonBank.Domain.Interfaces;
using UelintonBank.Domain.Interfaces.Services;
using UelintonBankAPI.Domain.Entities;

namespace UelintonBank.Domain.Service
{
    public class AccountService : ServiceBase<Account>, IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository) : base(accountRepository)
        {
            _accountRepository = accountRepository;
        }
       
        public Account GetAccouts(int NumberAccount, int NumberAgency, int NumberDigit)
        {
            return _accountRepository.GetAccount(NumberAccount, NumberAgency, NumberDigit);
        }
    }
}
