using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0], char.Parse(args[1]), int.Parse(args[2])));
        }

        private static string Decor(string text, char symbol, int amount)
        {
            string symbols = "";
            for (int i = 0; i < amount; i++)
            {
                symbols += symbol;
            }

            return $"{symbols} {text} {symbols}";
        }
    }
}
