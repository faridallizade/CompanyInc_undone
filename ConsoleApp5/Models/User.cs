using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    internal class User : Company
    {
        private static int _id = 100;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }




        public User()
        {
            _id++;
            Id = _id;
        }

        public User(string Name, string Surname , string Username)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Username = Username;
        }

    }
}
