using System;
using System.IO;

namespace TestingClass
{
    class Program
    {
        static void Main(string[] args) //main method
        {
            TextReader tIn = Console.In;
            String input = tIn.ReadLine();
            String t = input.ToLower();

            String[] verbs = new String[] { "run", "die" };

            for (int x=0; x < verbs.Length; x++)
            {
                if (verbs[x] == t)
                {
                    Console.WriteLine(input);
                    x = 100;
                }
                else if (x == (verbs.Length-1))
                {
                    Console.WriteLine("Input not recognized");
                }
            }

            Console.ReadKey();
            
        }
    }
}
