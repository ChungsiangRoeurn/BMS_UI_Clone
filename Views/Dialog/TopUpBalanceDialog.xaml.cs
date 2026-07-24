using BMS_Clone.ViewModels;
using System.Windows;


namespace BMS_Clone.Views.Dialog
{
    /// <summary>
    /// Interaction logic for TopUpBalanceDialog.xaml
    /// </summary>
    public partial class TopUpBalanceDialog : Window
    {
        public TopUpBalanceDialog()
        {
            InitializeComponent();
            DataContext = new TopUpBalanceViewModel();
        }
    }
}
