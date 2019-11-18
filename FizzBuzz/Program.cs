using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzExcercies
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 300; i++)
            {
                if (i % 11 == 0)
                {
                    if (i % 13 == 0)
                    {
                        Console.WriteLine("FezzBong");
                    }
                    else
                        Console.WriteLine("Bong");
                }

                else if (i % 3 == 0 && i % 5 == 0)
                {
                    if (i % 13 == 0)
                    {
                        Console.WriteLine("FizzFezzBuzz");
                    }
                    else
                        Console.WriteLine("FizzBuzz");
                }
                else if (i % 7 == 0 && i % 3 == 0)
                {
                    if (i % 13 == 0)
                    {
                        Console.WriteLine("FizzFezzBang");
                    }
                    else
                        Console.WriteLine("FizzBang");
                }
                else if (i % 7 == 0 && i % 5 == 0)
                {
                    if (i % 13 == 0)
                    {
                        Console.WriteLine("FezzBuzzBang");
                    }
                    else
                        Console.WriteLine("BuzzBang");
                }
                else if (i % 3 == 0)
                {
                    if (i % 13 == 0)
                    {
                        Console.WriteLine("FizzFezz");
                    }
                    else
                        Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    if (i % 13 == 0)
                    {
                        Console.WriteLine("FezzBuzz");
                    }
                    else
                        Console.WriteLine("Buzz");
                }
                else if (i % 7 == 0)
                {
                    if (i % 13 == 0)
                    {
                        Console.WriteLine("FezzBang");
                    }
                    else
                        Console.WriteLine("Bang");
                }
                else if (i % 13 == 0)
                {
                    Console.WriteLine("Fezz");
                }
                else
                {
                    Console.WriteLine(i);

                }




            }
            Console.ReadLine();
        }
    }
}
