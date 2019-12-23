using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_1._1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        abstract class Shape
        {
            public abstract string Color { get; set; }
            public abstract double Size { get; }
            public abstract string Name { get; }

            public abstract double Area(double number);
            public abstract double Perimeter(double number);
        }

        interface IDraw
        {
            void Print();
        }

        class Square : Shape, IDraw
        {
            public override string Color { get; set; }
            public override double Size { get; }
            public override string Name { get; }

            public override double Area(double number)
            {
                return (number * number);
            }
            public override double Perimeter(double number)
            {
                return (number * 4);
            }

            public Square(string Name)
            {
                this.Name = Name;
                Size = 1;
                Color = "black";
            }

            public Square(string Name, float Size)
            {
                this.Name = Name;
                this.Size = Size;
                Color = "black";
            }

            public Square(string Name, double Size, string Color)
            {
                this.Name = Name;
                this.Size = Size;
                this.Color = Color;
            }

            public void Print()
            {
                Console.WriteLine("Name: {0}\nSize: {1}\nColor: {2}", Name, Size, Color);
            }
        }

        class Circle : Shape, IDraw
        {
            public override string Color { get; set; }
            public override double Size { get; }
            public override string Name { get; }

            public override double Area(double number)
            {
                return (Math.PI * (number * number));
            }
            public override double Perimeter(double number)
            {
                return (2 * Math.PI * number);
            }

            public Circle(string Name)
            {
                this.Name = Name;
                Size = 1;
                Color = "black";
            }

            public Circle(string Name, int Size)
            {
                this.Name = Name;
                this.Size = Size;
                Color = "black";
            }

            public Circle(string Name, int Size, string Color)
            {
                this.Name = Name;
                this.Size = Size;
                this.Color = Color;
            }

            public void Print()
            {
                Console.WriteLine("Name: {0}\nSize: {1}\nColor: {2}", Name, Size, Color);
            }
        }

        class Triangle : Shape, IDraw
        {
            public override string Color { get; set; }
            public override double Size { get; }
            public override string Name { get; }

            public override double Area(double number)
            {
                return (((number * number) * Math.Sqrt(3)) / 4);
            }
            public override double Perimeter(double number)
            {
                return (3 * number);
            }

            public Triangle(string Name)
            {
                this.Name = Name;
                Size = 1;
                Color = "black";
            }

            public Triangle(string Name, int Size)
            {
                this.Name = Name;
                this.Size = Size;
                Color = "black";
            }

            public Triangle(string Name, int Size, string Color)
            {
                this.Name = Name;
                this.Size = Size;
                this.Color = Color;
            }

            public void Print()
            {
                Console.WriteLine("Name: {0}\nSize: {1}\nColor: {2}", Name, Size, Color);
            }
        }
        class Picture : IDraw
        {
            List<Shape> shape = new List<Shape>();


            public void ConstructSquare()
            {
                shape.Add(new Square("red", 2, "name"));
            }

            public void ConstructCircle()
            {
                shape.Add(new Circle("red", 2, "name"));
            }
            public void ConstructTriangle()
            {
                shape.Add(new Square("red", 2, "name"));
            }

            public void ConstructSquare(int number)
            {
                for (int i = 0; i < number; i++)
                {
                    shape.Add(new Square("red", 2, "name"));
                }
            }

            public void ConstructCircle(int number)
            {
                for (int i = 0; i < number; i++)
                {
                    shape.Add(new Circle("red", 2, "name"));
                }
            }
            public void ConstructTriangle(int number)
            {
                for (int i = 0; i < number; i++)
                {
                    shape.Add(new Square("red", 2, "name"));
                }
            }

            public void AddSquare(string color, double size, string name)
            {
                shape.Add(new Square(color, size, name));
            }

            public void AddCircle(string color, int size, string name)
            {
                shape.Add(new Circle(color, size, name));
            }

            public void AddTriangle(string color, int size, string name)
            {
                shape.Add(new Triangle(color, size, name));
            }

            public void Remove(string name)
            {
                for (int i = 0; i < shape.Count; i++)
                {
                    if (shape[i].Name == name)
                    {
                        shape.RemoveAt(i);
                    }
                }
            }

            public void RemoveArea(double area)
            {
                for (int i = 0; i < shape.Count; i++)
                {
                    if (shape[i].Area(shape[i].Size) == area)
                    {
                        shape.RemoveAt(i);
                    }
                }
            }

            public int number
            {
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Отрицетельное и нулевое значение невозможно.");
                    }
                    else
                    {
                        number = value;
                    }
                }
            }

            public Shape this[int index]
            {
                get
                {
                    return shape[index];
                }
                set
                {
                    shape[index] = value;
                }
            }

            public void Print()
            {
                for (int i = 0; i < shape.Count; i++)
                {
                    Console.WriteLine("Name: {0}\nSize: {1}\nColor: {2}\n", shape[i].Name, shape[i].Size, shape[i].Color);
                }
            }
        }
    }
}
