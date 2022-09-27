using IBAN_Check.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace IBAN_Check.Commands
{
    public class FetchCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        ibanVM vm { get; set; }

        public FetchCommand(ibanVM ibanVM)
        {
            vm = ibanVM;
        }


        public bool CanExecute(object? parameter)
        {
            //string param = parameter as string;
            //if (string.IsNullOrEmpty(param))
            //{
            //    return false;
            //}
            return true;
        }

        public void Execute(object? parameter)
        {
            vm.getData(vm.Iban);
        }
    }
}
