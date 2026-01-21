// Uživatelské zadání
Console.WriteLine("První číslo");
string stringFirst = Console.ReadLine();

Console.WriteLine("Operátor (+-*/");
string operand = Console.ReadLine();

Console.WriteLine("Druhé číslo");
string stringSecond = Console.ReadLine();


// Konverze na float
float first = float.Parse(stringFirst);
float second = float.Parse(stringSecond);


// Podmínky
if (operand == "+")
{
    Console.WriteLine(first + second);
}
else if (operand == "-")
{
    Console.WriteLine(first - second);
}

else if (operand == "*")
{
    Console.WriteLine(first * second);
}
else if (operand == "/")
{
    Console.WriteLine(first / second);
    if (second == 0)
        Console.WriteLine("NEPOVOLENA OPERACE!");
}
else
{
    Console.WriteLine("INVALIDNI OPERACE");
}



/*
switch (operand)
{
    case "+":
        Console.WriteLine("plus");
        break;
    case "-":
        Console.WriteLine("minus");
        break;
    case "*":
        Console.WriteLine("nasobeni");
        break;
    case "/": 
        Console.WriteLine("deleni");
        break;
    default:
        Console.WriteLine(Operace neznama);
        break;
}
*/


