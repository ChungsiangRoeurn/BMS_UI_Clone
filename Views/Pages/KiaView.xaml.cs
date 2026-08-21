using BMS_Clone.ViewModels;
using System.Windows.Controls;

namespace BMS_Clone.Views.Pages
{
    /// <summary>
    /// Interaction logic for KiaView.xaml
    /// </summary>
    public partial class KiaView : UserControl
    {
        public KiaView()
        {
            InitializeComponent();
            DataContext = new KiaViewModel();
        }
    }
}
