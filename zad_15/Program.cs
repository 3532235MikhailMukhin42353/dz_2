try
{
    Console.WriteLine("Введите день недели: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number >= 1 && number <= 5) Console.WriteLine("Рабочий день недели");
    else if (number >= 6 && number <= 7) Console.WriteLine("Выходной");
    else Console.WriteLine("Неккоректная дата!");
}
catch
{
    Console.WriteLine("Введите именно число!!!");
}