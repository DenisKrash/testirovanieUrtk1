using System;

namespace izmkalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую переменную");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите первую переменную");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите необходимую операцию(+, -, *, /)");
            string c = Console.ReadLine();
            if (c == "+")
            {
                Console.WriteLine($" Результат сложения: {Addition(a, b)}");
            }
            else if (c == "-")
            {
                Console.WriteLine($" Результат сложения: {Subtraction(a, b)}");
            }
            else if (c == "*")
            {
                Console.WriteLine($" Результат сложения: {Multiplication(a, b)}");
            }
            else if (c == "/")
            {
                Console.WriteLine($" Результат сложения: {Division(a, b)}");
            }
        }
        static public double Addition(double a, double b)//было неправильное имя метода(Subtraction), должно быть Addition; был неправильный тип данных bool,должен быть double
        {
            return a + b;//неправильный возврат значения(a + a + b),должно быть a+b;
        }
        static public double Subtraction(double a, double b)//был неправильный тип данных (int), должен быть double;
        {
            return a - b;//неправильный возврат значения(a - b + 64),должно быть a-b;
        }
        static public double Multiplication(double a, double b)
        {
            return a * b;
        }
        static public double Division(double a, double b)//неправильное название метода (Divisionn), должно быть Division;неправильный тип данных в аргументе (boool a),должно быть double a;

        {
            return a / b;//была неправильная операция (**),должно быть /;
        }
    }

}
