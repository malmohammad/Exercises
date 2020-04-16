using System;

namespace Exercise_6
{
    class Program
    {

        static string tesetResponse = "";

        static void Main(string[] args)
        {
            string userResponse;
            do
            { 
                Console.WriteLine("Hello World!");
                Console.WriteLine("Would you like to continue y/n");
                userResponse = Console.ReadLine(); 
            } while (userResponse == "y");

            Console.WriteLine("Goodbye!");

        }


    }
}
