using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Tecoc.Get.Apis.Models;
using Tecoc.Get.Apis.Repositories.interfaces;

namespace Tecoc.Get.Apis.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private IUserRepository _userRepository;

        [ObservableProperty]
        private ObservableCollection<UserModel> _allUsers;

        public MainViewModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            AllUsers = new ObservableCollection<UserModel>();
        }


        [RelayCommand]
        public async Task GetPersons()
        {
            NetworkAccess accessType = Connectivity.Current.NetworkAccess;
            if (accessType == NetworkAccess.Internet)
            {
                var users = await _userRepository.GetUsers();
                foreach (var user in users)
                {
                    AllUsers.Add(user);
                }
            }

            else
            {
                var snackbar = Snackbar.Make("No hay connexion a internet", duration: TimeSpan.FromSeconds(5));
                await snackbar.Show();
            }

        }
    }
}