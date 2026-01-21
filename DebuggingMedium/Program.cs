
// Úkol 1 - Funkce s návratovou hodnotou

int Bigger(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

Console.WriteLine("Zadej číslo: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Zadej číslo: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(Bigger(a, b));



// Úkol 2 - Sudé nebo liché
bool IsEven(int number)
{
    if (number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Zadej číslo: ");
int n = int.Parse(Console.ReadLine());
if (IsEven(n))
{
    Console.WriteLine("Sudé");
}
else
{
    Console.WriteLine("Liché");
}



// Úkol 3 - Odpočítávání
void Countdown(int n)
{
    while (n > 0)
    {
        n = n - 1;
        Console.WriteLine(n + 1);
    }
}
Countdown(10);


// Úkol 4 - Součet čísel
int SumFromOne(int n)
{
    int sum = 0;
    for (int i = 0; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine(SumFromOne(10));


// Úkol 5 - Mini menu

void Menu()
{
    Console.WriteLine("Vítejte");
    Console.WriteLine("Prosím zvolte si jednu z možností");
    Console.WriteLine("1. Pozdrav");
    Console.WriteLine("2. Suma dvou čísel");
    Console.WriteLine("3. Konec programu");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Greet();
            Menu();
            break;
            
            
        case "2":
            Console.WriteLine(Sum());
            Menu();
            break;
        
        case "3":
            Console.WriteLine("Ukončuju program...");
            break;
    }
}

void Greet()
{
    Console.WriteLine("Zdravím!");
}

int Sum()
{
    Console.WriteLine("Prvni cislo");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Druhe cislo");
    int b = int.Parse(Console.ReadLine());
    return a + b;
}



Menu();