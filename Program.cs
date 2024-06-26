﻿using Shapes;

var rectangle = new Rectangle(4, 5);
Console.WriteLine(rectangle.GetArea());

var circle = new Circle(6);
Console.WriteLine(circle.GetArea());

var square = new Square(7);
Console.WriteLine(square.GetArea());

List<Shape> shapes = [rectangle, circle, square];

foreach (Shape shape in shapes)
{
  Console.WriteLine(shape.GetArea());
}
