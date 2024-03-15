using System.Text;

namespace TamagochiElcom
{
    internal class ConsoleMenu
    {
        public void PrintHud(ITamagochi tamagochi)
        {
            Console.WriteLine("##########################################");
            Console.WriteLine($"                  {tamagochi.Name}                    ");
            Console.WriteLine("##########################################\n\n");
            Console.WriteLine($"Health : {CreatePlusMinusString(tamagochi.Health),-15} | {tamagochi.Health}/10");
            Console.WriteLine($"Hunger : {CreatePlusMinusString(tamagochi.Hunger),-15} | {tamagochi.Hunger}/10");
            Console.WriteLine($"Fatigue: {CreatePlusMinusString(tamagochi.Fatigue),-15} | {tamagochi.Fatigue}/10");
        }

        public void PrintVariants()
        {
            Console.WriteLine("\nAvailable actions:");
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Sleep");
            Console.WriteLine("3. Play");
            Console.Write("\nEnter your choice: ");
        }

        public void PrintErrorMessage(string message)
        {
            Console.WriteLine("\nThere is a problem:");
            Console.WriteLine(message);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public string GetNameTamagochi()
        {
            const int maxNameLength = 10;
            string inputName;

            while (true)
            {
                Console.WriteLine($"Hello, please input name for your tamagochi (name length can't be more than {maxNameLength}): ");
                inputName = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(inputName))
                {
                    PrintErrorMessage("Input is null or empty. Please provide a valid name.");
                    continue;
                }

                if (inputName.Length <= maxNameLength)
                {
                    return inputName;
                }

                PrintErrorMessage($"Your name is more than {maxNameLength} characters long. Please provide a shorter name.");
            }
        }

        private string CreatePlusMinusString(int number)
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
