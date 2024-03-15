using System.Text;

namespace TamagochiElcom
{
    internal class TamagochiDisplay
    {
        ITamagochi _tamagochi;

        public TamagochiDisplay(ITamagochi tamagochi)
        {
            _tamagochi = tamagochi;
        }

        public void PrintHud()
        {
            Console.WriteLine("##########################################");
            Console.WriteLine($"{_tamagochi.Name, 15}");
            Console.WriteLine("##########################################\n\n");
            Console.WriteLine($"Health : {CreatePlusMinusString(_tamagochi.Health),-15} | {_tamagochi.Health}/10");
            Console.WriteLine($"Hunger : {CreatePlusMinusString(_tamagochi.Hunger),-15} | {_tamagochi.Hunger}/10");
            Console.WriteLine($"Fatigue: {CreatePlusMinusString(_tamagochi.Fatigue),-15} | {_tamagochi.Fatigue}/10");
        }

        public void PrintVariants()
        {
            Console.WriteLine("\nAvailable actions:");
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Sleep");
            Console.WriteLine("3. Play");
            Console.Write("\nEnter your choice: ");
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
