Console.WriteLine("Vyberte si z menu:");
Console.WriteLine("1. Leaderboard");
Console.WriteLine("2. Options");
Console.WriteLine("3. Exit");
string choice = Console.ReadLine();
switch (choice)
{
    case "1":
        Console.WriteLine("Tady je pořadí nejlepších hráčů...");
        break;
    case "2":
        Console.WriteLine("Co budete chtít nastavit?");
        break;
    case "3":
        Console.WriteLine("Uzavírám program...");
        break;
    default:
        Console.WriteLine("Ouha! Zkuste to znovu.");
        break;
    
}
