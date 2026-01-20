using System;

public class UserService
{
    public virtual void SetAge(int age)
    {
        if (age < 0)
        {
            throw new ArgumentException("Age must be non-negative");
        }

        Console.WriteLine("Age set to " + age);
    }

    public static void Main(string[] args)
    {
        UserService service = new AdultUserService();
        service.SetAge(10); // Runtime exception
    }
}

public class AdultUserService : UserService
{
    public override void SetAge(int age)
    {
        if (age < 18)
        {
            throw new ArgumentException("User must be an adult");
        }

        Console.WriteLine("Adult age set to " + age);
    }
}
