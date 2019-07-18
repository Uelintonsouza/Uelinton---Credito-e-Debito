using UelintonBank.Domain.Entities;
using UelintonBank.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace UelintonBank.Domain.Interfaces
{
    public interface ITransactionRepository : IRepositoryBase<Lancamentos>
    {
        IEnumerable<Lancamentos> GetLancamentos(int Status);
    }
}
