using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02Homework02
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string UserName
        {
            get
            {
                return $"{FirstName}{LastName}{Birthdate.ToString("yy")}";
            }
        }

        public int VowelCount
        {
            get
            {
                int count = 0;

                foreach (char c in FirstName)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        count++;
                    }
                }

                foreach(char c in LastName)
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        count++;
                    }
                }

                return count;
            }
        }

        public User (string firstname, string lastname, DateTime birthdate)
        {
            FirstName = firstname;
            LastName = lastname;
            Birthdate = birthdate;
        }

    }
}
