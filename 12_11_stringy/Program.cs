/*
string veta = " Dnes je velmi hezky.";

//Změna velikosti písmen
//Uppercase
Console.WriteLine(veta.ToUpper());
//Lowercase
Console.WriteLine(veta.ToLower());

//Zrušení mezer
Console.WriteLine(veta.Trim());

//Hledání
Console.WriteLine(veta.Contains("je")); //True nebo False
Console.WriteLine(veta.IndexOf(".")); //Pozice prvního výskytu znaku

// Začíná/Končí

Console.WriteLine(veta.Trim().StartsWith("Dnes")); // True nebo false
Console.WriteLine(veta.Trim().EndsWith("hezky")); // bez mezery
Console.WriteLine(veta.Trim().EndsWith("hezky.")); // s mezerou


// práce
Console.WriteLine("Zadejte své jméno a přijmení (JEDEN ŘÁDEK)");
string vstup = Console.ReadLine().Trim();
Console.WriteLine(vstup.Length);
Console.WriteLine(vstup.ToUpper());
Console.WriteLine("Nachází se ve vstupu jméno Jan? " + vstup.Contains("Jan"));
Console.WriteLine(vstup[0] + ""  + vstup[vstup.Length - 1]);


//Substring
string datum = "2025-11-12T16:00";
string rok = datum.Substring(startIndex:0, length:4);
string cas = datum.Substring(startIndex:11);
string den =  datum.Substring(startIndex:5, 5);
Console.WriteLine($"Rok: {rok}, Cas: {cas} + Den: {den}");

//Replace
string text = "Cena : 100 Kc, Doprava 50 kc";
string opraveno = text.Replace("Kc", "CZK");
Console.WriteLine(opraveno);

string csvRadek = "Pavel;Novak;38;Praha";
string[] casti = csvRadek.Split(';');
Console.WriteLine($"Jméno: {casti[0]} , Prijmeni:  {casti[1]} , Vek {casti[2]} , Mesto: {casti[3]}");

string veta = "Dnes je krásný den.";
string[] slova = veta.Split(';');
Console.WriteLine(slova.Length);


//Pokrcily Ú1
Console.WriteLine("Zadejte své jméno a přijmení (JEDEN ŘÁDEK)");
string entry = Console.ReadLine().ToLower().Trim();
Console.WriteLine(entry.IndexOf(' '));
string[] casti = entry.Split(' ');
string jmeno = casti[0].Substring(0, 1).ToUpper() + ".";
string prijmeni = char.ToUpper(casti[1][0]) + casti[1].Substring(1).ToLower();
Console.WriteLine(jmeno +  " " + prijmeni);

//Pokrocily Ú2
string data = "JMENO=Karel;VEK=45;MESTO=Praha";
string[] castice = data.Split(";");
string jmeno = castice[0].Split("=")[1];
string vek = castice[1].Split("=")[1];
string mesto = castice[2].Split("=")[1];
Console.WriteLine(jmeno +  " " + vek +  " " + mesto);
*/
//PRÁCE S TEXTEM - StreamReader a StreamWriter

string cesta = "data.txt";
if (!File.Exists(path: "data.txt"))
{
    StreamReader sr = new StreamReader(cesta);
    string line = sr.ReadLine(); //Přečte první řádek

    Console.WriteLine(line);
    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
    sr.Close(); //Zavře soubor

    StreamWriter sw = new StreamWriter(cesta, append: true);
    sw.WriteLine("\nHello World!");
    sr.Close();

}