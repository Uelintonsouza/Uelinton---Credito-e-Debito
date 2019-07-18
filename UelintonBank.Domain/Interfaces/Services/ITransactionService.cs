using UelintonBank.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UelintonBank.Domain.Interfaces.Services
{
  public  interface ITransactionService : IServiceBase<Lancamentos>
    {
        IEnumerable<Lancamentos> GetEntryStatus(IEnumerable<Lancamentos> entries);
    }
}
