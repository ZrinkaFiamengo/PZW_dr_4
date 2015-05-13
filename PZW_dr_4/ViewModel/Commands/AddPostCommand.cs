using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PZW_dr_4.ViewModel.Commands
{
    public class AddPostCommand : ICommand
    {
        public AddPostCommand(PostCollectionViewModel owner)
        {
            this.owner = owner;
        }

        private PostCollectionViewModel owner;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        

        public void Execute(object parameter)
        {
            this.owner.ExecuteAddCommand();
        }

        public event EventHandler CanExecuteChanged;
    }
}
