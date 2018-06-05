using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03ClassLibrary
{
    public class MessagesService : IMessagesService
    {
        private List<Person> persons;
        private List<Post> posts;

        private static int nextPersonId = 1;
        private static int nextPostId = 1;

        public MessagesService()
        {
            persons = new List<Person>();
            Person dragos = AddPerson("Dragos", "Dumitru", new DateTime(1992, 04, 03), "dragos.dumitru@gmail.com");
            Person bogdan = AddPerson("Bogdan", "Drojneanu", new DateTime(1985, 07, 10), "bogdan.radu@gmail.com");
            Person madalina = AddPerson("Madalina", "Iordache", new DateTime(1996, 02, 21), "madalina.iordache@gmail.com");

            posts = new List<Post>();
            AddPost(dragos, "Salut!");
            AddPost(madalina, "Hei! How you doing?");
            AddPost(dragos, "Bine, am terminat un meci de League of Legends.");
            AddPost(bogdan, "La care l-am batut!");
        }

        public Person AddPerson(string firstName, string lastName, DateTime birthdate, string email)
        {
            Person person = new Person(nextPersonId++, firstName, lastName, birthdate, email);
            persons.Add(person);
            return person;
        }

        public List<Person> GetPersons()
        {
            return null;
        }

        public Person GetPersonByEmail(string email)
        {
            return null;
        }


        public Post AddPost(Person author, string message)
        {
            Post post = new Post(nextPostId++, author, message, DateTime.Now);
            posts.Add(post);
            return post;
        }

        public List<Post> GetPostsChronologically()
        {
            return posts.OrderBy(p => p.Timestamp).ToList();
        }
    }
}
