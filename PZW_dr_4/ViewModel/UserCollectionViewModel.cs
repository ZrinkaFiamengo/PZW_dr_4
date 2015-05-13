using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PZW_dr_4.Model;
using PZW_dr_4.ViewModel.Commands;

namespace PZW_dr_4.ViewModel
{
    public class UserCollectionViewModel : ViewModelBase
    {
        int i;

        public UserCollectionViewModel()
        {
            i = 1;
            var users = new List<User>()
            {
                new User("Ana", i++, "/Resources/Images/User_girl1.png"),
                new User("Ivan",i++,"/Resources/Images/User_boy1.png"),
                new User("Ema", i++, "/Resources/Images/User_girl2.png")
            };

            var currentuser = new List<User>()
            {
                new User("Luka", 100,"/Resources/Images/User_boy2.png")
            };

            this.UserViewModels = new ObservableCollection<UserViewModel>
            (
                users.Select(user => new UserViewModel(user))
            );

            this.CurrentUserViewModel = new ObservableCollection<UserViewModel>
            (
                currentuser.Select(current_user => new UserViewModel(current_user))
            );


            this.AddCommand = new AddUserCommand(this);
            this.DeleteCommand = new DeleteUserCommand(this);
        }

        public ObservableCollection<UserViewModel> UserViewModels { get; set; }
        public ObservableCollection<UserViewModel> CurrentUserViewModel { get; set; }



        public DeleteUserCommand DeleteCommand { get; private set; }
        public AddUserCommand AddCommand { get; private set; }



        public void ExecuteDeleteCommand(UserViewModel viewModelToDelete)
        {
            this.UserViewModels.Remove(viewModelToDelete);
        }

        public void ExecuteAddCommand()
        {
            UserViewModels.Add(new UserViewModel(new User("User", i++, "/Resources/Images/User_unknown.png")));
        }
    }
}
