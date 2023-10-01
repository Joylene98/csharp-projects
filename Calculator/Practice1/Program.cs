using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        /**
        * Takes two string values.
        * If the string does contain a decimal.
        * The strings are converted into decimals and
        * the method adds the decimals together.
        * If the string value doesn't contain a decimal, then 
        * it converts them into integers and 
        * adds them together.
        * 
        */
        static void Add(string x, string y)
        {
            Console.Write(x + " + " + y + " = ");

            if (x.Contains(".") && y.Contains("."))
            {
                Console.WriteLine(Convert.ToDecimal(x) + Convert.ToDecimal(y));
            }
            else if(x.Contains(".") && !y.Contains("."))
            {

                Console.WriteLine(Convert.ToDecimal(x) + Convert.ToInt32(y));

            }
            else if(!x.Contains(".") && y.Contains("."))
            {
                Console.WriteLine(Convert.ToInt32(x) + Convert.ToDecimal(y));
            }
            else
            {
                Console.WriteLine(Convert.ToInt32(x) + Convert.ToInt32(y));
            }

        }

        /**
        * Takes two string inputs. 
        * Checks if string value contains a decimal. 
        * If it does, it converts inputs into decimal.
        * Else, it converts string value into integer.
        * Then subtracts values from each other.
        * 
        */
        static void Subtract(string x, string y)
        {
            Console.Write(x + " - " + y + " = ");

            if (x.Contains(".") && y.Contains("."))
            {
                Console.WriteLine(Convert.ToDecimal(x) - Convert.ToDecimal(y));
            }
            else if(!x.Contains(".") && y.Contains("."))
            {
                Console.WriteLine(Convert.ToInt32(x) - Convert.ToDecimal(y));

            }
            else if(x.Contains(".") && !x.Contains("."))
            {
                Console.WriteLine(Convert.ToDecimal(x) - Convert.ToInt32(y));
            }
            else
            {
                Console.WriteLine(Convert.ToInt32(x) - Convert.ToInt32(y));
            }
        }

        /**
        * Takes two string inputs. 
        * Checks if string value contains a decimal. 
        * If it does, it converts input to decimal.
        * Else, it converts string value into integer.
        * Then multiply two values together.
        * 
        */
        static void Multiply(string x, string y)
        {
            Console.Write(x + " * " + y + " = ");

            if (x.Contains(".") && y.Contains("."))
            {
                Console.WriteLine(Convert.ToDecimal(x) * Convert.ToDecimal(y));
            }
            else if (!x.Contains(".") && y.Contains("."))
            {
                Console.WriteLine(Convert.ToInt32(x) * Convert.ToDecimal(y));

            }
            else if (x.Contains(".") && !x.Contains("."))
            {
                Console.WriteLine(Convert.ToDecimal(x) * Convert.ToInt32(y));
            }
            else
            {
                Console.WriteLine(Convert.ToInt32(x) * Convert.ToInt32(y));
            }

        }

        /**
        * Takes two string inputs. 
        * Checks if string value contains a decimal. 
        * If it does, it converts input to decimal.
        * Else, the method converts both string values into 
        * integer.
        * Then divides first number with second
        * number together.
        * 
        */

        static void Divide(string x, string y)
        {
            Console.Write(x + " / " + y + " = ");

            if (x.Contains(".") && y.Contains("."))
            {
                Console.WriteLine(Convert.ToDecimal(x) / Convert.ToDecimal(y));
            }
            else if (!x.Contains(".") && y.Contains("."))
            {
                Console.WriteLine(Convert.ToInt32(x) / Convert.ToDecimal(y));

            }
            else if (x.Contains(".") && !x.Contains("."))
            {
                Console.WriteLine(Convert.ToDecimal(x) / Convert.ToInt32(y));
            }
            else
            {
                Console.WriteLine(Convert.ToInt32(x) / Convert.ToInt32(y));
            }

        }

        /**
        * 
        * Takes two string inputs. 
        * Checks if string value contains a decimal. 
        * If it does, it converts inputs to decimal.
        * Else, the method converts string value into 
        * integer.
        * Then it returns the remainder of dividing 
        * x and y.
        * 
        */
        static void Remainder(string x, string y)
        {
            Console.Write(x + " % " + y + " = ");

            if (x.Contains(".") && y.Contains("."))
            {
                Console.WriteLine(Convert.ToDecimal(x) % Convert.ToDecimal(y));
            }
            else if (!x.Contains(".") && y.Contains("."))
            {
                Console.WriteLine(Convert.ToInt32(x) % Convert.ToDecimal(y));

            }
            else if (x.Contains(".") && !x.Contains("."))
            {
                Console.WriteLine(Convert.ToDecimal(x) % Convert.ToInt32(y));
            }
            else
            {
                Console.WriteLine(Convert.ToInt32(x) % Convert.ToInt32(y));
            }
            }
        /**
            * Takes two input strings.
            * Converts string values into double values.
            * Returns the result of x to the power y.
            * 
            */
        static void Power(string x, string y)
        { 
            Console.Write( x + " to power of " + y +  " = ");

            if (x.Contains(".") && y.Contains("."))
            {
                Console.WriteLine(Math.Pow(Convert.ToDouble(x), Convert.ToDouble(y)));
            }
            else if(!x.Contains(".") && y.Contains("."))
            {
                Console.WriteLine(Math.Pow(Convert.ToInt32(x), Convert.ToDouble(y)));
            }
            else if(x.Contains(".") && !y.Contains("."))
            {
                Console.WriteLine(Math.Pow(Convert.ToDouble(x), Convert.ToInt32(y)));
            }
            else
            {
                Console.WriteLine(Math.Pow(Convert.ToInt32(x), Convert.ToInt32(y)));
            }
        }

        /**
            * Converts string values into double or integer.
            * Returns the smallest number between x and y
            * 
            */
        static void Min(string x, string y)
        {
            Console.Write("The smallest number is = ");

            if (x.Contains(".") && y.Contains("."))
            {
                Console.WriteLine(Math.Min(Convert.ToDouble(x), Convert.ToDouble(y)));
            }
            else if(!x.Contains(".") && y.Contains("."))
            {
                Console.WriteLine(Math.Min(Convert.ToInt32(x), Convert.ToDouble(y)));
            }
            else if(x.Contains(".") && !y.Contains("."))
            {
                Console.WriteLine(Math.Min(Convert.ToDouble(x), Convert.ToInt32(y)));
            }    
            else
            {
                Console.WriteLine(Math.Min(Convert.ToInt32(x), Convert.ToInt32(y)));
            }
        }

        /**
        * Converts string values into double or int.
        * Returns the largest number between x and y.
        * 
        */
        static void Max(string x, string y)
        {
            Console.Write("The largest number is = ");

            if (x.Contains(".") && y.Contains("."))
            {
                Console.WriteLine(Math.Max(Convert.ToDouble(x), Convert.ToDouble(y)));
            }
            else if (!x.Contains(".") && y.Contains("."))
            {
                Console.WriteLine(Math.Max(Convert.ToInt32(x), Convert.ToDouble(y)));
            }
            else if (x.Contains(".") && !y.Contains("."))
            {
                Console.WriteLine(Math.Max(Convert.ToDouble(x), Convert.ToInt32(y)));
            }
            else
            {
                Console.WriteLine(Math.Max(Convert.ToInt32(x), Convert.ToInt32(y)));
            }
        }

        /**
        * Checks for the string value of the operator entered by user. 
        * Calls the method associated to the string value.
        * Returns an error message if an invalid operator 
        * is called. 
        * 
        */
        static void getOp(string x, string y, string op)
        {
            switch(op)
            {
                case "+":
                    Add(x, y);
                    break;

                case "-":
                    Subtract(x, y);
                    break;

                case "*":
                    Multiply(x, y);
                    break;

                case "/":
                    Divide(x, y);
                    break;

                case "%":
                    Remainder(x, y);
                    break;

                case "^":
                    Power(x, y);
                    break;

                case "M":
                    Max(x, y);
                    break;

                case "m":
                    Min(x, y);
                    break;

                default:
                    Console.WriteLine("This is an invalid operator, please enter a valid operator");
                    break;
            }

        }
        /**
        * Prompts a user to enter two numbers and an operation 
        * Performs an arithmetic picked by the user 
        * Outputs result of the calculation and 
        * prints out result onto screen.
        * 
        */
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            string num1 = Console.ReadLine();

            Console.Write("Enter an operator: i.e. (-, +, / *)  ");
            string op = Console.ReadLine();

            Console.Write("Enter another number: ");
            string num2 = Console.ReadLine();

            bool isExpression;
            int index = 0;
            string n;


            if (num1[index] == '(')
            {
                isExpression = true;
                index++;
                if (num1[index] != '+' || num1[index] != '*' || num1[index] != '-' || num1[index] != '/'
                    || num1[index] != '^' || num1[index] != '%' || num1[index] != 'm' || num1[index] != 'M')
                {
                    n = Convert.ToString(num1[index]);
                    getOp(n, num2, op);
                }  
            }
            else if (num2[index] == '(') 
            {                        
                isExpression = true; 

                index++;
                if (num2[index] != '+' || num2[index] != '*' || num2[index] != '-' || num2[index] != '/'
                    || num2[index] != '^' || num2[index] != '%' || num2[index] != 'm' || num2[index] != 'M')
                {
                    n = Convert.ToString(num2[index]);
                    getOp(num1, n, op);
                }
            }
            else
            {
                isExpression = false;
                getOp(num1, num2, op);
            }
           
            Console.ReadLine();
        }
    }
}

