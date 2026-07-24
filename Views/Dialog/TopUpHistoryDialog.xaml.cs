using BMS_Clone.ViewModels;
using System.Windows;

namespace BMS_Clone.Views.Dialog
{
    /// <summary>
    /// Interaction logic for TopUpHistoryDialog.xaml
    /// </summary>
    public partial class TopUpHistoryDialog : Window
    {
        public TopUpHistoryDialog()
        {
            InitializeComponent();
            DataContext = new TopUpHistoryViewModel();
        }
    }
}
