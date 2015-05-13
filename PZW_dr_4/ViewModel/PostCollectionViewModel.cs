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
using PZW_dr_4.ViewModel;

namespace PZW_dr_4.ViewModel
{
    public class PostCollectionViewModel : ViewModelBase
    {
        public PostCollectionViewModel()
        {
            var posts = new List<Post>()
            {
                new Post(new User("Ana", 1, "/Resources/Images/User_girl1.png"), "15:30, 12-05-2015", "Ova stranica je super!"),
                new Post(new User("Ema", 3, "/Resources/Images/User_girl2.png"), "15:31, 12-05-2015", "Ana, kad ćemo na kavu?"),
                new Post(new User("Ana", 1, "/Resources/Images/User_girl1.png"), "15:35, 12-05-2015", "Mogle bi sutra oko 5, skupit ću te s autom?"),
                new Post(new User("Ivan", 2, "/Resources/Images/User_boy1.png"), "15:37, 12-05-2015", "Idem i ja!"),
                new Post(new User("Luka", 100, "/Resources/Images/User_boy2.png"), "15:38, 12-05-2015", "Dogovarajte se u inboxu! Ovdje mi samo bezveze punite obavijesti!")
            };

            this.PostViewModels = new ObservableCollection<PostViewModel>
            (
                posts.Select(post => new PostViewModel(post))
            );

            this.AddCommand = new AddPostCommand(this);
            this.DeleteCommand = new DeletePostCommand(this);
        }

        public ObservableCollection<PostViewModel> PostViewModels { get; set; }



        public DeletePostCommand DeleteCommand { get; private set; }
        public AddPostCommand AddCommand { get; private set; }



        public void ExecuteDeleteCommand(PostViewModel viewModelToDelete)
        {
            this.PostViewModels.Remove(viewModelToDelete);
        }

        public void ExecuteAddCommand()
        {
            PostViewModels.Add(new PostViewModel(new Post(new User("Luka", 100, "/Resources/Images/User_boy2.png"), "15:30, 12-05-2015", "Novi komentar")));
        }
        
    }
}
