using TamagochiElcom;

ConsoleMenu menu = new ConsoleMenu();
var inputName = menu.GetNameTamagochi();
Tamagochi tamagochi = new Tamagochi(inputName);

Console.Clear();

while (tamagochi.Health > 0)
{
    menu.PrintHud(tamagochi);
    menu.PrintVariants();

    string readNmber = Console.ReadLine();
    switch (readNmber)
    {
        case "1":
            tamagochi.Feed();
            break;
        case "2":
            tamagochi.Sleep();
            break;
        case "3":
            tamagochi.Play();
            break;
        default:
            menu.PrintErrorMessage("Uknown variant");
            break;
    }
    Console.Clear();
}

Console.WriteLine($"Sorry, {tamagochi.Name} is dead :( ");

