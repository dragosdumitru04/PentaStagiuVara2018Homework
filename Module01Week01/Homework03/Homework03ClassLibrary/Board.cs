using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03ClassLibrary
{
    public class Board
    {
        private IMessagesService messagesService;

        public Board(IMessagesService messagesService)
        {
            this.messagesService = messagesService;
        }

        public IEnumerable<Person> GetPersons()
        {
            return messagesService.GetPersons();
        }

        public IEnumerable<Post> GetPostsChronologically()
        {
            return messagesService.GetPostsChronologically();
        }

        public Person AddPerson(string firstName, string lastName, DateTime birthdate, string email)
        {
            return null;
        }

        Person GetPersonByEmail(string email)
        {
            return null;
        }

        Post AddPost(Person author, string message)
        {
            return null;
        }
    }
}
