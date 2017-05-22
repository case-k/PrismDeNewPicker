using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismDeNewPicker.ViewModels
{
    public class User
    {
        public string Name { get; set; }
    }


    public class MainPageViewModel : BindableBase, INavigationAware
    {
        public IEnumerable<User> Users { get; }


        private User _selecteduser;
        public User SelectedUser
        {
            get { return _selecteduser; }
            set { SetProperty(ref _selecteduser, value); }
        }

        public MainPageViewModel()
        {
            Users = new[]{
                new User { Name = "シャーク" },
                new User { Name = "イーグル" },
                new User { Name = "パンサー"},
            };
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }
    }
}
