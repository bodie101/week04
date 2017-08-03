using System;

namespace task2
{
    class Program
    {
       
        static void Main(string[] args)

       
        {

            //Start the program with Clear();
            Console.Clear();
            

            Console.WriteLine("put in number");
            var input1 = Console.ReadLine();

            var number1 = 0;
            var isNumber = int.TryParse(input1, out number1);

            if(isNumber) {
                int counter = 12;

                for (int i = 0; i < counter; i++)
                {
                    var a = i + 1;
                    Console.WriteLine($"{input1} * {a} = {number1 * a} ");
            

                }
            }
            else {
                Console.WriteLine("please enter a number not word");
            }



        

            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
