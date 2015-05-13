using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PZW_dr_4.Model
{
    public class Post
    {
        public Post(User User, string Time, string Text)
        {
            this.User = User;
            this.Time = Time;
            this.Text = Text;
        }

        public User User { get; set; }
        public string Time { get; set; }
        public string Text { get; set; }
    }
}
