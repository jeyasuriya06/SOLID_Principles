class ShapeFactory {
    public Shape createShape() {
        // The post condition is that it always returns a shape
        return new Shape();
    }
    public void draw () {
        System.out.println("Drawing");
    }
}

class UnsafeShapeFactory extends ShapeFactory {
    @Override
    public Shape createShape() {
        // Violates parent class contract - It returns a non shape object
        return null;
    }
}

