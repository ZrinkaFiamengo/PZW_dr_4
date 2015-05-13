using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PZW_dr_4.ViewModel.Commands
{
    public class DeletePostCommand : ICommand
    {
        public DeletePostCommand(PostCollectionViewModel postCollectionViewModel)
        {
            this.Owner = postCollectionViewModel;
        }

        public PostCollectionViewModel Owner { get; private set; }

        public bool CanExecute(object parameter) { return true; }

        

        public void Execute(object parameter)
        {
            if (parameter is PostViewModel)
            {
                this.Owner.ExecuteDeleteCommand((PostViewModel)parameter);
            }
        }
        public event EventHandler CanExecuteChanged;
    }
}
