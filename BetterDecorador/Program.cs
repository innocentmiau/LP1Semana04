using System;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// The Main function of our program
        /// </summary>
        /// <param name="args">Arguments to generate the proper text for Decor function</param>
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0], char.Parse(args[1]), int.Parse(args[2])));
        }

        /// <summary>
        /// Function that returns a string containing the text surrounded by the symbols amount
        /// </summary>
        /// <param name="text">The text in the middle</param>
        /// <param name="symbol">Which symbol will be used</param>
        /// <param name="amount">The amount of symbols you want</param>
        /// <returns></returns>
        private static string Decor(string text, char symbol, int amount)
        {
            string symbols = "";
            for (int i = 0; i<amount; i++)
            {
                symbols += symbol;
            }
            // symbols text symbols
            return $"{symbols} {text} {symbols}";
        }
    }
}
