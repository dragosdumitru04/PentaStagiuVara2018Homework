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
            if (!File.Exists(@".\output.txt"))
            {
                try
                {
                    using (StreamReader reader = new StreamReader("output.txt"))
                    {
                        reader.ReadToEnd();
                    }
                }
                catch (FileNotFoundException)
                {
                    File.Create(@".\output.txt");
                    List<string> list = File.ReadAllLines(@".\people.txt").ToList();

                    Console.WriteLine("Add a name: ");
                    string name = Console.ReadLine();
                    AddName(name, list);

                    list.Remove("Iulian");

                    TextWriter tw = new StreamWriter("output.txt");
                    foreach (string s in list)
                    {
                        tw.WriteLine(s);
                    }

                    tw.Close();
                }
            }
            else
            {
                List<string> list = File.ReadAllLines(@".\people.txt").ToList();

                Console.WriteLine("Add a name: ");
                string name = Console.ReadLine();
                AddName(name, list);

                list.Remove("Iulian");

                TextWriter tw = new StreamWriter("output.txt");
                foreach (string s in list)
                {
                    tw.WriteLine(s);
                }

                tw.Close();
            }
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
