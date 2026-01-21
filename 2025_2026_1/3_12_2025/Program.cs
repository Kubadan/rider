/*
double ConvertToEuro(double czk)
{
    return czk / 24.13;
}

Console.WriteLine("How many CZK");
string input = Console.ReadLine();
double czk = double.Parse(input);

double euro = ConvertToEuro(czk);
Console.WriteLine("Hodnota v EUR:" + euro);
*/


/*
bool CheckPassword(string password)
{
    return password.Length > 8 && !password.Contains("password");
}
Console.WriteLine("Enter your password");
string password = Console.ReadLine();
Console.WriteLine(CheckPassword(password));
*/


void FrameWord(string word)
{
    for (int i = 0; i < word.Length + 4; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    Console.Write("* " + word + " *");
    Console.WriteLine();
    for (int i = 0; i < word.Length + 4; i++)
    {
        Console.Write("*");
    }
}
FrameWord("Programování");