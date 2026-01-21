//input uživatele
Console.WriteLine("FizzBuzz! Zadejte číslo: ");
string strInput = Console.ReadLine();
int input = int.Parse(strInput);


//podmínky
if (input % 3 == 0 && input % 5 == 0)
{
    Console.WriteLine("FizzBuzz!");
}
else if (input % 3 == 0)
{
    Console.WriteLine("Fizz!");
}
else if (input % 5 == 0)
{
    Console.WriteLine("Buzz!");
}
else
{
    Console.WriteLine(input);
}


