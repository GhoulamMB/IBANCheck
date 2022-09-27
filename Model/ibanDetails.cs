using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBAN_Check.Model
{
    public class ibanDetails
    {
        public string Country { get; set; }
        public string BankCode { get; set; }
        public string AccountNo { get; set; }
        public string Branch { get; set; }
    }
}
