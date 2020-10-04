using System;

namespace Calculator
{
    class Calc
    {
        static void Main(string[] args)
        {
            
            //Initialze the numbers that will be changed to the user input
            
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("Welcome to C# basic calculator!\n");
            Console.WriteLine("Enter the first number, then click Enter.\n");
            
            //Take the user input for the first number
            
            num1 = Convert.ToInt32(Console.ReadLine());
            
            
            Console.WriteLine("Enter the second number, then click Enter.\n");
            
            //Take the user input for the second number
            
            num2 = Convert.ToInt32(Console.ReadLine());
            
            //User inputs the operation.
            
            Console.WriteLine("Choose the operation:");
            Console.WriteLine("+ for Add");
            Console.WriteLine("- for Subtract");
            Console.WriteLine("* for Multiply");
            Console.WriteLine("/ for Divide");
            
            switch (Console.ReadLine())
            {
                case "+":
                    int resulta = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = {resulta}");
                    break;
                    
                case "-":
                    int results = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = {results}");
                    break;
                    
                case "*":
                    int resultm = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = {resultm}");
                    break;
                    
                case "/":
                    int resultd = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = {resultd}");
                    break;
    
                default:
                    
                    //If the user inputs an invalid operation.
                    Console.WriteLine("Error, Invalid Operation. Please Try Again.");
                    break;
            }
            Console.WriteLine("Press any key to Close");
            Console.ReadKey();
        }
    }
}