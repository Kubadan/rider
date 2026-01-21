
// FUNKCE AND - všechny booleany musí být pravdivé

using System.ComponentModel.Design;

string slovo = "ahoj";
bool jetoPravda = slovo != "ahoj" && slovo != "cau";
Console.WriteLine(jetoPravda);


// FUNKCE OR - alespoň jeden boolean musí být pravdivý
string slovicko = "ahoj";
bool jeToPravda = slovicko != "ahoj" || slovicko != "cau";
Console.WriteLine(jeToPravda);



//string letter = Console.ReadLine();

//if (letter == "q")
{
 //   Console.WriteLine("user wants to quit");
}
//else if (letter == "f")
{
   // Console.WriteLine("user wants to pay respects");
}
//else
{
  //  Console.WriteLine("program is running");
}

    Console.WriteLine("Enter age:");
    string ageString = Console.ReadLine();
    int age = int.Parse(ageString);

    if (age < 18)
    {
        Console.WriteLine("jsi nezletily");
    }
    else if (age > 150 || age < 0)
    {
        Console.WriteLine("Nepovolená hodnota");
    }
    else if (age > 65)
    {
        Console.WriteLine("jsi senior");
    }
    else
    {
        Console.Write("jsi dospely");
    }
    