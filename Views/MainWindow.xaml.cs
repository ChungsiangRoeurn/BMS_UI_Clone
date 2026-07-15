using BMS_Clone.ViewModels;
using BMS_Clone.Views.Dialog;
using System.Timers;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Threading;

namespace BMS_Clone.Views
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();

            timer.Interval = TimeSpan.FromSeconds(0.4);

            timer.Tick += Timer_Tick;

            timer.Start();
        }


        //private void Timer_Tick(object? sender, EventArgs e)
        //{
        //    timer.Stop();

        //    ShowBlur();

        //    LoginDialog loginDialog = new LoginDialog
        //    {
        //        Owner = this
        //    };

        //    loginDialog.ShowDialog();

        //    HideBlur();
        //}

        private void Timer_Tick(object? sender, EventArgs e)
        {
            timer.Stop();

            ShowLogin();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private bool isMaximized = true;

        private double normalWidth = 1100;
        private double normalHeight = 700;


        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            if (isMaximized)
            {
                // Restore to custom size
                WindowState = WindowState.Normal;

                Width = normalWidth;
                Height = normalHeight;

                // Center window
                Left = (SystemParameters.WorkArea.Width - Width) / 2;
                Top = (SystemParameters.WorkArea.Height - Height) / 2;

                isMaximized = false;
            }
            else
            {
                // Maximize full screen
                WindowState = WindowState.Maximized;

                isMaximized = true;
            }
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void ShowOverlay()
        {
            DialogOverlay.Visibility = Visibility.Visible;

            var animation = new DoubleAnimation
            {
                From = 0,
                To = 1,
                Duration = TimeSpan.FromMilliseconds(200)
            };

            DialogOverlay.BeginAnimation(UIElement.OpacityProperty, animation);
        }

        public void HideOverlay()
        {
            var animation = new DoubleAnimation
            {
                From = 1,
                To = 0,
                Duration = TimeSpan.FromMilliseconds(200)
            };

            animation.Completed += (_, _) =>
            {
                DialogOverlay.Visibility = Visibility.Collapsed;
            };

            DialogOverlay.BeginAnimation(UIElement.OpacityProperty, animation);
        }

        public void ShowBlur()
        {
            MainContent.Effect = new BlurEffect
            {
                Radius = 10
            };

            ShowOverlay();
        }

        public void HideBlur()
        {
            MainContent.Effect = null;

            HideOverlay();
        }

        public void ShowLogin()
        {
            ShowBlur();

            LoginDialog loginDialog = new LoginDialog()
            {
                Owner = this
            };

            loginDialog.ShowDialog();

            HideBlur();
        }
    }
}