/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumer (string messege) // Проверка на ввод именно числа
{
    bool isCorrect = true;
    int num = 0;
    
    while (isCorrect)
    {
        Console.Write(messege+" ");
        if(int.TryParse(Console.ReadLine(), out num))
        isCorrect = false;
        else Console.WriteLine("Вы ввели не корректное число \n");
    }
    return num;
}

Console.WriteLine("Введите координаты точки А:");
int xa = GetNumer("Введите Xa :");
int ya = GetNumer("Введите Ya :");
int za = GetNumer("Введите Xa :");
Console.WriteLine("Введите координаты точки B:");
int xb = GetNumer("Введите Xb :");
int yb = GetNumer("Введите Yb :");
int zb = GetNumer("Введите Xb :");

// Расстояние между двумя точками в 3D
double Distanse(int x1, int y1, int z1, int x2, int y2, int z2) 
{
    double lin2D = Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
    double result = Math.Sqrt(Math.Pow(z1-z2,2)+Math.Pow(lin2D,2));
    return result;
}

Console.Write("Расстояние между этими точками: ");
Console.WriteLine("{0:f2}",Distanse(xa,ya,za,xb,yb,zb));