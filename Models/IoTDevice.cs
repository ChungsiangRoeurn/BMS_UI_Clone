using MahApps.Metro.IconPacks;
using System.Windows.Media;

namespace BMS_Clone.Models
{
    public class IoTDevice
    {
        public string Status { get; set; } = "";
        public string Voltage { get; set; } = "";
        public string Current { get; set; } = "";
        public string Power { get; set; } = "";
        public string Energy { get; set; } = "";

        public Brush AccentColor { get; set; } = Brushes.DeepSkyBlue;

        public PackIconMaterialKind IconKind { get; set; }
    }
}
