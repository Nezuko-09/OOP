class Student : Person
{
    public int studentNumber = 2;
    public void Study()
    {
        Console.WriteLine($"{fullname} is studying");
    }
    public override void FavouriteSubject()
    {
        Console.WriteLine($"{name}'s favourite subject is maths ");
    }
}