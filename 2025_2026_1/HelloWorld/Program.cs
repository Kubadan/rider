/*

string text1 = "Hello";
string text2 = "World!";
int cislo = 10;
string text = $"Vystup tohoto programu: {text1} {text2} {cislo}";


// výpis
Console.WriteLine(text);


// console.write píše na jeden řádek
Console.Write("ahoj");
Console.Write("cau");
Console.Write("nazdar");


//vstup uživatele
string vstup = Console.ReadLine();
Console.WriteLine("zadal jsi: " + vstup);
*/


// Kalkulačka

Console.WriteLine("Zadej prvni cislo");
string vstup0 = Console.ReadLine();


Console.WriteLine("Zadej druhe cislo");
string vstup1 = Console.ReadLine();

// konverze stringů na integer 
int cislo0 = int.Parse(vstup0);
int cislo1 = int.Parse(vstup1);


Console.WriteLine(cislo0 + cislo1);