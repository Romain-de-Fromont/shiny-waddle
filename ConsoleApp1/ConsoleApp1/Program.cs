using System;
using System.IO;

namespace TestingClass
{
    class Program
    {
        static void Main(string[] args) //main method
        {
            TextReader tIn = Console.In;
            string input = tIn.ReadLine();
            input = input.ToLower();

            string[] verbs = new string[] { "run", "die" };
            string[] target = new string[] {"door", "floor" };

            for (int x=0; x < verbs.Length; x++)
            {
                if (input.Contains(verbs[x]))
                {
                    Console.Write(verbs[x]);

                    for (int z = 0; z < target.Length; z++)
                    {
                        if (input.Contains(target[z]))
                        {
                            Console.Write(", "+target[z]);
                            Console.WriteLine();
                            break;
                        }
                    }

                    break;
                }
                else if (x == (verbs.Length-1))
                {
                    Console.WriteLine("Input not recognized");
                }
            }

            Console.WriteLine("\nTest complete, press any key to exit.");
            Console.ReadKey();
            
        }
    }
}
