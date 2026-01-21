Console.WriteLine("Prosím zadejte vaši známku: ");
string grade = Console.ReadLine();

/*
if (grade == "1")
{
    Console.WriteLine("Výborně");
}
else if (grade == "2")
{
    Console.WriteLine("Chválitebně");
}
else if (grade == "3")
{
    Console.WriteLine("Dobré");
}
else if (grade == "4")
{
    Console.WriteLine("Dostatečně");
}
else if (grade == "5")
{
    Console.WriteLine("Nedostatečně");
}
else
{
    Console.WriteLine("Neplatná známka");
}
*/

int IntGrade = int.Parse(grade);
switch (IntGrade)
{
    case 1:
        Console.WriteLine("Výborně");
        break;
    case 2:
        Console.WriteLine("Chválitebně");
        break;
    case 3:
        Console.WriteLine("Dobré");
        break;
    case 4:
        Console.WriteLine("Dostatečné");
        break;
    case 5:
        Console.WriteLine("Nedostatečné");
        break;
    default:
        Console.WriteLine("Neplatná známka");
        break;

}
