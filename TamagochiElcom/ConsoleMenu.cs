using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagochiElcom
{
    internal class ConsoleMenu
    {
        public void PrintHud(ITamagochi tamagochi)
        {
            Console.WriteLine("##########################################");
            Console.WriteLine($"                  {tamagochi.Name}                    ");
            Console.WriteLine("##########################################");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Health: {NumberToStringFromOutput(tamagochi.Health)} | {tamagochi.Health}/10");
            Console.WriteLine($"Hunger: {NumberToStringFromOutput(tamagochi.Hunger)} | {tamagochi.Hunger}/10");
            Console.WriteLine($"Fatigue: {NumberToStringFromOutput(tamagochi.Fatigue)} | {tamagochi.Fatigue}/10");
        }

        private string NumberToStringFromOutput(int number)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                if (i < number)
                    sb.Append('+');
                else
                    sb.Append('-');
            }
            return sb.ToString();
        }
    }
}
