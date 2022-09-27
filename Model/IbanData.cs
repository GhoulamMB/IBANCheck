using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS8618
namespace IBAN_Check.Model
{
    public class IbanData
    {
        public string country { get; set; }
        public string country_code { get; set; }
        public bool sepa_country { get; set; }
        public string checksum { get; set; }
        public string BBAN { get; set; }
        public string bank_code { get; set; }
        public string account_number { get; set; }
        public string branch { get; set; }
        public string national_checksum { get; set; }
        public string country_iban_format_as_swift { get; set; }
        public string country_iban_format_as_regex { get; set; }
    }
}
