/*Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/

// Создаю строковую переменную Aui - all user input для сбора данных и Ui - user input для ввода
string Aui = string.Empty;
string Ui = string.Empty;

// Создаю запрос на ввод в цикле до ввода 4 значений
Console.Clear();
while(Aui.Length < 4){
    Console.Write("Введите " + Aui.Length + " число : ");
    Ui = Console.ReadLine();
    Aui += Ui;
}

Console.Write("Точка пересечения двух прямых : ");
int x = 0;
int y = 0;
while(Aui[1] * x + Aui[0] != y){
    x++;
    while(Aui[3] * x + Aui[2] = y){
        y++;
    }
}
