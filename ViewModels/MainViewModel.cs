using BMS_Clone.Views;
using BMS_Clone.Views.Dialog;
using BMS_Clone.Views.Pages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows;


namespace BMS_Clone.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        MoniMeterView moniMeterView = new MoniMeterView();
        GridView gridView = new GridView();
        TopUpBalanceView topUpBalanceView = new TopUpBalanceView();
        TopUpHistoryView topUpHistoryView = new TopUpHistoryView();
        GoAlarmView goAlarmView = new GoAlarmView();
        SettingDialog settingDialog = new SettingDialog();

        [ObservableProperty]
        private object currentView;

        public MainViewModel()
        {
            CurrentView = moniMeterView;

        }

        [RelayCommand]
        private void GoMonitorMeter()
        {
            CurrentView = moniMeterView;
        }

        [RelayCommand]
        private void GoGridView()
        {
            CurrentView = gridView;
        }

        [RelayCommand]
        private void GoTopUpBalance()
        {
            CurrentView = topUpBalanceView;
        }

        [RelayCommand]
        private void GoTopUpHistory()
        {
            CurrentView = topUpHistoryView;
        }

        [RelayCommand]
        private void GoAlarm()
        {
            CurrentView = goAlarmView;
        }


        [RelayCommand]
        private void OpenSetting()
        {
            if (Application.Current.MainWindow is not Views.MainWindow mainWindow)
                return;

            var dialog = new SettingDialog
            {
                Owner = mainWindow
            };

            var vm = new SettingsViewModel
            {
                Dialog = dialog
            };

            dialog.DataContext = vm;

            mainWindow.ShowBlur();

            try
            {
                dialog.ShowDialog();
            }
            finally
            {
                mainWindow.HideBlur();
            }
        }

        //[RelayCommand]
        //private void Logout()
        //{
        //    // Show login again
        //    LoginDialog login = new LoginDialog();
        //    login.Show();

        //    Application.Current.MainWindow.Close();
        //}

        [RelayCommand]
        private void Close()
        {
            Application.Current.Shutdown();
        }


        [RelayCommand]
        private void Logout()
        {
            if (Application.Current.MainWindow is MainWindow main)
            {
                main.ShowLogin();
            }
        }
    }
}