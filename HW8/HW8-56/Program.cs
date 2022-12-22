/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка
*/

int GetNumber(string message)
{
    int number = 0;
    while (true)
    {
        Console.WriteLine(message+" ");
        if(int.TryParse(Console.ReadLine() ?? "",out number))
        break;
        else Console.WriteLine("Введено не корректное число ");
    }
    return number;
}

int[,] InitMatrix(int [,] arr)
{
    int[,] array = new int[arr.GetLength(0),arr.GetLength(1)];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(1,10);
        }
    }
    return array;
}

void PrintArr(int [,] arr)
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

int FindMin(int[,] arr)
{
    int min = 0;
    int minRow = 0;
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {   
        int summa = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
             summa = summa+arr[i,j];
        }
        if(i == 0) min = summa;
        if (summa < min ) 
        {
            min = summa;
            minRow = i;
        }


    }
    return minRow;
}

int row = GetNumber("Введте размер массива ");
int[,] matrix = new int[row,row];
 matrix = InitMatrix(matrix);
PrintArr(matrix);
Console.WriteLine();
int minRow = FindMin(matrix);
Console.WriteLine($"наименьшая сумма элементов: {minRow+1} строка");