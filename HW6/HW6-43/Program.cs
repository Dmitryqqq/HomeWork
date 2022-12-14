/*Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double GetNumer(string messege)
{
    bool isCorrect = false;
    double num = 0;
    while (!isCorrect)
    {
        Console.WriteLine(messege+" ");
        if(double.TryParse(Console.ReadLine() ?? "", out num))
        isCorrect = true;
        else Console.WriteLine("Введено не корректное число ");
    }
    return num;
}

Console.WriteLine();
Console.WriteLine("Ищем точку пересечения двух прямых, \nзаданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
double b1 = GetNumer("Введите b1 ");
double k1 = GetNumer("Введите k1 ");
double b2 = GetNumer("Введите b2 ");
double k2 = GetNumer("Введите k2 ");
double x = (b2-b1)/(k1-k2);
double y = k1*x + b1; 
Console.WriteLine($"( {x}, {y} )");
