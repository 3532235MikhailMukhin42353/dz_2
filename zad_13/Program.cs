Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int a = number.Length;
if(a > 2) Console.WriteLine($"Третье значение числа равно = {number[2]}");
else Console.WriteLine("Число не трехзначное!");

