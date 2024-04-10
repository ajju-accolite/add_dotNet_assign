

namespace ConsoleAppAssign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int number2 = int.Parse(Console.ReadLine());
            int result = AddNumbers(number1, number2);

            Console.WriteLine("The sum of " + number1 + " and " + number2 + " is " + result);

        }
        public static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}

