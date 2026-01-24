class Person
{
    public string name = "Amina";
    public string fullname = "Zaid Amina";
    private int age = 16;
    public int GetAge(int age)
    {
        return age;
    }
    public void Introduce()
    {
        Console.WriteLine($"My name is {fullname} and i am {age} years old");
    }
    public virtual void FavouriteSubject()
    {
        Console.WriteLine("favourite subject is subject");
    }

}
