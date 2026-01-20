class UnsafeShapeFactory extends ShapeFactory {
    override createShape(): Shape {
        // Violates parent class contract
        return null;
    }
}
