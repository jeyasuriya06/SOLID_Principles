
public class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing Shape");
    }
}


public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

public class ShapeFactory
{
    // Postcondition: always returns a Shape
    public virtual Shape CreateShape()
    {
        return new Shape();
    }

    public void Draw()
    {
        Console.WriteLine("Drawing");
    }
}

public class CircleFactory : ShapeFactory
{
    // Stronger postcondition: returns a specific subtype (Circle)
    public override Circle CreateShape()
    {
        return new Circle();
    }
}
