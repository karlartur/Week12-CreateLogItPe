using System;
using System.IO;
namespace Quotes
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\Sample\LogItPe21\Quotes.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            Console.WriteLine(dataFromFile[0]);
            Console.WriteLine("How many quotes would you  like to print?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            DisPlayQuotes(dataFromFile, userInput);

        }
        private static void ReadDataFromArray(string[] someArray)
        {
            foreach(string line in someArray)
            {
                Console.WriteLine(line);
            }
        }
        private static void DisPlayQuotes(string[] someArray, int someNumber)
        {
            if (someNumber > someArray.Length - 1)
            {
                someNumber = someArray.Length - 1;
            }
            for (int i = 0; i <= someNumber; i++)
            {
                Console.WriteLine(someArray[i]);
            }
        }
    }
}
