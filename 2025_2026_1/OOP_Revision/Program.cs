List<Student> StudentList = new List<Student>();
while (true)
{
    Console.WriteLine("Enter Student's name:");
    string name = Console.ReadLine();
    if (name == "Q")
    {
        break;
    }
    Console.WriteLine("Enter Student's age:");
    int age = int.Parse(Console.ReadLine());
    StudentList.Add(new Student(age, name));
    
}
foreach (Student student in StudentList)
    {
        student.Greet();
    }

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
        Console.WriteLine("Hello teacher! My name is " + name + " and I'am " + age + " years old.");
    }
}
