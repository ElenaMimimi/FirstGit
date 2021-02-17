using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class P1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string t = Console.ReadLine();
            int x = Convert.ToInt32(t);
            if (x < 5)
            {

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Good");

                    /*Console.WriteLine("Enter number");
                    string text = Console.ReadLine();
                    int y = Convert.ToInt32(text);*/

                   /* for (int iy = 0; iy < 3; iy++)
                    {
                        Console.WriteLine("Excellent");
                    }*/

                }
                Console.WriteLine("Enter number");
                string text = Console.ReadLine();
                int y = Convert.ToInt32(text);
                if (y < 10)
                {
                    for (int iy = 0; iy < 3; iy++)
                    {
                        /*Console.WriteLine("Enter number");
                        string text = Console.ReadLine();
                        int y = Convert.ToInt32(text);*/
                        Console.WriteLine("Excellent");
                    }
                }

            }
            else
            {

                Console.WriteLine("Error");
            }
            Console.ReadKey();
        }

    }
}