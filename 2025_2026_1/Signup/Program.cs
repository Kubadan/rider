Console.WriteLine("Prosím zadejte heslo: ");
string pass = Console.ReadLine();
if (pass != "heslo123")
{
    Console.WriteLine("Přístup zamítnut");
}
else
{
    Console.WriteLine("Přístup povolen");
}