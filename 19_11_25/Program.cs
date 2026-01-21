/*if (File.Exists(path: "data.txt"))
{
    
    StreamReader sr = new StreamReader(path: "data.txt");
    
    string line =  sr.ReadLine();

    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
    sr.Close();
}

if (File.Exists(path: "data.txt"))
{
    StreamWriter sw = new StreamWriter(path: "data.txt");
    sw.WriteLine("Hello World!");
    sw.WriteLine("Třetí řádek");
    sw.Close();
}
*/

string path = "zaci.txt";
if (File.Exists(path))
{
    int celkovyVek = 0;
    int pocetZaku = 0; 
    StreamReader sr = new StreamReader(path);

    string line = sr.ReadLine();

    while (line != null)
    {
        string[] casti = path.Split(';');
        
        Console.WriteLine(line);
        int vek = int.Parse(casti[3]);
        Console.WriteLine(casti[1] + " " + casti[2]);
        celkovyVek += vek;
        pocetZaku++;
    }
    
    sr.Close();
    
    double prumer = celkovyVek/(double)pocetZaku;
    Console.WriteLine(prumer);
    
    StreamWriter sw = new StreamWriter(path);
    sw.WriteLine(prumer);
    
    sw.WriteLine(pocetZaku);
    sw.WriteLine(celkovyVek);
    sw.WriteLine(prumer);
}