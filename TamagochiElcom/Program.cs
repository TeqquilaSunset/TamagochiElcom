using TamagochiElcom;

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
            UserInteraction.PrintErrorMessage("Uknown variant");
            break;
    }
    Console.Clear();
}

string message = "GAME OVER";
int screenWidth = Console.WindowWidth;
int messageWidth = message.Length;
int leftMargin = (screenWidth - messageWidth) / 2;

Console.SetCursorPosition(leftMargin, Console.CursorTop);
Console.WriteLine(message);

