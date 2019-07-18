using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UelintonBank.Domain.Entities;
using UelintonBank.Domain.Interfaces;
using UelintonBank.Domain.Interfaces.Services;

namespace UelintonBank.Domain.Service
{
    public class TransactionService : ServiceBase<Lancamentos>, ITransactionService
    {
        private readonly ITransactionRepository _transactionRepository;

        public TransactionService(ITransactionRepository transactionRepository) :base(transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }
        

        public IEnumerable<Lancamentos> GetEntryStatus(IEnumerable<Lancamentos> entries)
        {
            return entries.Where(x => x.Status == 0);
        }
    }
}
