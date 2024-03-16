using TamagochiElcom;

while (true)
{
    Console.Clear();

    var inputName = UserInteraction.GetNameTamagochi();
    Tamagochi tamagochi = new Tamagochi(inputName);
    TamagochiDisplay menu = new TamagochiDisplay(tamagochi);
    Console.Clear();

    while (tamagochi.Health > 0)
    {
        menu.PrintHud();
        menu.PrintVariants();

        string? selectedVariant = Console.ReadLine();
        switch (selectedVariant)
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
            case "4":
                tamagochi.Heal();
                break;
            case "0":
                return;
            default:
                UserInteraction.ErrorMessage("Unknown variant");
                break;
        }
        Console.Clear();
    }

    UserInteraction.EndGame();

    Console.Clear();
    Console.WriteLine("Input any key to start a new game or 0 to exit.");
    string input = Console.ReadLine();
    if (input == "0")
        return;
}



