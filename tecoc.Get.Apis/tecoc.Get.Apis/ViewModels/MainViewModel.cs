using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Tecoc.Get.Apis.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [RelayCommand]
        public void Next()
        {
            Shell.Current.GoToAsync("OtherPage", true);
        }
    }
}