using ConsoleApp5.Models;
using System.Reflection.Metadata;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("Nothing Inc");
            User user1 = new User("Ferid", "Elizade", "50zade");
            User user2 = new User("Cavidan", "Veliyev", "c.veliyev");
            User user3 = new User("Hesen", "Bekirov", "hasanbov");

            company.GetAllusers().Add(user1);
            company.GetAllusers().Add(user2);
            company.GetAllusers().Add(user3);
            
        }
    }
}