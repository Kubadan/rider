class Student
{
    public int age;
    public string name;

    public Student(int age, string name)
    {
        this.age = age;
        this.name = name;
    }

    public void Greet()
    {
        Console.WriteLine("Hello teacher! My name is " + name);
    }
}