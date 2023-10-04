﻿using System;

public class МойКласс
{
    private int переменная1;
    private string переменная2;

    // Конструктор с входными параметрами
    public МойКласс(int var1, string var2)
    {
        переменная1 = var1;
        переменная2 = var2;
    }

    // Конструктор, инициализирующий члены класса по умолчанию
    public МойКласс()
    {
        переменная1 = 0;
        переменная2 = "по_умолчанию";
    }

    // Деструктор
    ~МойКласс()
    {
        Console.WriteLine("Объект МойКласс удален.");
    }

    // Метод для вывода переменных
    public void ВывестиПеременные()
    {
        Console.WriteLine($"Переменная1: {переменная1}, Переменная2: {переменная2}");
    }
}

internal class Программа
{
    static void Main(string[] args)
    {
        // Создание объекта с конструктором с параметрами
        МойКласс объект1 = new МойКласс(42, "Привет");

        // Создание объекта с конструктором по умолчанию
        МойКласс объект2 = new МойКласс();

        // Вызов метода для вывода переменных
        объект1.ВывестиПеременные();
        объект2.ВывестиПеременные();

        // Пример удаления объекта с вызовом деструктора
        объект1 = null;
        GC.Collect(); // Вызов сборщика мусора
    }
}
