//CYKLUS
/*
while (true);
{
    string s = Console.ReadLine();

    if (s == "konec")
    {
        break;
    }
}
Console.WriteLine("program finished");
 */

//DO CYKLUS
/*
do
{
    string s = Console.ReadLine();

    if (s == "konec")
    {
        break;
    }
} while (true);

Console.WriteLine("program finished");
*/

// FOR CYKLUS
/*
for ( int i = 0 ; i < 10  ; i++ )
{
    Console.WriteLine("ahoj");
}
*/


//CYKLUS PRO +1,2,3... K PROMĚNNÉ
/*
int target = 10;
int sum = 0;
for (int i = 0; i <= 10; i++)
    sum += i;
Console.WriteLine(sum);
*/

//ROZLIŠOVÁK
/*
int start = 0;
int end = 10;

if (start > end)
{
    Console.WriteLine("nemožné");
}


for (int i = start; i <= end; i++)
{
    start += i;
    if (i % 2 == 1)
    {
        Console.WriteLine(i + " Liche");
    }
    else
    {
        Console.WriteLine(i + " Sude");
    }
}
*/

//GENERÁTOR ČÍSEL
/*
Random random = new Random();
int target = random.Next(1, 11); // Vygeneruje 1-10


for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Zadej Číslo");
    string strRead = Console.ReadLine();
    int read = Int32.Parse(strRead);


    if (read == target)
    {
        Console.WriteLine("Uhádl jsi");
        break;
    }
    else if (read != target && read < target)
    {
        Console.WriteLine("Pokus strhnut - Zkus to znovu");
        continue;
    }
    else if (read > target)
    {
        Console.WriteLine("Pokus strhnut - Drž se mezi čísly 1-10");
    }
}
*/

//STROM ČISEL
/*
int size = 7;
for (int i = 1; i <= size; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write($"{j}");
    }
    Console.WriteLine();
}
*/


for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Vyberte si z menu:");
    Console.WriteLine("1. Leaderboard");
    Console.WriteLine("2. Options");
    Console.WriteLine("3. Exit");
    string strRead = Console.ReadLine();
    int read = Int32.Parse(strRead);
    if (read < 1 || read > 4)
    {
        break;
    }
    if (read == 1)
    {
        Console.WriteLine("neco");
    }
    else if (read == 2)
    {
        Console.WriteLine("ahoj");
    }

    else if (read == 3)
    {
        Console.WriteLine("Vybrali jste '3'");
    }
}