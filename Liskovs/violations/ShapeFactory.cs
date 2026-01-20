using System;

public class Shape
{
    // Empty shape class for demonstration
}

public class ShapeFactory
{
    public virtual Shape CreateShape()
    {
        // Post-condition: always returns a Shape
        return new Shape();
    }

    public void Draw()
    {
        Console.WriteLine("Drawing");
    }
}

public class UnsafeShapeFactory : ShapeFactory
{
    public override Shape CreateShape()
    {
        // Violates parent class contract and returns null
        return null;
    }
}
