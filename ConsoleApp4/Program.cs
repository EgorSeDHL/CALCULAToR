Console.WriteLine("1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Выйти из программы\r\nВыберите действие: ");
int number = 0;

do
{

    number = Convert.ToInt32(Console.ReadLine());

    if (number == 1)
    {
        Console.WriteLine("введите 2 числа");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a + b);
        Console.WriteLine("введите номер операции");
    }

    else if (number == 2)
    {
        Console.WriteLine("введите 2 числа");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a - b);
        Console.WriteLine("введите номер операции");
    }

    else if (number == 3)
    {
        Console.WriteLine("введите 2 числа");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a * b);
        Console.WriteLine("введите номер операции");
    }

    else if (number == 4)
    {
        Console.WriteLine("введите 2 числа");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a / b);
        Console.WriteLine("введите номер операции");
    }

    else if (number == 5)
    {
        Console.WriteLine("введите 2 числа");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Math.Pow(a, b));
        Console.WriteLine("введите номер операции");
    }

    else if (number == 6)
    {
        Console.WriteLine("введите число");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(a));
        Console.WriteLine("введите номер операции");
    }

    else if (number == 7)
    {
        Console.WriteLine("введите 2 числа");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(a / 100);
        Console.WriteLine("введите номер операции");
    }

    else if (number == 8)
    {
        Console.WriteLine("введите число");
        int n = Convert.ToInt32(Console.ReadLine());
        int factorial = 1;

        for (int i = 2; i <= n; i++)
        {
            factorial = factorial * i;

        }
        Console.WriteLine(factorial);
        Console.WriteLine("введите номер операции");
    }
    else if (number > 9)
        Console.WriteLine("ты дурак? правильно введи номер операции");
} while (number != 9);