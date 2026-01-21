Student student = new Student(21, name:"Alec" );
student.Greet();
ChangeStudent(student);
student.Greet();

void ChangeStudent(Student s)
{
    s.name = "Nothing";
}
