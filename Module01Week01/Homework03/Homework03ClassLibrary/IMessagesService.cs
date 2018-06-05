using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03ClassLibrary
{
    public interface IMessagesService
    {
        Person AddPerson(string firstName, string lastName, DateTime birthdate, string email);
        List<Person> GetPersons();
        Person GetPersonByEmail(string email);

        Post AddPost(Person author, string message);
        List<Post> GetPostsChronologically();
    }
}
