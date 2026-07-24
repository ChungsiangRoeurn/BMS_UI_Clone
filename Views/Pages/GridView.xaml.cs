using BMS_Clone.ViewModels;
using System.Windows.Controls;


namespace BMS_Clone.Views.Pages
{
    /// <summary>
    /// Interaction logic for GridView.xaml
    /// </summary>
    public partial class GridView : UserControl
    {
        public GridView()
        {
            InitializeComponent();
            DataContext = new GridViewViewModel();
        }
    }
}
