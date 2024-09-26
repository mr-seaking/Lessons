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
    Console.Write("среднее арифметическое значение всех введённых чисел: " + res);
}
catch (FormatException)
{
    Console.Write("Вы ввели не число");
}