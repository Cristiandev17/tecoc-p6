using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tecoc.Get.Apis.Models;
using Tecoc.Get.Apis.Pages;
using Tecoc.Get.Apis.Repositories.interfaces;

namespace Tecoc.Get.Apis.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private IUserRepository _userRepository;

        [ObservableProperty]
        private ObservableCollection<UserModel> _allUsers;

        [ObservableProperty]
        private bool _isBusy;

        public MainViewModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            AllUsers = new ObservableCollection<UserModel>();
        }

        public async Task GetPersons()
        {

            //await Shell.Current.GoToAsync(nameof(OtherPage));
            NetworkAccess accessType = Connectivity.Current.NetworkAccess;

            if (accessType == NetworkAccess.Internet)
            {
                IsBusy = true;
                var users = await _userRepository.GetUsers();
                foreach (var user in users)
                {
                    AllUsers.Add(user);
                }
                await Task.Delay(5000);
                IsBusy = false;
            }

            else
            {
                var snackbar = Snackbar.Make("No hay connexion a internet", duration: TimeSpan.FromSeconds(5));
                await snackbar.Show();
            }

        }
    }
}