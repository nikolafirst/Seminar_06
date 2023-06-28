// Задача 42: 
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
string result = string.Empty;
int step = 0;
while (number != 0)
{
    step = number % 2;
    number /= 2;
    result = step + result;
}

Console.Write("В двоичной системе число равно: " + result);
