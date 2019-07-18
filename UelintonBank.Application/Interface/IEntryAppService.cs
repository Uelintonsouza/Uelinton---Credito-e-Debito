using System;
using System.Collections.Generic;
using System.Text;
using UelintonBank.Domain.Entities;

namespace UelintonBank.Application.Interface
{
    public interface IEntryAppService: IAppServiceBase<Lancamentos>
    {

        IEnumerable<Lancamentos> GetEntryStatus();
    }
}
