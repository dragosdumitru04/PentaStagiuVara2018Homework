using Homework03ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{
    class Program
    {
        private static Board board;

        static void Main(string[] args)
        {
            board = new Board(new MessagesService());

            board.PostAdded += Board_PostAdded;


            while (true)
            {
                DisplayMenu();

                Console.Write("Your option is: ");
                int option = 0;
                int.TryParse(Console.ReadLine(), out option);

                Console.WriteLine();

                switch (option)
                {
                    case 1:
                        DisplayAllPosts();
                        break;
                    case 2:
                        AddPost();
                        break;
                    case 3:
                        DisplayAllPersons();
                        break;
                    case 4:
                        AddPerson();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again!");
                        break;
                }

                Console.WriteLine();
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Display all posts");
            Console.WriteLine("2 - Add a post");
            Console.WriteLine("3 - Display all persons");
            Console.WriteLine("4 - Add a person");
            Console.WriteLine("5 - Exit");
        }

        private static void DisplayPost(Post post)
        {
            Console.WriteLine("{0:yyyy-MM-dd HH:mm:ss} {1} {2}: {3}", post.Timestamp, post.Author.FirstName, post.Author.LastName, post.Message);
        }

        private static void DisplayAllPosts()
        {
            Console.WriteLine("All posts: ");
            foreach (Post post in board.GetPostsChronologically())
            {
                DisplayPost(post);
            }
        }

        private static Person AddPerson()
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter email: ");
            string email = Console.ReadLine();

            Console.Write("Enter year of birth (yyyy): ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter month of birth (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter day of birth (1-31): ");
            int day = int.Parse(Console.ReadLine());

            return board.AddPerson(firstName, lastName, new DateTime(year, month, day), email);
        }

        private static Post AddPost()
        {
            Console.WriteLine("Enter the author's email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your message:");
            string message = Console.ReadLine();

            Person author = board.GetPersonByEmail(email);

            return board.AddPost(author, message);
        }

        private static void DisplayPerson(Person person)
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", person.Id, person.FirstName, person.LastName, person.Birthdate, person.Email);
        }

        private static void DisplayAllPersons()
        {
            Console.WriteLine("All persons: ");
            foreach(Person person in board.GetPersons())
            {
                DisplayPerson(person);
            }
        }

        private static void Board_PostAdded(object sender, Post e)
        {
            Console.WriteLine("New post added:");
            DisplayPost(e);
        }
    }
}
