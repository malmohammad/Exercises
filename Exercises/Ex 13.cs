using System;

namespace Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {

            string response = "";
            do
            {
                //Console.Writeline("Hello World");
                Console.WriteLine("Enter a number!");
                var num = Console.ReadLine();
                var number = int.Parse(num);
                for (int i = 0; i < number; i++)
                {

                    Console.WriteLine(i);

                }

                Console.WriteLine("Would you like to continue (y/n) ?");
                response = Console.ReadLine();
            } while (response == "y");

            Console.WriteLine("Goodbye!");



            //While loop
            //for (var i = 0; i <= 5; 1++)

            //Console.WriteLine("Enter a number <<5");
            // Console.Writeline("Would you like to continue? (y/n)");
            //Console.Writeline("Enter a number <<12");
            //Console.Writeline("Would you like to continue?y/n)");


        }
    }
}