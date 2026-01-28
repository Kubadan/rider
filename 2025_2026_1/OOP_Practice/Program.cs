/*
Wall MexicoWall = new Wall(3, 200000, "Metal");
MexicoWall.PrintInfo();

class Wall
{
    public float height;
    public float width;
    public string material;

    public Wall(float height, float width, string material)
    {
        this.height = height;
        this.width = width;
        this.material = material;
    }

    public float GetSurface()
    {
        float surface = width * height;
        return surface;
    }

    public void PrintInfo()
    {
        Console.WriteLine(
            $"The wall is currently {height} meters tall, {width} meters wide and made of {material} " +
            $"with a total surface of {GetSurface()} meters."
        );
    }
} 


Book Nineteen_Eighty_Four  = new Book("jorjor wel",1948, 320, "Nineteen Eighty-Four" );
Nineteen_Eighty_Four.PrintInfo();
class Book
{
    public string Author;
    public int ReleaseYear;
    public int Pagecount;
    public string Title;

    public Book(string Author, int ReleaseYear, int Pagecount, string Title)
    {
        this.Author = Author;
        this.ReleaseYear = ReleaseYear;
        this.Pagecount = Pagecount;
        this.Title = Title;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Autor: " + Author + " Datum vydání: " + ReleaseYear + " Počet stran: " + Pagecount + " Název: " + Title);
    }
}
*/

List<string> bookList = new List<string>();
bookList.Add("Ahoj");
bookList.Add("Ciao");

bookList.RemoveAt(1);

Console.WriteLine(bookList.Count);
foreach (string book in bookList)
{
    Console.WriteLine(book);
}