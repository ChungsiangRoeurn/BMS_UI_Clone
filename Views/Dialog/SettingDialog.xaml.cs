using BMS_Clone.ViewModels;
using System.Windows;

namespace BMS_Clone.Views.Dialog
{
    public partial class SettingDialog : Window
    {
        public SettingDialog()
        {
            InitializeComponent();

            var vm = new SettingsViewModel();
            vm.Dialog = this;

            DataContext = vm;
        }
    }
}
