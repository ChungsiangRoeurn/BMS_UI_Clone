using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS_Clone.ViewModels
{
    public partial class ProfileCardViewModel: ObservableObject
    {
        [ObservableProperty]
        private string userName = "Default";
    }
}
