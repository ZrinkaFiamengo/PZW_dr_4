using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PZW_dr_4.ViewModel;

namespace PZW_dr_4.View
{
    public partial class PostEditView : Window
    {
        public PostEditView(PostViewModel PostViewModel)
        {
            this.DataContext = PostViewModel;
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
