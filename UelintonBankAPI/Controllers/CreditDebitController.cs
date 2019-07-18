using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using UelintonBank.API.Model;
using UelintonBank.Application.Interface;
using UelintonBank.Domain.Entities;
using UelintonBankAPI.Domain.Entities;
using UelintonBankAPI.Model;

namespace UelintonBank.API.Controllers
{
    [ApiController]
    public class CreditDebitController : ControllerBase
    {

        private readonly IEntryAppService _entryAppService;
        private readonly IAccountAppService _accountAppService;

        public CreditDebitController(IEntryAppService entryAppService, IAccountAppService accountAppService)
        {
            _entryAppService = entryAppService;
            _accountAppService = accountAppService;
        }
        // POST api/values

        [Route("api/TransactionCreditDebit")]
        [HttpPost]
        public void TransactionCreditDebit(Entry entry)
        {
            AccountToFrom accountToFrom = MapperAccount(entry);

            accountToFrom = ValidationAccounts(accountToFrom);
            SaveTransaction(accountToFrom, entry);



        }

        [Route("api/settleCreditDebit")]
        [HttpPost]
        public void SettleCreditDebit(Entry entry)
        {
            AccountToFrom accountToFrom = MapperAccount(entry);

            accountToFrom = ValidationAccounts(accountToFrom);

            Transaction(accountToFrom, entry);
        }
        private void SaveTransaction(AccountToFrom accountToFrom, Entry entry)
        {
            Lancamentos lancamento = new Lancamentos()
            {
                AccountFromId = accountToFrom.AccountFrom.AccountId,
                AccountToId = accountToFrom.AccountTo.AccountId,
                Status = 0,
                Value = entry.Value
            };
            _entryAppService.Add(lancamento);
        }


        private bool Transaction(AccountToFrom accountToFrom, Entry entry)
        {
            accountToFrom.AccountFrom.Balance = accountToFrom.AccountFrom.Balance - entry.Value;

            accountToFrom.AccountTo.Balance = accountToFrom.AccountTo.Balance + entry.Value;

            _accountAppService.Update(accountToFrom.AccountFrom);

            _accountAppService.Update(accountToFrom.AccountTo);


            return true;
        }
        private AccountToFrom ValidationAccounts(AccountToFrom accountToFrom)
        {

            Account AccountTo = _accountAppService.GetAccouts(accountToFrom.AccountTo.NumberAccount, accountToFrom.AccountTo.NumberAgency, accountToFrom.AccountTo.NumberDigit);

            if (AccountTo == null)
                throw new ArgumentException("Conta Origem inesistente");

            Account AccountFrom = _accountAppService.GetAccouts(accountToFrom.AccountFrom.NumberAccount, accountToFrom.AccountFrom.NumberAgency, accountToFrom.AccountFrom.NumberDigit);

            if (AccountFrom == null)
                throw new ArgumentException("Conta Destino inesistente");

            accountToFrom.AccountFrom = AccountFrom;
            accountToFrom.AccountTo = AccountTo;
            return accountToFrom;
        }
        private AccountToFrom MapperAccount(Entry entry)
        {
            AccountToFrom accountToFrom = new AccountToFrom();
            Account accountFrom = new Account()
            {
                NumberAccount = entry.NumberAccountFrom,
                NumberAgency = entry.NumberAgencyFrom,
                NumberDigit = entry.NumberDigitFrom
            };

            Account accounTo = new Account()
            {
                NumberAccount = entry.NumberAccountTo,
                NumberAgency = entry.NumberAgencyTo,
                NumberDigit = entry.NumberDigitTo
            };

            accountToFrom.AccountFrom = accountFrom;
            accountToFrom.AccountTo = accounTo;

            return accountToFrom;

        }
    }
}