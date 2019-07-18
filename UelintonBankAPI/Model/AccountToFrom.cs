using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UelintonBankAPI.Domain.Entities;

namespace UelintonBankAPI.Model
{
    public class AccountToFrom
    {
        public Account AccountTo { get; set; }
        public Account AccountFrom { get; set; }
    }
}
