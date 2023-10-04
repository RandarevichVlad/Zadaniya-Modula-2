using System;

namespace Var3_Zad1
{
    class Employee
    {
        // Поля класса
        private string name;
        private int age;
        private string position;
        private double monthlySalary;

        // Конструктор
        public Employee()
        {
            // Конструктор без параметров
        }

        // Методы для получения и установки значений полей
        public string GetName()
        {
            return name;
        }

        // Метод для установки имени сотрудника
        public void SetName(string name)
        {
            this.name = name;
        }

        // Метод для получения возраста сотрудника
        public int GetAge()
        {
            return age;
        }

        // Метод для установки возраста сотрудника
        public void SetAge(int age)
        {
            this.age = age;
        }

        // Метод для получения должности сотрудника
        public string GetPosition()
        {
            return position;
        }

        // Метод для установки должности сотрудника
        public void SetPosition(string position)
        {
            this.position = position;
        }

        // Метод для получения месячной зарплаты сотрудника
        public double GetMonthlySalary()
        {
            return monthlySalary;
        }

        // Метод для установки месячной зарплаты сотрудника
        public void SetMonthlySalary(double monthlySalary)
        {
            this.monthlySalary = monthlySalary;
        }

        // Метод для расчета годового дохода (месячная зарплата * 12)
        public double CalculateAnnualIncome()
        {
            return monthlySalary * 12;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект класса "Сотрудник"
            Employee employee = new Employee();

            // Вводим данные с консоли - имя сотрудника
            Console.Write("Введите имя сотрудника: ");
            string name = Console.ReadLine();
            employee.SetName(name);

            // Ввод данных возраста сотрудника
            Console.Write("Введите возраст сотрудника: ");
            int age = int.Parse(Console.ReadLine());
            employee.SetAge(age);

            // Ввод данных должности сотрудника
            Console.Write("Введите должность сотрудника: ");
            string position = Console.ReadLine();
            employee.SetPosition(position);

            // Ввод данных месячной зарплаты сотрудника
            Console.Write("Введите месячную зарплату сотрудника: ");
            double monthlySalary = double.Parse(Console.ReadLine());
            employee.SetMonthlySalary(monthlySalary);

            // Выводим информацию о сотруднике
            Console.WriteLine("Имя: " + employee.GetName());
            Console.WriteLine("Возраст: " + employee.GetAge());
            Console.WriteLine("Должность: " + employee.GetPosition());
            Console.WriteLine("Месячная зарплата: " + employee.GetMonthlySalary());
            Console.WriteLine("Годовой доход: " + employee.CalculateAnnualIncome());

            Console.ReadKey();
        }
    }
}
