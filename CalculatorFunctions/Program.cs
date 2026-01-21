double Calculate(double vysledek)
{
    Console.WriteLine("Zadej první číslo");
    double input1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Zadej druhé číslo");
    double input2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Zadej operátora");
    string input3 = Console.ReadLine();
    if (input3 == "+")
    {
        return input1 + input2;
    } 
    if (input3 == "-")
    {
        return input1 - input2;
    }
    if (input3 == "*")
    {
        return input1 * input2;
    }
    if (input3 == "/")
    {
        return input1 / input2;
    }
    return 0;
}


Console.WriteLine(Calculate(vysledek:0));