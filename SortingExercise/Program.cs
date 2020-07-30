using System;

/// <summary>
/// Sorting exercise using a method other than the built in functions or a generic sort algorithm
/// Author: Niel Langenhoven
/// Date: 29 July 2020
/// </summary>
namespace SortingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an instance of the custom sort class using the factory.
            // other sort types (built-in libraries or a generic sort algorithm) can be created and then instantiated via the factory 
            var sortingClass = SortFactory.Build(SortTypes.Custom);

            bool continueToSort = true;

            do
            {
                Console.WriteLine("Please enter any string to sort:");

                string input = Console.ReadLine();

                var sortResult = sortingClass.Sort(input);

                Console.WriteLine($"The sorted string is: {sortResult.SortedString}\n");

                Console.WriteLine("Press Enter to sort another string.\n");

                var key = Console.ReadKey();

                if (key.Key != ConsoleKey.Enter)
                {
                    continueToSort = false;
                }
            }
            while (continueToSort);
        }
    }
}
