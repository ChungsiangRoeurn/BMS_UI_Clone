using BMS_Clone.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BMS_Clone.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        MainWindow mainWindow = new MainWindow();
        public LoginViewModel()
        {
            
        }

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
                LoginSuccess?.Invoke();
            }
            else
            {
                ErrorMessage = "Wrong username or password";
            }
        }


        [RelayCommand]
        private void Cancel()
        {
            RequestClose?.Invoke();
        }

    }
}
