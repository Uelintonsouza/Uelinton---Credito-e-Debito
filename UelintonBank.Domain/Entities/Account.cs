using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UelintonBankAPI.Domain.Entities
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        public int NumberAccount { get; set; }
        public int NumberAgency { get; set; }
        public int NumberDigit { get; set; }
        public decimal Balance { get; set; }    
    }
}
