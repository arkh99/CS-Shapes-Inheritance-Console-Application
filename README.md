# CS-Shapes-Inheritance-Console-Application
This project demonstrates object-oriented programming (OOP) concepts in C#, specifically focusing on inheritance and polymorphism. The application calculates the area of different geometric shapes using a common interface.

Key Points and Features
Shape Hierarchy:

The project defines a base abstract class Shape with an abstract method GetArea().
Derived classes Rectangle, Circle, and Square inherit from Shape and provide specific implementations of the GetArea() method.
Polymorphism:

Polymorphism is demonstrated by storing different shapes in a List<Shape> and calling the GetArea() method on each shape without knowing its specific type.
Console Application:

The application creates instances of different shapes and prints their areas to the console.
Techniques and Concepts
Inheritance:

The base class Shape is inherited by Rectangle, Circle, and Square.
Square is a special case of Rectangle, inheriting its properties and methods.
Abstract Classes and Methods:

Shape is an abstract class that defines an abstract method GetArea().
Derived classes must implement the GetArea() method.
Encapsulation:

Each shape class encapsulates its own properties and methods related to calculating the area.
Math Library:

The Circle class uses the Math.PI constant for area calculation.
Project Structure
Program.cs: Contains the main entry point and demonstrates the creation and usage of different shapes.
Circle.cs: Defines the Circle class with properties and methods specific to a circle.
Rectangle.cs: Defines the Rectangle class with properties and methods specific to a rectangle.
Shape.cs: Defines the abstract Shape class with an abstract method GetArea().
Square.cs: Defines the Square class as a special case of Rectangle.
