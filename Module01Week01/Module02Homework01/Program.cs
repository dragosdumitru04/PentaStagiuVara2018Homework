using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module02Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = File.ReadAllLines("people.txt").ToList();

            Console.WriteLine("Add a name: ");
            string name1 = Console.ReadLine();
            AddName(name1, list);

            Console.WriteLine("Add another name: ");
            string name2 = Console.ReadLine();
            AddName(name2, list);

            list.Remove("Iulian");

            try
            {
                if (!File.Exists("output.txt"))
                {
                    throw new FileNotFoundException();
                }
            }
            catch (FileNotFoundException)
            {
                var file = File.Create("output.txt");
                file.Close();
            }

            File.WriteAllLines("output.txt", list);
        }

        private static void AddName(string name, List<string> list)
        {
            if (name.All(Char.IsLetter))
            {
                list.Add(name);
            }
            else
            {
                Console.WriteLine("The name is invalid");
            }
        }
    }
}
