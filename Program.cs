// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

class Person
{
    public string fullname = "Zaid Amina";
    public int age = 16;
    public void Introduce()
    {
        Console.WriteLine($"My name is {fullname} and i am {age} years old");
    }

}
class Student : Person
{
    public int studentNumber = 2;
    public void Study()
    {
        Console.WriteLine("student is studying");
    }

    void Main()
    {
        Student captain = new Student();
        captain.Introduce();
        captain.Study();
    }
}
class Teacher : Person
{
    string subject;
    void Teach()
    {
        Console.WriteLine($"Teacher is teaching {subject}");
    }
}