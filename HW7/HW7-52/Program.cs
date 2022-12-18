/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int GetNumer(string message)
{
int num = 0;
while (true)
{
    Console.Write(message+" ");
    if(int.TryParse(Console.ReadLine() ?? "",out num)  )
    break;
    else Console.WriteLine("Введено не корректное число \n");

} 
return num;
}

void PrintArray(int[,]arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)

    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]+" ");
        }
        Console.WriteLine();
    }
}
 
int[,] InitArray(int[,] arr)
{  Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)

    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(1,10);
        }
    }
    return arr;
}

double SrArifmColomn(int [,]arr, int col)
{ double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = sum + arr[i,col];
    }
    return sum/arr.GetLength(0);
}
 
 void PrintOtvet(int [,]arr)
 {
    Console.Write("Среднее арифметическое кажого столбца: ");
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        Console.Write(SrArifmColomn(arr,i)+" ");
    }

 }
 int row = GetNumer("Введите количество строк массива ");
 int colomn = GetNumer("Введите количество столбцов массива ");
 int [,]array = new int[row,colomn];
 array = InitArray(array);
 PrintArray(array);
 PrintOtvet(array);