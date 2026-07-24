using BMS_Clone.Models;
using BMS_Clone.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

public partial class UserViewModel : ObservableObject
{
    private readonly ApiService _apiService = new();

    public ObservableCollection<UserModel> Users { get; } = new();

    [ObservableProperty]
    private bool isLoading;


    public UserViewModel()
    {
        _ = LoadUsersAsync();
    }


    [RelayCommand]
    private async Task Refresh()
    {
        await LoadUsersAsync();
    }


    private async Task LoadUsersAsync()
    {
        IsLoading = true;

        try
        {
            // Test loading
            await Task.Delay(3000);

            var users = await _apiService.GetUsersAsync();

            Users.Clear();

            foreach (var user in users)
            {
                Users.Add(user);
            }
        }
        finally
        {
            IsLoading = false;
        }
    }
}