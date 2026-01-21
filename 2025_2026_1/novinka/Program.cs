int[] cisla = new int[5];
for (int i = 0; i < cisla.Length; i++)
{
    Boolean platnyVstup = false;
    while (platnyVstup == false)
    {
        Console.WriteLine("Zadej " + (i + 1) + ". číslo");
        string vstup = Console.ReadLine();
        int hodnota = int.Parse(vstup);

        if (hodnota <= 5 && hodnota >= 1)
        {
            platnyVstup = true;
            cisla[i] =  hodnota;
        }
        else
        {
            Console.WriteLine("Zkus to znova.");
        }
        
    }
}

int soucet = 0;

int minimum = cisla[0];
int maximum = cisla[0];
int pocetPetek = 0;
int pocetJednicek = 0;

for (int i = 0; i < cisla.Length; i++)
{
    soucet = soucet + cisla[i];
    if (cisla[i] < minimum) ;
    {
        minimum = cisla[i];
    }
    if (cisla[i] > maximum) ;
    {
        maximum = cisla[i];
    }
    if (cisla[i] == 5)
    {
        pocetPetek++;
    }
    if (cisla[i] == 1)
    {
        pocetJednicek++;
    }
}

double prumer = (double)soucet /cisla.Length;
Console.WriteLine("Prumer: " + prumer);
Console.WriteLine("Soucet:" + soucet);
Console.WriteLine("Minimum: " + minimum);
Console.WriteLine("Maximum: " + maximum);

for (int znamka = 1; znamka <= 5; znamka++)
{
    int pocet = 0;

    for (int j = 0; j < cisla.Length; j++)
    {
        if (cisla[j] == znamka)
        {
            pocet++;
        }
    }
    Console.WriteLine("Pocet: " + znamka + " je:" + pocet);
}

for (int i = 0; i < cisla.Length; i++)
{
    string slovne = "";
    switch (cisla[i])
    {
        case 1:
            slovne = "Výborně";
            break;
        case 2:
            slovne = "Chválitebně";
            break;
        case 3:
            slovne = "Dobré";
            break;
        case 4:
            slovne = "Dostatečné";
            break;
        case 5:
            slovne = "Nedostatečné";
            break;
        default:
            slovne = "X";
            break;
    }
    Console.WriteLine("Známka" + cisla[i] + "na" + i + ". pozici: " + slovne);
}
