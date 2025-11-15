namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую переменную");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную");
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
        static public double Addition(double a, double b)
        {
            return a + b;
        }
        static public double Subtraction(double a, double b)
        {
            return a - b;
        }
        static public double Multiplication(double a, double b)
        {
            return a * b;
        }
        static public double Division(double a, double b)
        {
            return a / b;
        }
    }
}