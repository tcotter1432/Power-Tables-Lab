using System;

namespace PowerTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set up Variables
            int number;
            bool computing = true;
            //Main Loop
            while (computing)
            {
                Console.WriteLine("Enter a number to go up to.");
                number = int.Parse(Console.ReadLine());

                //Call methods to crunch the numbers and ask if they want to continue or not
                Compute(number);
                computing = KeepComputing();
            }
            //Good bye!
            Console.WriteLine("Take care!!");
        }

        //Method to check if the user wants to keep going
        public static bool KeepComputing()
        {
            Console.WriteLine("Would you like to compute another number? (y/n)");
            
            //Check to see if user's input is valid and proceed accordingly
            switch (Console.ReadLine().ToLower())
            {
                case "y":
                    return true;
                case "n":
                    return false;
                default:
                    //Recursive call in the event of a bad input.
                    Console.WriteLine("I'm sorry, but that's a bad input. Please try again!");
                    return KeepComputing();
            }
        }

        //Method to crunch out the numbers and print them into a formatted table
        public static void Compute(int number)
        {
            //Local Vairables
            int squared;
            int cubed;

            //Table header
            Console.WriteLine("Number\tSquared\tCubed");

            //For Loop to crunch all of the numbers. Starts at one since we don't care about zero.
            for (int x = 1; x <= number; x++)
            {
                //Calculations
                squared = x * x;
                cubed = x * x * x;
                //Output
                Console.WriteLine($"{x}\t{squared}\t{cubed}");
            }
        }
    }
}