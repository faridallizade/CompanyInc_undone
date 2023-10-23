using ConsoleApp5.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    internal class Company
    {
        private static int _id = 100;
        public int Id { get; set; }
        public string Name { get; set; }

        List<User> users = new List<User>();

        public Company(string Name)
        {
            _id++;
            Id = _id;
        }

        public void GetUser(int Id)
        {
            this.Id = Id;
            foreach (var item in users)
            {
                if (item.Id == Id)
                {
                    Console.WriteLine(item);
                }
                else
                {
                    throw new NotFoundException();
                }
            }
        }

        public List<User> GetAllusers()
        {
            Console.WriteLine("All Users : ");
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }
            return users;
        }

        public void DeleteUser(int Id)
        {
            this.Id = Id;
            foreach (var item in users)
            {
                if (item.Id == Id)
                {
                    users.RemoveAt(item.Id);
                    Console.WriteLine("Succesfully Deleted");
                }
                else
                {
                    throw new NotFoundException();
                }
            }
        }
    }
}
