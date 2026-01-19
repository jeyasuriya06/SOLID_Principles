
public class ShapeFactory {
    public Shape createShape() {
        // The post condition is that it always returns a shape
        return new Shape();
    }
    public void draw () {
        System.out.println("Drawing");
    }
}

class CircleFactory{
    public Circle createShape() {
        return new Circle();
    }
}
