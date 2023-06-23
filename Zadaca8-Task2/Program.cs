using System.ComponentModel;

namespace Zadaca8_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new() { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The numbers are: ");
            Console.ResetColor();

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            List<int> numbersSquares = numbers.Select(n => n * n).ToList();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The squares of numbers are: ");
            Console.ResetColor();

            foreach (int square in numbersSquares)
            {
                Console.WriteLine(square);
            }
        }
    }
}