using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UelintonBank.API.Model
{
    public class Entry
    {
        public int NumberAccountFrom { get; set; }
        public int NumberAgencyFrom { get; set; }
        public int NumberDigitFrom { get; set; }
        public int NumberAccountTo { get; set; }
        public int NumberAgencyTo { get; set; }
        public int NumberDigitTo { get; set; }
        public decimal Value { get; set; }
    }
}
