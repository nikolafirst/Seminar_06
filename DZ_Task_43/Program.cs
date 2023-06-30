/*Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

// Создаю строковые переменные Aui - all user input для сбора данных и Ui - user input для ввода
double[] Aui = new double[4];
string Ui = string.Empty;

// Создаю запрос на ввод в цикле до ввода 4 значений
Console.Clear();
Console.WriteLine("Введите числа 1 = b1; 2 = k1; 3 = b2; 4 = k2");
Console.WriteLine();
for(int i = 0;i < Aui.Length; i++){
    Console.Write("Введите " + (i + 1) + " число : ");
    Ui = Console.ReadLine();
    Console.WriteLine();
    try{
        double convert = Convert.ToDouble(Ui);    
        Aui[i] = convert;
    }
    catch (System.Exception){
        Console.WriteLine(" ");
        Console.WriteLine("Ошибка в переводе строки в число. Пожалуйста введите число");
        i--;
        continue;
    }
}
// Проверка на пересечение прямых
if(Aui[1] == Aui[3]){
    if(Aui[0] == Aui[2]){
        Console.Write("Прямые совпадают");
        Environment.Exit(0);
    }
    else{
        Console.Write("Прямые параллельны и не имеют точек пересечения");
        Environment.Exit(0);
    }
}

Console.WriteLine($"Точка пересечения двух прямых : y = {Aui[1]} * x + {Aui[0]}, y = {Aui[3]} * x + {Aui[2]}");
double x = (Aui[2] - Aui[0]) / (Aui[1] - Aui[3]);
double y = Aui[1] * x + Aui[0];
Console.Write($"Имеет координаты : ({x}, {y})");
