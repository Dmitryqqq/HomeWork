/*Задача 47. Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

/*
заполняем массив
печатаем массив
*/

// заполняем массив
 double[,] InitArray(double[,] arr)
 {
   Random rnd = new Random();
   for (int i = 0; i < arr.GetLength(0); i++)
   {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i,j] = 5-rnd.NextDouble()*10;
    }
   }
   return arr;
 }

// печатаем массив
void PrintArray(double [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)

    {
       for (int j = 0; j < arr.GetLength(1); j++)
       {
        Console.Write("{0:f1}",arr[i,j]);
        Console.Write(" ");
       } 
       Console.WriteLine();
    }
}
int m = 3;
int n = 4;
 double[,] array = new double[m,n];
array = InitArray(array);
PrintArray(array);
