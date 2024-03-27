using System;
namespace OddEvenNumbers
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print("Numbers", numbers);
            Print("Even Numbers", numbers.Where(x=>IsEven(x)));
            Print("Odd Numbers", numbers.Where(x => IsOdd(x)));



        }
        static void Print(string title,IEnumerable<int>numbers)
        {
            Console.WriteLine();
            Console.Write($"{title}: [ ");
            foreach (var n in numbers)
            {
                Console.Write($"{n},");

            }
            Console.Write(" ]");
            Console.WriteLine();
        }
        static bool IsOdd(int number)
        {
            if (number % 2 != 0)
                return true;
            else 
                return false;
        }
        static bool IsEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }
    }
}