namespace NawatechTest2
{
    using System;

    namespace Project2_TargetFinder
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] numbers = { 1, 2, 3, 4, 5 };
                int target = 4;

                bool found = false;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == target)
                    {
                        Console.WriteLine($"Target has been reached in index number {i}");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Target not found in array");
                }

                Console.ReadLine();
            }
        }
    }

}
