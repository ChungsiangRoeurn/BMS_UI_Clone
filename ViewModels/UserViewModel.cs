using BMS_Clone.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace BMS_Clone.ViewModels
{
    public class UserViewModel : ObservableObject
    {
        public ObservableCollection<UserModel> Users { get; set; } 

        public UserViewModel()
        {
            Users = new ObservableCollection<UserModel>
            {
                new UserModel
                {
                    Id = 1,
                    Username = "admin",
                    Email = "admin@gmail.com",
                    Role = "Admin"
                },

                new UserModel
                {
                    Id = 2,
                    Username = "john",
                    Email = "john@gmail.com",
                    Role = "User"
                },

                new UserModel
                {
                    Id = 3,
                    Username = "sarah",
                    Email = "sarah@gmail.com",
                    Role = "User"
                },

                new UserModel
                {
                    Id = 4,
                    Username = "michael",
                    Email = "michael@gmail.com",
                    Role = "Manager"
                },

                new UserModel
                {
                    Id = 5,
                    Username = "david",
                    Email = "david@gmail.com",
                    Role = "User"
                },

                new UserModel
                {
                    Id = 6,
                    Username = "emma",
                    Email = "emma@gmail.com",
                    Role = "Admin"
                },

                new UserModel
                {
                    Id = 7,
                    Username = "alex",
                    Email = "alex@gmail.com",
                    Role = "User"
                },

                new UserModel
                {
                    Id = 8,
                    Username = "olivia",
                    Email = "olivia@gmail.com",
                    Role = "Manager"
                },

                new UserModel
                {
                    Id = 9,
                    Username = "james",
                    Email = "james@gmail.com",
                    Role = "User"
                },

                new UserModel
                {
                    Id = 10,
                    Username = "sophia",
                    Email = "sophia@gmail.com",
                    Role = "Admin"
                }
            };
        }
    }
}
