using BMS_Clone.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;
using System.Windows.Controls;

namespace BMS_Clone.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly ApiService _apiService = new();

        public event Action? LoginSuccess;

        public event Action? RequestClose;


        [ObservableProperty]
        private string username = "";

        [ObservableProperty]
        private string password = "";

        [ObservableProperty]
        private string errorMessage = "";


        [ObservableProperty]
        private bool isPasswordVisible;

        [RelayCommand]
        private void TogglePasswordVisibility()
        {
            IsPasswordVisible = !IsPasswordVisible;
        }


        [RelayCommand]
        private async Task Login()
        {
            var request = new LoginRequest
            {
                Username = Username,
                Password = Password
            };

            var result = await _apiService.LoginAsync(request);

            if (result != null)
            {
                ToastService.Success($"Welcome {result.FirstName}");

                LoginSuccess?.Invoke();
            }
            else
            {
                ToastService.Error("Wrong username 0r password");
            }
        }

        [RelayCommand]
        private void Cancel()
        {
            Application.Current.Shutdown();
        }
    }
}