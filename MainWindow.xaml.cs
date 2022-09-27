using IBAN_Check.Helpers;
using IBAN_Check.Model;
using IBAN_Check.ViewModel;
using System.ComponentModel;
using System.Windows;

namespace IBAN_Check
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
#pragma warning disable CS8618
    public partial class MainWindow : Window
    {

        ibanVM ibanVM { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            ibanVM = new ibanVM();
        }
    }
}
