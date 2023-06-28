// Задача 40: 
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

Console.Write("Введите первое число: ");
int numFirst = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numSecond = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int numThird = int.Parse(Console.ReadLine());

if (numFirst < numSecond + numThird && numSecond < numFirst + numThird && numThird < numFirst + numSecond)
{
    Console.Write("Может существовать");
}
else
{
    Console.Write("Не может существовать");
}

