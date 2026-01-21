int[] cisla = new int[10];
for (int i = 0; i < cisla.Length; i++)
{
    Console.WriteLine("Zadej " + (i + 1) + ". číslo");
    string vstup = Console.ReadLine();
    int hodnota = int.Parse(vstup);
    cisla[i] = hodnota;
}

for (int i = 0; i < cisla.Length; i++)
{
    Console.WriteLine(cisla[i]);
}

for (int i = 10; i > 0; i--)
{
    Console.WriteLine(cisla[i]);
}