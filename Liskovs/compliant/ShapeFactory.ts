class Shape {
    draw(): void {
        console.log("Drawing Shape");
    }
}

class Circle extends Shape {
    draw(): void {
        console.log("Drawing Circle");
    }
}

class ShapeFactory {
    createShape(): Shape {
        return new Shape();
    }

    draw(): void {
        console.log("Drawing");
    }
}

class CircleFactory extends ShapeFactory {
    createShape(): Circle {
        return new Circle();
    }
}
