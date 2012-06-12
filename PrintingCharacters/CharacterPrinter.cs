using System;

namespace CharacterPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parameters: CharacterPrinter.exe <start_range> <end_range>");

            if (args.Length == 2)
            {
                var startRange = int.Parse(args[0]);
                var endRange = int.Parse(args[1]);

                PrintNumericValuesAsCharacterEquivalents(startRange, endRange);
            }
            else
            {
                Console.WriteLine("Try again! \nEnter start_range and end_range, fool...!");
            }
        }

        private static void PrintNumericValuesAsCharacterEquivalents(int startRange, int endRange)
        {
            for (var counter = startRange; counter < endRange; counter++)
            {
                var value = (char) counter;
                Console.WriteLine("{0} = {1}", counter, value);
            }
        }
    }
}
