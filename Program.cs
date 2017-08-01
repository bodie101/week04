using System;

namespace week04
{
    class Program
    {
        static void Main(string[] args)
        {
        //Start the program with Clear();
        Console.Clear();

            Console.WriteLine("What is your first name");
            var firstName = Console.ReadLine();
            

            Console.WriteLine("What is your last name");
            var lastName = Console.ReadLine();

        
            
           Console.WriteLine(firstName + lastName);
        
        //End the program with blank line and instructions
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("Press <Enter> to quit the program");
        Console.ReadKey();


            
        }
    }
}
