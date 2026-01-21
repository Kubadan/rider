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