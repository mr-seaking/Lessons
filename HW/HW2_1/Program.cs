using System;

Console.WriteLine("Занятие 2. ДЗ 1:");
Console.WriteLine("Введите поочередно три целых числа");
try
{
    Console.Write("первое число: ");
    int n1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("второе число: ");
    int n2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("третье число: ");
    int n3 = Convert.ToInt32(Console.ReadLine());

    int[] nums = { n1, n2, n3 };
    var length = nums.Length;
    var sum = n1 + n2 + n3;
    var res = sum / length;
    Console.WriteLine("среднее арифметическое значение всех введённых чисел: " + res);
}
catch (FormatException)
{
    Console.WriteLine("Вы ввели не число");
}
Console.WriteLine("\n Занятие 2. ДЗ 2:");

Console.WriteLine("С консоли вводятся данные о пасажирах: ФИО и номер места");
try
{
    Console.Write("Введите ФИО: ");
    string fio1 = Console.ReadLine();
    Console.Write("Введите номер места: ");
    string place1 = Console.ReadLine();

    Console.Write("Введите ФИО: ");
    string fio2 = Console.ReadLine();
    Console.Write("Введите номер места: ");
    string place2 = Console.ReadLine();

    Console.Write("Введите ФИО: ");
    string fio3 = Console.ReadLine();
    Console.Write("Введите номер места: ");
    string place3 = Console.ReadLine();

    Console.Write("Введите ФИО: ");
    string fio4 = Console.ReadLine();
    Console.Write("Введите номер места: ");
    string place4 = Console.ReadLine();

    string[,] passengers = { { fio1, place1 }, { fio2, place2 }, { fio3, place3 }, { fio4, place4 } };

    Console.Write("Номер пасажира: ");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine($"ФИО: {passengers[num - 1, 0]}" + "\n" + $"Место: {passengers[num - 1, 1]}");
}

catch (IndexOutOfRangeException)
{
    Console.WriteLine("Вы ввели не существующее место");
}
catch (FormatException)
{
    Console.WriteLine("Вы ввели не число");
}
finally
{
    Console.WriteLine("Счастилого пути!");
}