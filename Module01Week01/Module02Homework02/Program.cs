using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02Homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User("Adelina", "Baciu", new DateTime(1986, 06, 05)));
            users.Add(new User("Dragos", "Dumitru", new DateTime(1992, 04, 03)));
            users.Add(new User("Madalina", "Mitran", new DateTime(1984, 05, 01)));
            users.Add(new User("Costel", "Opinca", new DateTime(1990, 08, 03)));
            users.Add(new User("Denis", "Oprea", new DateTime(1985, 03, 05)));
            users.Add(new User("Stefan", "Timosenco", new DateTime(1995, 12, 30)));
            users.Add(new User("Marius", "Balan", new DateTime(1996, 03, 02)));
            users.Add(new User("Catalina", "Paraschiv", new DateTime(1993, 09, 03)));
            users.Add(new User("Daniel", "Busuioc", new DateTime(1996, 06, 01)));
            users.Add(new User("Malina", "Maria", new DateTime(1994, 02, 26)));
            users.Add(new User("Alice", "Rotaru", new DateTime(1981, 01, 25)));
            users.Add(new User("Alexandra", "Boisteanu", new DateTime(1993, 06, 03)));
            users.Add(new User("Nicoleta", "Laura", new DateTime(1995, 02, 21)));
            users.Add(new User("Bianca", "Gheorghe", new DateTime(1976, 05, 21)));
            users.Add(new User("Sorin", "Pauceanu", new DateTime(1985, 08, 29)));


            var filteredUsers = users
                .Where(user => user.Birthdate.Year >= 1985 && user.Birthdate.Year <= 1995)
                .OrderBy(user => user.VowelCount)
                .ToList();

            Console.WriteLine("The users:");
            foreach (var user in filteredUsers)
            {
                Console.WriteLine(user.UserName + " - Number of vowels: {0}", user.VowelCount);
            }
        }
    }
}
