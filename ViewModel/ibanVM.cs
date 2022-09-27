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



        private IBAN? _resultIBAN;

        public IBAN Resultiban
        {
            get { return _resultIBAN; }
            set
            {
                _resultIBAN = value;
                OnPropertyChanged(nameof(Resultiban));
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

        public FetchCommand FetchCommand { get; set; }

        public ibanVM()
        {
            Resultiban = new();
            FetchCommand = new(this);
        }
        public void getData(string iban)
        {
            Resultiban = IBANHelper.FetchData(iban);
        }
    }
}
