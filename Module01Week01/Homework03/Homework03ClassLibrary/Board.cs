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
            return messagesService.AddPerson(firstName, lastName, birthdate, email);
        }

        public Person GetPersonByEmail(string email)
        {
            return messagesService.GetPersonByEmail(email);
        }

        public Post AddPost(Person author, string message)
        {
            var post =  messagesService.AddPost(author, message);

            if (PostAdded != null)
            {
                PostAdded(this, post);
            }

            return post;
        }


        public Post this[int index]
        {
            get
            {
                return messagesService.GetPostAtIndex(index);
            }
        }

        public event EventHandler<Post> PostAdded;
        
    }
}
