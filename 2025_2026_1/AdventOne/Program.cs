string filename = "input.txt";
if (!File.Exists(filename))
{
    Console.WriteLine($"File {filename} does not exist.");
    return;
}

// Pokud soubor existuje tak jeho řádky načtu do proměnné `lines`
string[] lines = File.ReadAllLines(filename);

var numsR = new List<int>();
var numsL = new List<int>();

foreach (string line in lines)
{
    // Tento kód rozdělí daný řádek, jako rozdělovač používá mezeru
    // jsou zde nastaveny option, které zabrání tomu, 
    // že by nám v array zbyly nějaké prázdné písmena
    string[] numStrings =
        line.Split(' ', options: StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

    if (numStrings.Length != 2)
    {
        Console.WriteLine("File format is not valid.");
        return;
    }

    // Do Listu čísel přidám levé (index 0) a pravé (index 1) číslo
    numsR.Add(int.Parse(numStrings[0]));
    numsL.Add(int.Parse(numStrings[1]));

    // INFO: Nyní máte array numStrings se dvěma položkami
    // a můžete s ním dále pracovat
    Console.WriteLine($"A:{numStrings[0]} B:{numStrings[1]}");
}

int numsS = 0;
numsL.Sort();
numsR.Sort();
for (int i = 0; i < numsL.Count; i++)
{ 
    int rozdil = Math.Abs(numsL[i] * numsR[i]);
    numsS += rozdil;
}
Console.WriteLine(numsS);