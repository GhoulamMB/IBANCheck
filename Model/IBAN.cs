using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS8618
namespace IBAN_Check.Model
{
    public class IBAN
    {
        public bool valid { get; set; }
        public string iban { get; set; }
        public IbanData iban_data { get; set; }
        public BankData bank_data { get; set; }
        public string country_iban_example { get; set; }
    }
}
