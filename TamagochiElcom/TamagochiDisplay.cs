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
            string border = "##########################################";
            string name = _tamagochi.Name;
            int totalWidth = border.Length;
            int leftSpaces = (totalWidth - name.Length) / 2;
            int rightSpaces = totalWidth - name.Length - leftSpaces;
            Console.WriteLine(border);
            Console.WriteLine($"##{new string(' ', leftSpaces - 2)}{name}{new string(' ', rightSpaces -2)}##");
            Console.WriteLine(border);

            Console.WriteLine($"Health   : {CreatePlusMinusString(_tamagochi.Health),-12} | {_tamagochi.Health,-2}/10");
            Console.WriteLine($"Hunger   : {CreatePlusMinusString(_tamagochi.Hunger),-12} | {_tamagochi.Hunger,-2}/10");
            Console.WriteLine($"Fatigue  : {CreatePlusMinusString(_tamagochi.Fatigue),-12} | {_tamagochi.Fatigue,-2}/10");
            Console.WriteLine($"Happiness: {CreatePlusMinusString(_tamagochi.Happiness),-12} | {_tamagochi.Happiness,-2}/10");
        }

        public void PrintVariants()
        {
            Console.WriteLine("\nAvailable actions:");
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Sleep");
            Console.WriteLine("3. Play");
            Console.WriteLine("4. Heal");
            Console.WriteLine("0. Exit");
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
