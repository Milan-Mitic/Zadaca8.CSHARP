namespace Zadaca8_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numberQ = new Queue<int>();

            string userInput;
            do
            {
                Console.WriteLine("Enter a number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("You entered: " + number);

                numberQ.Enqueue(number);

                Console.WriteLine("Do you want enter another number? (y/n)");
                userInput = Console.ReadLine();
            } while (userInput == "y");

            Console.WriteLine("Your input numbers are: ");

            while (numberQ.Count > 0)
            {
                int number1 = numberQ.Dequeue();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(number1);                
                Console.ResetColor();
            }
        }
    }
}