using System;
using System.Collections.Generic;
using System.Text;
using UelintonBank.Application.Interface;
using UelintonBank.Domain.Entities;
using UelintonBank.Domain.Interfaces.Services;

namespace UelintonBank.Application
{


    public class EntryAppService : AppServiceBase<Lancamentos>, IEntryAppService
    {
        private readonly ITransactionService _entryService;

        public EntryAppService(ITransactionService entryService) : base(entryService)
        {
            _entryService = entryService;
        }

        
        public IEnumerable<Lancamentos> GetEntryStatus()
        {
            return _entryService.GetEntryStatus(_entryService.GetAll());
        }
    }
}
