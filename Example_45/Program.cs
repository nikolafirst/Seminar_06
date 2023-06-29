/*Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.*/
// Создаем массив на 8-16 чисел и случайными значениями внутри от 0 до 999  


int [] array = new int [new Random().Next(8,17)];
Console.Write("Получен массив содрежащий следующие эллементы: ");

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,1000);
    Console.Write(array[i] + " ");
}

Console.WriteLine(" ");

Console.Write("Копия массива содрежит следующие эллементы: ");
for(int j = 0; j < array.Length; j++)
{
    copy[j] = array[j];
    Console.Write(copy[j] + " ");
}
