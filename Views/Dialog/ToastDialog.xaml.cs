using BMS_Clone.Enums;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;

namespace BMS_Clone.Views.Dialog
{
  
    public partial class ToastDialog : Window
    {
        public string Message { get; set; }
        public ToastDialog(
            ToastType type,
            string title,
            string message)
        {
            InitializeComponent();


            DataContext = new
            {
                Title = title,
                Message = message,
                AccentColor = GetColor(type)
            };


            Loaded += ToastDialog_Loaded;
        }


        private Brush GetColor(ToastType type)
        {
            return type switch
            {
                ToastType.Success => Brushes.LimeGreen,

                ToastType.Error => Brushes.Red,

                ToastType.Warning => Brushes.Orange,

                ToastType.Info => Brushes.DeepSkyBlue,

                _ => Brushes.White
            };
        }


        private DispatcherTimer timer;

        private void ToastDialog_Loaded(object sender, RoutedEventArgs e)
        {
            Left = SystemParameters.WorkArea.Width - Width - 10;
            //Top = SystemParameters.WorkArea.Height - Height - 10;
            Top = 40;


            timer = new DispatcherTimer();

            timer.Interval = TimeSpan.FromSeconds(3);

            timer.Tick += (s, e) =>
            {
                timer.Stop();
                Close();
            };

            timer.Start();
        }
    }
}
