using TamagochiElcom;

var inputName = UserInteraction.GetNameTamagochi();
Tamagochi tamagochi = new Tamagochi(inputName);
TamagochiDisplay menu = new TamagochiDisplay(tamagochi);
Console.Clear();

while (tamagochi.Health > 0)
{
    menu.PrintHud();
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
            UserInteraction.PrintErrorMessage("Uknown variant");
            break;
    }
    Console.Clear();
}

Console.WriteLine($"Sorry, {tamagochi.Name} is dead :( ");

