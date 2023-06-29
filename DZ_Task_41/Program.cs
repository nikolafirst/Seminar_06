/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

// Создаю строковую переменную Aui - all user input для сбора данных и Ui - user input для ввода
string Aui = string.Empty;
string Ui = string.Empty;

// Создаю запрос на ввод в цикле до ввода 'q'
while(Ui != "q"){
    Console.Clear();
    Console.WriteLine("Введите несколько чисел.");
    Console.WriteLine("Для завершения ввeдите 'q'");
    Console.Write("Введите число:");
    Ui = Console.ReadLine();
    Aui += Ui + " ";
}
// Создаю переменные для выделения положительных чисел и их подсчета
int Check = 0;
string Positive = string.Empty;
int count = 0;
Console.Write("Среди ввода есть следующие положительные числа : ");
// Создаю цикл для определения количества положительных чисел
for(int i = 0; i < Aui.Length;i++){
    // Обнуляю переменную Ui для перевода типа char в string и последующего сравнения
    Ui = string.Empty;
    Ui += Aui[i];
    // Исключаю отрицательные числа из цикла с проверкой на присутствие непереводимых символов в цифры
    // Остается возможность сохранять отрицательные числа
    if(Ui == "-"){
        for(int j = i + 1;j < Aui.Length;j++){
            try{
                Check = int.Parse(Ui);    
            }
            catch (System.Exception){
                i = j;
                Check = 0;
                break;
            }
        }
    }
    // Веду учет и сохраняю положительные числа до пробела после чередующихся
    else if(Ui == "0" || Ui == "1" || Ui == "2" || Ui == "3" || Ui == "4" || Ui == "5" || Ui == "6" || Ui == "7" || Ui == "8" || Ui == "9"){
        Check = int.Parse(Ui);
        if(Check > 0)
            Positive += Check;
        else{
            Ui = string.Empty;
            try{
                Ui += Aui[i - 1];
            }
            catch (System.Exception){
                Ui = string.Empty;
                continue;
            }
            if(Ui == "0" || Ui == "1" || Ui == "2" || Ui == "3" || Ui == "4" || Ui == "5" || Ui == "6" || Ui == "7" || Ui == "8" || Ui == "9" || Ui == " ")
                Positive += "0";
            Ui += Aui[i + 1];
            if(Ui == "0" || Ui == "1" || Ui == "2" || Ui == "3" || Ui == "4" || Ui == "5" || Ui == "6" || Ui == "7" || Ui == "8" || Ui == "9" || Ui == " ")
                Positive += "0";
        }
        Ui = string.Empty;
        Ui += Aui[i + 1];
        if(Ui == " ")
            Positive += " ";
        Check = 0;
    }
}
// Ввывожу в консоль положительные числа по циклу и их колличество
for(int k = 0;k < Positive.Length; k++){
    Ui = string.Empty;
    Ui += Positive[k];
    if(Ui == " "){
        count++;
        Console.Write(" ");
    }
    else
        Console.Write(Positive[k]);        
}
Console.WriteLine();
Console.Write("Введено следующее колличество положительных чисел : " + count);
