using BMS_Clone.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BMS_Clone.Views.Pages
{
    public partial class ProfileCard : UserControl
    {
        public ProfileCard()
        {
            InitializeComponent();
            DataContext = new ProfileCardViewModel();
        }

        public string UserName
        {
            get => (string)GetValue(UserNameProperty);
            set => SetValue(UserNameProperty, value);
        }

        public static readonly DependencyProperty UserNameProperty = DependencyProperty.Register(
                nameof(UserName),
                typeof(string),
                typeof(ProfileCard),
                new PropertyMetadata("")
            );

        public string Email
        {
            get => (string)GetValue(EmailProperty);
            set => SetValue(EmailProperty, value);
        }

        public static readonly DependencyProperty EmailProperty = DependencyProperty.Register(
                nameof(Email),
                typeof(string),
                typeof(ProfileCard),
                new PropertyMetadata("")
            );

        public string Role
        {
            get => (string)GetValue(RoleProperty);
            set => SetValue(RoleProperty, value);
        }

        public static readonly DependencyProperty RoleProperty = DependencyProperty.Register(
                nameof(Role),
                typeof(string),
                typeof(ProfileCard),
                new PropertyMetadata("")
            );

        public ImageSource Avatar
        {
            get => (ImageSource)GetValue(AvatarProperty);
            set => SetValue(AvatarProperty, value);
        }

        public static readonly DependencyProperty AvatarProperty = DependencyProperty.Register(
                nameof(Avatar),
                typeof(ImageSource),
                typeof(ProfileCard),
                new PropertyMetadata(null)
            );

        public Brush StatusColor
        {
            get => (Brush)GetValue(StatusColorProperty);
            set => SetValue(StatusColorProperty, value);
        }

        public static readonly DependencyProperty StatusColorProperty = DependencyProperty.Register(
                nameof(StatusColor),
                typeof(Brush),
                typeof(ProfileCard),
                new PropertyMetadata(Brushes.Gray)
            );
    }
}
