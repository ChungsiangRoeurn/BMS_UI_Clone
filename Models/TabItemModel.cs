
using BMS_Clone.Views.Pages;

namespace BMS_Clone.Models
{
    public class TabItemModel
    {
        public string Header { get; set; } = "";
        public object Content { get; set; } = "";

        public TabItemModel(string header, object content)
        {
            Header = header;
            Content = content;
        }
    }
}
