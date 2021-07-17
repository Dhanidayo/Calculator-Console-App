﻿using System;
using System.Collections.Generic;

namespace CalculatorApp
{
    public class Calculator
    {

        public double firstNumber { get; set; }
        public double secondNumber { get; set; }
        public string op_type { get; set;}
        public double results { get; set; }

        public override string ToString()
        {
            return $"Your calculation history is: {firstNumber} {op_type} {secondNumber} = {results}";
        }

        
        //method for performing the operations.
        public static double PerformOperation(double firstNum, double secondNum, string operation_type)
        {
            //declaring a list of calculation histories.
            List<Calculator> calculationsHistory = new List<Calculator>();

            double result = 0; //the default value of result.

            //using the switch statements to meet different options/cases
            switch (operation_type)
            {
                case "+":
                {
                    result = firstNum + secondNum; //performs add operation and saves the answer to result variable
                    calculationsHistory.Add(new Calculator() { firstNumber = firstNum, op_type = operation_type, secondNumber =  secondNum, results = result });
                    break;
                }

                case "-":
                {
                    result = firstNum - secondNum; //performs subtract operation and saves the answer to result variable
                    calculationsHistory.Add(new Calculator() { firstNumber = firstNum, op_type = operation_type, secondNumber =  secondNum, results = result });
                    break;
                }

                case "*":
                {
                    result = firstNum * secondNum; //performs multiplication operation and saves the answer to result variable
                    calculationsHistory.Add(new Calculator() { firstNumber = firstNum, op_type = operation_type, secondNumber =  secondNum, results = result });
                    break;
                }

                case "/":
                {   
                    //use the loop statement to ensure that the user divides with a number other than 0.
                    while (secondNum == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        secondNum = Convert.ToDouble(Console.ReadLine());
                    }
                    result = firstNum / secondNum; //performs divide operation and saves the answer to result variable
                    calculationsHistory.Add(new Calculator() { firstNumber = firstNum, op_type = operation_type, secondNumber =  secondNum, results = result });
                    break;
                }

                case "**":
                {
                    result = Math.Pow(firstNum,secondNum); //performs square operation and saves the answer to result variable
                    calculationsHistory.Add(new Calculator() { firstNumber = firstNum, op_type = operation_type, secondNumber =  secondNum, results = result });
                    break;
                }
                case "root":
                {
                    Console.WriteLine("Enter a number:");
                    double rootNum = Convert.ToDouble(Console.ReadLine());
                    result = Math.Sqrt(rootNum); //performs the squareroot operation and saves the answer to the result variable
                    calculationsHistory.Add(new Calculator() { firstNumber = firstNum, op_type = operation_type, secondNumber =  secondNum, results = result });
                    break;
                }
                default:
                {
                    Console.WriteLine("{0} is an invalid operator", operation_type);
                    break;
                }
            }
            Console.WriteLine("----------------------------------------------------");
            //print result to the console
            Console.WriteLine($"Calculation: {firstNum} {operation_type} {secondNum}", firstNum, operation_type, secondNum);
            Console.WriteLine("Your result is "+ result);
            Console.WriteLine("\n");
            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey();
            return 0;
        }

        public static void History()
        {
            foreach (var savedCalculation in calculationsHistory)
            {
                Console.WriteLine(savedCalculation);
            }
        }
    }
}



















// public string nickName { get; set; }
//         public double firstNum { get; set; }
//         public double secondNum { get; set; }
//         public double result { get; set; }
//         public string operation_type { get; set; }

//         public static double CalculationHistory(double firstNumber, double secondNumber, string operation, double results)
//         {
//             firstNum = firstNumber;
//             secondNum = secondNumber;
//             operation_type = operation;
//             result = results;
//         }