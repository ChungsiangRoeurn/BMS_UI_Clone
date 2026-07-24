using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace BMS_Clone.ViewModels
{
    public partial class TopUpBalanceViewModel : ObservableObject
    { 
        public Action? RequestClose;

        [RelayCommand]
        private void Close()
        {
            RequestClose?.Invoke();
        }
    }
}
