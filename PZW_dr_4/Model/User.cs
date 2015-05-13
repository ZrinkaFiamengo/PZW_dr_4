using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PZW_dr_4.Model
{
    public class User
    {

        public User(string Name, int ID, string FilePath)
        {
            this.Name = Name;
            this.ID = ID;
            this.FilePath = FilePath;
        }
        public string Name { get; set; }
        public int ID { get; set; }
        public string FilePath { get; set; }
    }
}
