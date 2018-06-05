using System;

namespace Homework03ClassLibrary
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }

        public Person(int id, string firstName, string lastName, DateTime birthdate, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Birthdate = birthdate;
            Email = email;
        }
    }
}
