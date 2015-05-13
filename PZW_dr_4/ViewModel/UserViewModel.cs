using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PZW_dr_4.Model;
using PZW_dr_4.View;
using PZW_dr_4.ViewModel.Commands;

namespace PZW_dr_4.ViewModel
{
    public class UserViewModel : ViewModelBase
    {
        public UserViewModel(User user)
        {
            this.User = user;

            this.EditCommand = new EditUserCommand(this);
        }

        public EditUserCommand EditCommand { get; private set; }

        private User user;
        public User User
        {
            get { return this.user; }
            set
            {
                this.user = value;
                this.RaisePropertyChanged("User");
            }
        }

        public void ExecuteEditCommand()
        {
            var editView = new UserEditView(this);
            editView.Show();
        }
    }
}
