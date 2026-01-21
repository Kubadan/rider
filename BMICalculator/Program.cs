//  váha (kg) / ( výška (m) * výška (m) )

// váha kg (int)
// výška cm (int)
//ulozit do float


Console.WriteLine("Tvoje váha [KG]:");
string vaha = Console.ReadLine();

Console.WriteLine("Tvoje výška [CM]:");
string vyska = Console.ReadLine();

// konvertovaní stringu na float
float vahaFloat = float.Parse(vaha);
float vyskaFloat = float.Parse(vyska);

// Převod na metry
float vyskaMetFloat = vyskaFloat / 100;

float bm = vahaFloat / (vyskaMetFloat * vyskaMetFloat);
Console.WriteLine(bm);



// Podmínky

if (bm >= 30)
{
    Console.WriteLine("obezita");
}

else if (bm < 29.99 && bm > 25 )
{
    Console.WriteLine("nadváha");
}
else if (bm < 24.99 && bm > 18.50 )
{
    Console.WriteLine("normálka");
}

else 
{
    Console.WriteLine("podváha");
}