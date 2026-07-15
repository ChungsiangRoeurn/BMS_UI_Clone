using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;

public partial class SettingsViewModel : ObservableObject
{
    public SettingsViewModel()
    {
        
    }

    public Window? Dialog { get; set; }
    public Action RequestClose { get; internal set; }

    [ObservableProperty]
    private string searchText;

    partial void OnSearchTextChanged(string value)
    {
        Console.WriteLine(value);
    }

    [RelayCommand]
    private void Cancel()
    {
        Dialog?.Close();
    }

    [RelayCommand]
    private void Save()
    {
        Dialog?.Close();
    }

}