using System;
using System.Collections.Generic;
using System.Text;

namespace UelintonBank.Infra.Data.Context
{
    public static class DbInitializer
    {
        public static void Initializer(UelintonBankContext uelintonBankContext)
        {

            uelintonBankContext.Database.EnsureCreated();
        }
    }
}
