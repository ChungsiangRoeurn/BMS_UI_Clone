using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace BMS_Clone.Views.Controls
{
    public partial class IoTControl : UserControl
    {
        public IoTControl()
        {
            InitializeComponent();
        }

        // Status
        public string Status
        {
            get => (string)GetValue(StatusProperty);
            set => SetValue(StatusProperty, value);
        }

        public static readonly DependencyProperty StatusProperty = DependencyProperty.Register(
               nameof(Status),
               typeof(string),
               typeof(IoTControl),
               new PropertyMetadata("")
           );



        // Voltage
        public string Voltage
        {
            get => (string)GetValue(VoltageProperty);
            set => SetValue(VoltageProperty, value);
        }

        public static readonly DependencyProperty VoltageProperty = DependencyProperty.Register(
               nameof(Voltage),
               typeof(string),
               typeof(IoTControl),
               new PropertyMetadata("")
           );



        // Current
        public string Current
        {
            get => (string)GetValue(CurrentProperty);
            set => SetValue(CurrentProperty, value);
        }

        public static readonly DependencyProperty CurrentProperty = DependencyProperty.Register(
                nameof(Current),
                typeof(string),
                typeof(IoTControl),
                new PropertyMetadata("")
            );



        // Power
        public string Power
        {
            get => (string)GetValue(PowerProperty);
            set => SetValue(PowerProperty, value);
        }

        public static readonly DependencyProperty PowerProperty = DependencyProperty.Register(
                nameof(Power),
                typeof(string),
                typeof(IoTControl),
                new PropertyMetadata("")
            );



        // Energy
        public string Energy
        {
            get => (string)GetValue(EnergyProperty);
            set => SetValue(EnergyProperty, value);
        }

        public static readonly DependencyProperty EnergyProperty = DependencyProperty.Register(
                nameof(Energy),
                typeof(string),
                typeof(IoTControl),
                new PropertyMetadata("")
            );



        // Main Icon
        public MahApps.Metro.IconPacks.PackIconMaterialKind IconKind
        {
            get => (MahApps.Metro.IconPacks.PackIconMaterialKind)GetValue(IconKindProperty);
            set => SetValue(IconKindProperty, value);
        }

        public static readonly DependencyProperty IconKindProperty = DependencyProperty.Register(
                nameof(IconKind),
                typeof(MahApps.Metro.IconPacks.PackIconMaterialKind),
                typeof(IoTControl),
                new PropertyMetadata(MahApps.Metro.IconPacks.PackIconMaterialKind.Lightbulb)
            );
        


        // Main accent color
        public Brush AccentColor
        {
            get => (Brush)GetValue(AccentColorProperty);
            set => SetValue(AccentColorProperty, value);
        }

        public static readonly DependencyProperty AccentColorProperty = DependencyProperty.Register(
                nameof(AccentColor),
                typeof(Brush),
                typeof(IoTControl),
                new PropertyMetadata(
                    new SolidColorBrush(
                        Color.FromRgb(0, 191, 255)))
            );
    }
}
