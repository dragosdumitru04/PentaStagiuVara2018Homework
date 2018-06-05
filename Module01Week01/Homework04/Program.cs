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
            Console.WriteLine("1 - Display all messages");
            Console.WriteLine("2 - Add a message");
            Console.WriteLine("3 - Display all persons");
            Console.WriteLine("4 - Add a person");
            Console.WriteLine("5 - Exit");
        }

        private static void DisplayPost(Post post)
        {
            //Console.WriteLine("(id = {0}), {1} {2}", post.ID, post.Author, post.Timestamp);

            Console.WriteLine("{0:yyyy-MM-dd HH:mm:ss} {1} {2}: {3}", post.Timestamp, post.Author.FirstName, post.Author.LastName, post.Message);
        }

        private static void DisplayAllPosts()
        {
            Console.WriteLine("All messages");
            foreach (Post post in board.GetPostsChronologically())
            {
                DisplayPost(post);
            }
        }

        private static void AddPerson()
        {

        }

        private static void AddPost()
        {
            Console.WriteLine("Enter the author's email:");

            Console.WriteLine("Enter your message:");
            string message = Console.ReadLine();
        }

        private static void DisplayAllPersons()
        {

        }
    }
}
