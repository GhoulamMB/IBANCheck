using IBAN_Check.Commands;
using IBAN_Check.Helpers;
using IBAN_Check.Model;
using System.ComponentModel;
#pragma warning disable CS8618
namespace IBAN_Check.ViewModel
{
    public class ibanVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private string _iban;

        public string Iban
        {
            get { return _iban; }
            set 
            { 
                _iban = value;
                OnPropertyChanged(nameof(Iban));
            }
        }

        private string _country;

        public string Country
        {
            get { return _country; }
            set
            {
                _country = value;
                OnPropertyChanged(nameof(Country));
            }
        }

        private string _bankcode;

        public string Bank_code
        {
            get { return _bankcode; }
            set
            {
                _bankcode = value;
                OnPropertyChanged(nameof(Bank_code));
            }
        }

        private string _accountNo;

        public string AccountNo
        {
            get { return _accountNo; }
            set
            {
                _accountNo = value;
                OnPropertyChanged(nameof(AccountNo));
            }
        }

        private string _branch;

        public string Branch
        {
            get { return _branch; }
            set
            {
                _branch = value;
                OnPropertyChanged(nameof(Branch));
            }
        }

        private ibanDetails _details;

        public ibanDetails details
        {
            get { return _details; }
            set
            { 
                _details = value;
                OnPropertyChanged(nameof(details));
            }
        }

        public FetchCommand FetchCommand { get; set; }

        public ibanVM()
        {
            FetchCommand = new(this);
            details = new();
        }
        public void getData(string iban)
        {
            var Resultiban = IBANHelper.FetchData(iban);
            details = new()
            {
                Country = Resultiban.iban_data.country,
                BankCode = Resultiban.iban_data.bank_code,
                AccountNo = Resultiban.iban_data.account_number,
                Branch = Resultiban.iban_data.branch
            };
        }
    }
}
