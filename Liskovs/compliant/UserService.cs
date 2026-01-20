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
        service.SetAge(10);
    }
}

public class AdultUserService : UserService
{
    public override void SetAge(int age)
    {
        base.SetAge(age);

        if (age >= 18)
        {
            Console.WriteLine("User is an adult");
        }
        else
        {
            Console.WriteLine("User is a minor");
        }
    }
}
