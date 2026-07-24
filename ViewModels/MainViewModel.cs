using BMS_Clone.Models;
using BMS_Clone.Views;
using BMS_Clone.Views.Dialog;
using BMS_Clone.Views.Pages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;


namespace BMS_Clone.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly MoniMeterView moniMeterView = new MoniMeterView();
        private readonly GridView gridView = new GridView();
        private readonly TopUpBalanceView topUpBalanceView = new TopUpBalanceView();
        private readonly GoAlarmView goAlarmView = new GoAlarmView();
        private readonly AlarmEventView alarmEventView = new AlarmEventView();
        private readonly ComsumptionView comsumptionView = new ComsumptionView();
        private readonly NotificationEvent notificationEvent = new NotificationEvent();
        private readonly NotificationView notificationView = new NotificationView();
        private readonly UserLogView userLogView = new UserLogView();
        private readonly MonitorControllerView monitorControllerView = new MonitorControllerView();

        [ObservableProperty]
        private TabItemModel selectedTab;

        public ObservableCollection<TabItemModel> Tabs { get; } = new();

        public MainViewModel()
        {
        }

        private void OpenTab(TabItemModel tab)
        {
            // prevent duplicate tab
            var exist = Tabs.FirstOrDefault(
                x => x.Header == tab.Header
            );

            if (exist != null)
            {
                SelectedTab = exist;
                return;
            }


            Tabs.Add(tab);
            SelectedTab = tab;
        }


        [RelayCommand]
        private void CloseTab(TabItemModel tab)
        {
            if (tab == null)
                return;

            int index = Tabs.IndexOf(tab);

            Tabs.Remove(tab);

            if (Tabs.Count == 0)
            {
                SelectedTab = null;
            }
            else
            {
                SelectedTab = Tabs[Math.Max(0, index - 1)];
            }
        }


        [RelayCommand]
        private void GoMonitorMeter()
        {
            OpenTab(new TabItemModel(
                "Monitor Meter",
                moniMeterView));
        }


        [RelayCommand]
        private void GoGridView()
        {
            OpenTab(new TabItemModel(
                "Grid View",
                gridView));
        }


        [RelayCommand]
        private void GoTopUpBalance()
        {
            if (Application.Current.MainWindow is not MainWindow mainWindow)
                return;

            var dialog = new TopUpBalanceDialog
            {
                Owner = mainWindow
            };

            var vm = new TopUpBalanceViewModel();
            dialog.DataContext = vm;

            vm.RequestClose += dialog.Close;

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


        [RelayCommand]
        private void GoTopUpHistory()
        {
            if (Application.Current.MainWindow is not MainWindow mainWindow)
                return;

            var dialog = new TopUpHistoryDialog
            {
                Owner = mainWindow
            };

            var vm = new TopUpHistoryViewModel();

            vm.RequestClose += dialog.Close;

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


        [RelayCommand]
        private void GoAlarm()
        {
            OpenTab(new TabItemModel(
                "Alarm",
                goAlarmView));
        }

        [RelayCommand]
        private void GoAlarmEvent()
        {
            OpenTab(new TabItemModel(
                "Alarm Event",
                alarmEventView
                ));
        }

        [RelayCommand]
        private void GoNotification()
        {
            OpenTab(new TabItemModel(
                "Notifications",
                notificationView
                )); 
        }

        [RelayCommand]
        private void GoNotificationEvent()
        {
            OpenTab(new TabItemModel(
                "Notification Event",
                notificationEvent
                ));
        }

        [RelayCommand]
        private void GoConsumption()
        {
            OpenTab(new TabItemModel(
                "Consumptions",
                comsumptionView
                ));
        }

        [RelayCommand]
        private void GoUserLog()
        {
            OpenTab(new TabItemModel(
                "User Log",
                userLogView
                ));
        }

        [RelayCommand]
        private void GoMonitorController()
        {
            OpenTab(new TabItemModel(
                "Monitor Controller",
                monitorControllerView
                ));
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