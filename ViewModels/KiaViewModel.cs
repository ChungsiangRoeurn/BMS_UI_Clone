using BMS_Clone.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using MahApps.Metro.IconPacks;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace BMS_Clone.ViewModels
{
    public partial class KiaViewModel: ObservableObject
    {
        public ObservableCollection<IoTDevice> Devices { get; set; } = new();

        public KiaViewModel()
        {
            Devices.Add(new IoTDevice
            {
                Status = "ON",
                Voltage = "220",
                Current = "1",
                Power = "880",
                Energy = "38",
                AccentColor = Brushes.DeepSkyBlue,
                IconKind = PackIconMaterialKind.Lightbulb
            });

            Devices.Add(new IoTDevice
            {
                Status = "OFF",
                Voltage = "0",
                Current = "0",
                Power = "0",
                Energy = "25",
                AccentColor = Brushes.Green,
                IconKind = PackIconMaterialKind.Fan
            });

            Devices.Add(new IoTDevice
            {
                Status = "ON",
                Voltage = "220",
                Current = "3",
                Power = "150",
                Energy = "120",
                AccentColor = Brushes.Orange,
                IconKind = PackIconMaterialKind.AirConditioner
            });

            Devices.Add(new IoTDevice
            {
                Status = "ON",
                Voltage = "12",
                Current = "2",
                Power = "24",
                Energy = "12",
                AccentColor = Brushes.Purple,
                IconKind = PackIconMaterialKind.Cctv
            });

            Devices.Add(new IoTDevice
            {
                Status = "LOCK",
                Voltage = "12",
                Current = "1",
                Power = "10",
                Energy = "5",
                AccentColor = Brushes.Red,
                IconKind = PackIconMaterialKind.Door
            });

            Devices.Add(new IoTDevice
            {
                Status = "ON",
                Voltage = "220",
                Current = "5",
                Power = "200",
                Energy = "310",
                AccentColor = Brushes.Gold,
                IconKind = PackIconMaterialKind.Television
            });

            Devices.Add(new IoTDevice
            {
                Status = "ON",
                Voltage = "220",
                Current = "8",
                Power = "180",
                Energy = "410",
                AccentColor = Brushes.CadetBlue,
                IconKind = PackIconMaterialKind.WashingMachine
            });

            Devices.Add(new IoTDevice
            {
                Status = "OFF",
                Voltage = "220",
                Current = "0",
                Power = "0",
                Energy = "150",
                AccentColor = Brushes.Gray,
                IconKind = PackIconMaterialKind.Fridge
            });

            Devices.Add(new IoTDevice
            {
                Status = "ON",
                Voltage = "220",
                Current = "6",
                Power = "130",
                Energy = "210",
                AccentColor = Brushes.Crimson,
                IconKind = PackIconMaterialKind.Fire
            });

            Devices.Add(new IoTDevice
            {
                Status = "ON",
                Voltage = "220",
                Current = "4",
                Power = "950",
                Energy = "180",
                AccentColor = Brushes.Teal,
                IconKind = PackIconMaterialKind.Kettle
            });

            Devices.Add(new IoTDevice
            {
                Status = "OFF",
                Voltage = "220",
                Current = "0",
                Power = "0",
                Energy = "60",
                AccentColor = Brushes.DarkOrange,
                IconKind = PackIconMaterialKind.Microwave
            });

            Devices.Add(new IoTDevice
            {
                Status = "ON",
                Voltage = "220",
                Current = "7",
                Power = "160",
                Energy = "340",
                AccentColor = Brushes.MediumPurple,
                IconKind = PackIconMaterialKind.CoffeeMaker
            });

            Devices.Add(new IoTDevice
            {
                Status = "ON",
                Voltage = "220",
                Current = "2",
                Power = "400",
                Energy = "90",
                AccentColor = Brushes.LimeGreen,
                IconKind = PackIconMaterialKind.DesktopTowerMonitor
            });

            Devices.Add(new IoTDevice
            {
                Status = "OFF",
                Voltage = "5",
                Current = "0",
                Power = "0",
                Energy = "2",
                AccentColor = Brushes.SlateBlue,
                IconKind = PackIconMaterialKind.RouterWireless
            });

            Devices.Add(new IoTDevice
            {
                Status = "ON",
                Voltage = "12",
                Current = "2",
                Power = "15",
                Energy = "7",
                AccentColor = Brushes.DarkCyan,
                IconKind = PackIconMaterialKind.Security
            });

            Devices.Add(new IoTDevice
            {
                Status = "ON",
                Voltage = "220",
                Current = "10",
                Power = "220",
                Energy = "520",
                AccentColor = Brushes.Firebrick,
                IconKind = PackIconMaterialKind.WaterBoiler
            });

            Devices.Add(new IoTDevice
            {
                Status = "OFF",
                Voltage = "220",
                Current = "0",
                Power = "0",
                Energy = "0",
                AccentColor = Brushes.DarkGray,
                IconKind = PackIconMaterialKind.Speaker
            });

            Devices.Add(new IoTDevice
            {
                Status = "ON",
                Voltage = "220",
                Current = "3",
                Power = "650",
                Energy = "140",
                AccentColor = Brushes.SteelBlue,
                IconKind = PackIconMaterialKind.Printer
            });

            Devices.Add(new IoTDevice
            {
                Status = "ON",
                Voltage = "220",
                Current = "9",
                Power = "210",
                Energy = "480",
                AccentColor = Brushes.IndianRed,
                IconKind = PackIconMaterialKind.Radiator
            });

            Devices.Add(new IoTDevice
            {
                Status = "OFF",
                Voltage = "220",
                Current = "0",
                Power = "0",
                Energy = "15",
                AccentColor = Brushes.MediumSeaGreen,
                IconKind = PackIconMaterialKind.Lamp
            });
        }
    }
    
}
