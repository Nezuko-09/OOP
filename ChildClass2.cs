using System.Security.Cryptography.X509Certificates;

class Teacher : Person
{
    private string subject = "Kemis3";
    public string Retrieve()
    {
        return subject;
    }
    public void Teach()
    {
        Console.WriteLine($"Teacher is teaching {subject}");
    }
}