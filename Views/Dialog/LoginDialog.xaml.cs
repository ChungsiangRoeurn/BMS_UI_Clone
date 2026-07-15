using BMS_Clone.ViewModels;
using System.Windows;

namespace BMS_Clone.Views.Dialog
{

    public partial class LoginDialog : Window
    {
        public LoginDialog()
        {
            InitializeComponent();

            var vm = new LoginViewModel();

            vm.LoginSuccess += OnLoginSuccess;
            vm.RequestClose += () => Close();

            DataContext = vm;

            PasswordBox.PasswordChanged += PasswordBox_PasswordChanged;
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is LoginViewModel vm)
                vm.Password = PasswordBox.Password;
        }

        private void OnLoginSuccess()
        {
            MainWindow main = new MainWindow();
            main.Show();

            Close();
        }
    }
}
