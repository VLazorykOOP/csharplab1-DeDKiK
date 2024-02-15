using System;

class Program
{
    static void Main()
    {
        // Завдання 1
        Console.Write("Введіть площу повної поверхні куба: ");
        double s = Convert.ToDouble(Console.ReadLine());

        double a = Math.Sqrt(s / 6);

        Console.WriteLine("Ребро куба: " + a);

        // Завдання 2
        Console.Write("\nВведіть двозначне число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = (number / 10) + (number % 10);
        string result = (sum % 2 == 0) ? "Сума цифр парна" : "Сума цифр непарна";

        Console.WriteLine(result);

        // Завдання 3
        Console.Write("Введіть координату х: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть координату y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        if (y > Math.Abs(x) && y < 12)
            Console.WriteLine("Так");
        else if (y < Math.Abs(x) || y > 12)
            Console.WriteLine("Ні");
        else
            Console.WriteLine("На межі");

        // Завдання 4: 
        Console.Write("Введіть кількість місяців: ");
        int m = Convert.ToInt32(Console.ReadLine());

        DateTime date = DateTime.Now.AddMonths(-m);

        Console.WriteLine("Дата " + m + " місяців тому була: " + date.ToString("dd/MM/yyyy"));

        // Завдання 5: 
        Console.Write("\nВведіть ціле число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int square = number * number2;

        Console.WriteLine("Квадрат числа " + number2 + " дорівнює: " + square);

        // Завдання 6:
        Console.Write("\nВведіть значення x: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть значення y: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double result2 = Math.Pow(x2 * y2, 2) - (5 * x2 + Math.Pow(y2, 2)) / (Math.Pow(y2, 2) + 1);

        Console.WriteLine("Значення виразу (xy)^2 - (5x+y^2)/(y^2+1) дорівнює: " + result2);
    }
}

