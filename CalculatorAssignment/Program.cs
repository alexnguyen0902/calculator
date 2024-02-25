using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            DeclareNum();
        }

        static void Replay()
        {
            DeclareNum();
        }


        static void DeclareNum()
        {
            Console.WriteLine("Choose a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose a symbol : + - * / ^ ");
            char symbol = Convert.ToChar(Console.ReadLine());
            if (symbol == '+')
            {
                Plus(num1, num2);
            }
            else if (symbol == '-')
            {
                Minus(num1, num2);
            }
            else if (symbol == '*')
            {
                Multiply(num1, num2);
            }
            else if (symbol == '/')
            {
                Divide(num1, num2);
            }
            else if (symbol == '^')
            {
                Power(num1, num2);
            }
        }

        static void Plus(double num1, double num2)
        {
            Console.WriteLine("Result: ");
            Console.WriteLine(num1 + num2);
            Console.WriteLine("Replay? (Y/N)");
            char replayQuestion = Convert.ToChar(Console.ReadLine());
            if (replayQuestion.ToString().ToUpper() == "Y") Replay();
        }

        static void Minus(double num1, double num2)
        {
            Console.WriteLine("Result: ");
            Console.WriteLine(num1 - num2);
            Console.WriteLine("Replay? (Y/N)");
            char replayQuestion = Convert.ToChar(Console.ReadLine());
            if (replayQuestion.ToString().ToUpper() == "Y") Replay();
        }

        static void Multiply(double num1, double num2)
        {
            Console.WriteLine("Result: ");
            Console.WriteLine(num1 * num2);
            Console.WriteLine("Replay? (Y/N)");
            char replayQuestion = Convert.ToChar(Console.ReadLine());
            if (replayQuestion.ToString().ToUpper() == "Y") Replay();
        }

        static void Divide(double num1, double num2)
        {
            Console.WriteLine("Result ");
            Console.WriteLine(num1 / num2);
            Console.WriteLine("Replay? (Y/N)");
            char replayQuestion = Convert.ToChar(Console.ReadLine());
            if (replayQuestion.ToString().ToUpper() == "Y") Replay();
        }

        static void Power(double num1, double num2)
        {
            Console.WriteLine("Result: ");
            Console.WriteLine(Math.Pow(num1, num2));
            Console.WriteLine("Replay? (Y/N)");
            char replayQuestion = Convert.ToChar(Console.ReadLine());
            if (replayQuestion.ToString().ToUpper() == "Y") Replay();
        }
    }
}
