using UelintonBank.Domain;
using UelintonBank.Domain.Entities;
using UelintonBank.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using UelintonBank.Domain.Interfaces;

namespace UelintonBank.Infra.Repositories
{
    public class TransactionRepository : RepositoryBase<Lancamentos>, ITransactionRepository
    {

        public IEnumerable<Lancamentos> GetLancamentos (int status)
        {
            return db.Lancamentos.Where(x=>x.Status==status);

        }
    }
}
