using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PZW_dr_4.ViewModel.Commands
{
    public class EditUserCommand : ICommand
    {
        public EditUserCommand(UserViewModel userViewModel)
        {
            this.Owner = userViewModel;
        }

        public UserViewModel Owner { get; private set; }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            this.Owner.ExecuteEditCommand();
        }
    }
}
