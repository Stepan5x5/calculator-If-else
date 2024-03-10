using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, total;
            string action, multiplication, division, addition, subtraction;
            Console.WriteLine("Вы открыли консольный калькулятор.");
            Console.WriteLine("Введите первое число:");
            number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Выбери что ты хочешь сделать с этими числами, например: \n '*' - умножение \n '/' - деление \n '+' - сложение \n '-' - вычетание");
            action = Console.ReadLine();
            multiplication = "*";
            division = "/";
            addition = "+";
            subtraction = "-";

            if (action == multiplication)
            {
                total = number1 * number2;
                Console.WriteLine(total);
            }
            else if (action == division)
            {
                total = (number1 / number2);
                Console.WriteLine(total);
            }
            else if (action == addition)
            {
                total = (number1 + number2);
                Console.WriteLine(total);
            }
            else if (action == subtraction)
            {
                total = (number1 - number2);
                Console.WriteLine(total);
            }
            Console.ReadLine();
        }
    }
}
