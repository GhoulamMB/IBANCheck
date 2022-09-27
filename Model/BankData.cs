using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS8618
namespace IBAN_Check.Model
{
    public class BankData
    {
        public string bank_code { get; set; }
        public string name { get; set; }
        public string zip { get; set; }
        public string city { get; set; }
        public string bic { get; set; }
    }
}
