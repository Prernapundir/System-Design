/*
1. Factory Design Pattern -> In Factory Design Pattern , factory calss is responsible for the business logic ,
client (main program ) won't aware about the implementation

2.In Factory patterns we create the object of the Class without Exposing the Creation/Instantiation Logic to the User 
who wants to create the Object and then return the newly Created object using the Common Interface which is inherited  by the Class”.
*/

using System;
using System.Collections.Generic;

namespace Factory_Design_Pattern
{
    class Program
    {
        interface IShape
        {
            double CalculateArea();
        }

        class Circle : IShape
        {
            readonly int radius;

            public Circle()
            {
                this.radius = 10;
            }

            public double CalculateArea()
            {
                return 3.14 * this.radius * this.radius;
            }
        }

        class Rectangle : IShape
        {
            readonly int length;
            readonly int breadth;

            public Rectangle()
            {
                this.length = 10;
                this.breadth = 10;
            }

            public double CalculateArea()
            {
                return length * breadth;
            }
        }

        //  Factory design pattern violates the OCP principle
        //  So , we are using the “Class Registration Implementation”
        class ShapeFactory
        {
            public static Dictionary<String, IShape> resgisteredClasses = ShapeClassRegistry._registeredShapes;

            public static double GetShapeArea(string shape)
            {
                double area = 0;

                if (resgisteredClasses.ContainsKey(shape))
                {
                    IShape shapeClass = resgisteredClasses[shape];
                    area = shapeClass.CalculateArea();
                }
                return area;
            }
        }

        // Class Registration to solve OCP problem
        class ShapeClassRegistry
        {
            public static Dictionary<String, IShape> _registeredShapes = new();

            public static void AddShapeClass(String shapeName, IShape shapeClass)
            {
                _registeredShapes.Add(shapeName, shapeClass);
            }

            public static void RemoveShapeClass(String shapeName, IShape shapeClass)
            {
                _registeredShapes.Remove(shapeName);
            }
        }

        static void Main(string[] args)
        {
            ShapeClassRegistry.AddShapeClass("circle", new Circle());
            ShapeClassRegistry.AddShapeClass("rectangle", new Rectangle());

            string userInput = "circle";
            double area = ShapeFactory.GetShapeArea(userInput);

            Console.WriteLine($"Area:{area}");
        }
    }
}
