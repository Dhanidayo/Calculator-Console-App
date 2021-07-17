using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {            
            bool stopApp = false;
            
            //collecting user's Nickname
            Console.WriteLine("Enter a nickname:");

            //getting user's input from the keyboard and storing it in a variable(nickName).
            string nickName = Console.ReadLine();

            Console.WriteLine("\n---------------------------------------");

            //Printing the value of the input value in the variable (nickName).
            Console.WriteLine("Welcome to My CalculatorApp, " + nickName);

            Console.WriteLine("---------------------------------------\n");

            while (!stopApp)
            {
                //declare variables and set to zero.
                string firstNum = "";
                string secondNum = "";
                double result = 0;

                //Ask the user to enter an operator
                Console.WriteLine("Please enter an operator (+, -, *, /, **, root): ");
                string operation_type = Console.ReadLine();

                //get the first input value
                Console.WriteLine("Enter the first number: ");
                firstNum = Console.ReadLine();

                double convertFirstNum = 0;
                while (!double.TryParse(firstNum, out convertFirstNum))
                {
                    Console.WriteLine("This is not a valid input. Please enter an integer value: ");
                    firstNum = Console.ReadLine();
                }

                //get the second input value
                Console.WriteLine("Enter the second number: ");
                secondNum = Console.ReadLine();

                double convertSecondNum = 0;
                while (!double.TryParse(secondNum, out convertSecondNum))
                {
                    Console.WriteLine("This is not a valid input. Please enter an integer value: ");
                    secondNum = Console.ReadLine();
                }

                try
                {
                    result = Calculator.PerformOperation(convertFirstNum, convertSecondNum, operation_type);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error. \n");
                    }
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine("Oops! An exception occured while trying to perform the math operation. \n - Details: "+ ex.Message);
                }
                Console.WriteLine("----------------------------------------------------\n");
                Console.WriteLine("Press 'c' to continue doing calculations");
                Console.WriteLine("Press 'v' to view your calculation history");
                Console.WriteLine("Press CTRL+C to exit the program.");
                if (Console.ReadLine() == "v")
                {
                    Console.WriteLine("------------------Your Calculation History-----------------");
                    Calculator.History();
                }
                if (Console.ReadLine() == "c")
                {
                    stopApp = true;
                }
                // else if (Console.ReadLine() == "e")
                // {
                //  stopApp = false;
                // }
            }
            //return;
        }
    }
}
