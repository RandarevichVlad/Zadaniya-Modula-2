using System;

// Создаем класс для хранения информации о событии изменения температуры.
class TemperatureChangedEventArgs : EventArgs
{
    public double NewTemperature { get; }

    public TemperatureChangedEventArgs(double newTemperature)
    {
        NewTemperature = newTemperature;
    }
}

// Создаем класс TemperatureSensor, который представляет датчик температуры.
class TemperatureSensor
{
    private double currentTemperature;
    public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

    // Свойство для получения и установки текущей температуры.
    public double CurrentTemperature
    {
        get { return currentTemperature; }
        set
        {
            if (currentTemperature != value)
            {
                currentTemperature = value;
                OnTemperatureChanged(value);
            }
        }
    }

    // Метод для вызова события TemperatureChanged при изменении температуры.
    protected virtual void OnTemperatureChanged(double newTemperature)
    {
        TemperatureChanged?.Invoke(this, new TemperatureChangedEventArgs(newTemperature));
    }
}

// Создаем класс Thermostat, который управляет системой отопления.
class Thermostat
{
    private bool heatingOn = false;

    public Thermostat(TemperatureSensor sensor)
    {
        // Подписываемся на событие TemperatureChanged датчика температуры.
        sensor.TemperatureChanged += HandleTemperatureChanged;
    }

    // Обработчик события изменения температуры.
    private void HandleTemperatureChanged(object sender, TemperatureChangedEventArgs e)
    {
        if (heatingOn)
        {
            Console.WriteLine($"Отопление включено. Текущая температура: {e.NewTemperature} градусов.");
        }
        else
        {
            Console.WriteLine($"Отопление выключено. Текущая температура: {e.NewTemperature} градусов.");
        }
    }

    // Метод для включения отопления.
    public void TurnHeatingOn()
    {
        heatingOn = true;
        Console.WriteLine("Отопление включено.");
    }

    // Метод для выключения отопления.
    public void TurnHeatingOff()
    {
        heatingOn = false;
        Console.WriteLine("Отопление выключено.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TemperatureSensor sensor = new TemperatureSensor();
        Thermostat thermostat = new Thermostat(sensor);

        // Симулируем изменение температуры.
        sensor.CurrentTemperature = 18;

        // Включаем отопление и снова меняем температуру.
        thermostat.TurnHeatingOn();
        sensor.CurrentTemperature = 22;

        // Выключаем отопление и снова меняем температуру.
        thermostat.TurnHeatingOff();
        sensor.CurrentTemperature = 15;

        Console.ReadLine();
    }
}
