using System;

namespace Zad4
{
    // Интерфейс IDrawable с методом Draw()
    interface IDrawable
    {
        void Draw();
    }

    // Класс Circle представляет круг.
    class Circle : IDrawable
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Рисуем круг с радиусом {radius}");
        }
    }

    // Класс Rectangle представляет прямоугольник.
    class Rectangle : IDrawable
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw()
        {
            Console.WriteLine($"Рисуем прямоугольник шириной {width} и высотой {height}");
        }
    }

    // Класс Triangle представляет треугольник.
    class Triangle : IDrawable
    {
        private double side1;
        private double side2;
        private double side3;

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public void Draw()
        {
            Console.WriteLine($"Рисуем треугольник со сторонами {side1}, {side2}, и {side3}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем массив объектов, реализующих интерфейс IDrawable
            IDrawable[] shapes = new IDrawable[]
            {
                new Circle(5.0),
                new Rectangle(4.0, 3.0),
                new Triangle(3.0, 4.0, 5.0)
            };

            // Вызываем метод Draw() для каждого объекта
            foreach (var shape in shapes)
            {
                shape.Draw(); // Вызов метода Draw() для отображения каждой фигуры
            }

            Console.ReadLine();
        }
    }
}
