using System;

namespace consolesample
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to my wolrd");
      
            Console.Write("please enter your name:");

            string username = Console.ReadLine();

            Console.WriteLine($"Hello {username}! nice to meet you");
            Console.WriteLine("press any key to exit");
            Console.ReadLine();
        }
    }

}