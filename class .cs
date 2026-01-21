class Teacher : Person
{
    string subject;
    void Teach()
    {
        Console.WriteLine($"Teacher is teaching {subject}");
    }
}