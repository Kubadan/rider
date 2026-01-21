// deklarace array (listu)
int[] mojeCisla;

//inicializace
mojeCisla = new int[5];

//kombinace obojeho
int[] znamky = new int[5];

// přistup k prvkům
znamky[0] = 1; // prvni pozice je hodnota 1
znamky[1] = 3;
znamky[4] = 2; // posledni pozice v array znamek

int prvniZnamka = znamky[0];
Console.WriteLine(prvniZnamka);
    
Console.WriteLine(znamky[3]); //vypíše nulu

string[] dnyVTydnu = new string[7];
string[] dnyVTyndu2 = {"Pondělí" , "Úterý", "Středa", "Čtvrtek", "Pátek", "Sobota", "Něděle"};

Console.WriteLine(dnyVTyndu2[1] + ", " + dnyVTyndu2[5]); 

int velikost = dnyVTyndu2.Length;

Console.WriteLine(velikost);

for (int i = 0; i < dnyVTyndu2.Length; i++)
{
    Console.WriteLine(dnyVTyndu2[i]);
}

