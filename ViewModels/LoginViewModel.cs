using BMS_Clone.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

namespace BMS_Clone.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
     
        [ObservableProperty]
        private string username = "";

        [ObservableProperty]
        private string password = "";

        [ObservableProperty]
        private string errorMessage = "";


        public event Action? LoginSuccess;

        public event Action? RequestClose;


        [RelayCommand]
        private void Login()
        {
            if (Username == "admin" &&
               Password == "123")
            {

                ToastService.Success(
                    "Login successfully");


                LoginSuccess?.Invoke();
            }
            else
            {

                ToastService.Error(
                    "Wrong username or password");

            }
        }

        [RelayCommand]
        private void Cancel()
        {
            Application.Current.Shutdown();
        }

    }
}