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
                //Prompt to view calculation history
                Console.WriteLine("Press 'v' to view your calculation history");
                if (Console.ReadLine() == "v")
                {
                    Console.WriteLine("------------------Your Calculation History-----------------");
                    Calculator.History();
                }
                stopApp = true;
                Console.WriteLine("\n"); //generous line spacing
            }
            //return;
        }
    }
}















// using System;

// namespace CalculatorApp
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             //declaring a list of calculation histories.
//             //List<CalculationHistory> calculations = new List<CalculationHistory>();

//             // double firstNum = 0;
//             // double secondNum = 0;
//             double result = 0;
            
//             //collecting user's Nickname
//             Console.WriteLine("Enter a nickname:");

//             //getting user's input from the keyboard and storing it in a variable(nickName).
//             string nickName = Console.ReadLine();

//             //Printing the value of the input value in the variable (nickName).
//             Console.WriteLine("Welcome to My CalculatorApp, " + nickName);

//             Console.WriteLine("Please enter an operator (+, -, *, /, **, root): ");
//             string operation_type = Console.ReadLine();

//             Console.WriteLine("Enter the first number:");
//             double firstNum = Convert.ToDouble(Console.ReadLine()); //gets first input value and converts it to an integer

//             Console.WriteLine("Enter the Second Number:");
//             double secondNum = Convert.ToDouble(Console.ReadLine()); //gets second input value and converts it to an integer

//             //using the switch statements to meet different options/cases
//             switch (operation_type)
//             {
//                 case "+":
//                 {
//                     result = firstNum + secondNum; //performs add operation and saves the answer to result variable
//                     break;
//                 }

//                 case "-":
//                 {
//                     result = firstNum - secondNum; //performs subtract operation and saves the answer to result variable
//                     break;
//                 }

//                 case "*":
//                 {
//                     result = firstNum * secondNum; //performs multiplication operation and saves the answer to result variable
//                     break;
//                 }

//                 case "/":
//                 {   
//                     //use the loop statement to ensure that the user divides with a number other than 0.
//                     while (secondNum == 0)
//                     {
//                         Console.WriteLine("Enter a non-zero divisor: ");
//                         secondNum = Convert.ToDouble(Console.ReadLine());
//                     }
//                     result = firstNum / secondNum; //performs divide operation and saves the answer to result variable
//                     break;
//                 }

//                 case "**":
//                 {
//                     result = Math.Pow(firstNum,secondNum); //performs square operation and saves the answer to result variable
//                     break;
//                 }
//                 case "root":
//                 {
//                     Console.WriteLine("Enter a number:");
//                     double rootNum = Convert.ToDouble(Console.ReadLine());
//                     result = Math.Sqrt(rootNum); //performs the squareroot operation and saves the answer to the result variable
//                     break;
//                 }
//                 default:
//                 {
//                     Console.WriteLine("{0} is an invalid operator", operation_type);
//                     break;
//                 }
//             }
//             Console.WriteLine("Result is " + result); //prints result to the console
//             Console.WriteLine("Press any key to exit the program");
//             Console.ReadKey();
//         }
//     }
// }