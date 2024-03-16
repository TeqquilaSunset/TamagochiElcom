using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagochiElcom
{
    internal static class UserInteraction
    {
        public static void ErrorMessage(string message)
        {
            Console.WriteLine("\nThere is a problem:");
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static string GetNameTamagochi()
        {
            const int maxNameLength = 10;
            string inputName;

            while (true)
            {
                Console.WriteLine($"Hello, please input name for your tamagochi (name length can't be more than {maxNameLength}).");
                Console.Write("Name:");
                inputName = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(inputName))
                {
                    ErrorMessage("Input is null or empty. Please provide a valid name.");
                    continue;
                }

                if (inputName.Length <= maxNameLength)
                {
                    return inputName;
                }

                ErrorMessage($"Your name is more than {maxNameLength} characters long. Please provide a shorter name.");
            }
        }

        public static void EndGame()
        {
            string message = "\r\n░██████╗░░█████╗░███╗░░░███╗███████╗  ░█████╗░██╗░░░██╗███████╗██████╗░" +
                             "\r\n██╔════╝░██╔══██╗████╗░████║██╔════╝  ██╔══██╗██║░░░██║██╔════╝██╔══██╗" +
                             "\r\n██║░░██╗░███████║██╔████╔██║█████╗░░  ██║░░██║╚██╗░██╔╝█████╗░░██████╔╝" +
                             "\r\n██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░  ██║░░██║░╚████╔╝░██╔══╝░░██╔══██╗" +
                             "\r\n╚██████╔╝██║░░██║██║░╚═╝░██║███████╗  ╚█████╔╝░░╚██╔╝░░███████╗██║░░██║" +
                             "\r\n░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝  ░╚════╝░░░░╚═╝░░░╚══════╝╚═╝░░╚═╝";

            Console.WriteLine(message);
            Console.WriteLine("\n\nIt looks like your pet is sick, try better next time");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
