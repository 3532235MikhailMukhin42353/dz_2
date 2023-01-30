

try
{
Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int numA = number / 10;  
int numB = numA % 10;   
if (number > 99 && number < 1000) Console.WriteLine($"Число трехзначное, второе число: {numB}");
else Console.WriteLine("Число не трехзначное!");
}
catch
{
    Console.WriteLine("Нежно ввести имеено число!!!");
}