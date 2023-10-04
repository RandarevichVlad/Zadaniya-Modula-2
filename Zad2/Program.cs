using System;

namespace Zad2
{
    // Базовый класс Фигура
    public abstract class Фигура
    {
        public abstract double Площадь(); // Метод для вычисления площади
        public abstract double Периметр(); // Метод для вычисления периметра
    }

    // Производный класс Круг
    public class Круг : Фигура
    {
        private double радиус;

        public Круг(double радиус)
        {
            this.радиус = радиус;
        }

        public override double Площадь()
        {
            // Формула для вычисления площади круга: π * r^2
            return Math.PI * Math.Pow(радиус, 2);
        }

        public override double Периметр()
        {
            // Формула для вычисления периметра круга: 2 * π * r
            return 2 * Math.PI * радиус;
        }
    }

    // Производный класс Прямоугольник
    public class Прямоугольник : Фигура
    {
        private double ширина;
        private double высота;

        public Прямоугольник(double ширина, double высота)
        {
            this.ширина = ширина;
            this.высота = высота;
        }

        public override double Площадь()
        {
            // Формула для вычисления площади прямоугольника: ширина * высота
            return ширина * высота;
        }

        public override double Периметр()
        {
            // Формула для вычисления периметра прямоугольника: 2 * (ширина + высота)
            return 2 * (ширина + высота);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем объекты
            Круг круг = new Круг(5);
            Прямоугольник прямоугольник = new Прямоугольник(4, 6);

            // Выводим площади и периметры круга
            Console.WriteLine("Круг:");
            Console.WriteLine("Площадь: " + круг.Площадь());
            Console.WriteLine("Периметр: " + круг.Периметр());

            Console.WriteLine("\nПрямоугольник:");

            // Выводим площади и периметры прямоугольника
            Console.WriteLine("Площадь: " + прямоугольник.Площадь());
            Console.WriteLine("Периметр: " + прямоугольник.Периметр());

            Console.ReadLine();
        }
    }
}
