using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UelintonBank.Domain.Entities
{
    public class Lancamentos
    {
        [Key]
        public int TransactionId { get; set; }
        public int AccountToId { get; set; }
        public int AccountFromId { get; set; }

        public decimal Value { get; set; }
        
        public int Status { get; set; }
    }
}
