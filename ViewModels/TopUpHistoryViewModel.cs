using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace BMS_Clone.ViewModels
{
    public partial class TopUpHistoryViewModel : ObservableObject
    {
        public event Action? RequestClose;

        [RelayCommand]
        private void Close()
        {
            RequestClose?.Invoke();
        }
    }
}
