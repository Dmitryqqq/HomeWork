/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// вводим числа
// инициализируем массив
// печатаем массив
// сортируем массив

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

int [,] DecreasingArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {  
         
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1)-j; k++)
            {
                if(arr[i,k]< arr[i,k+1])
                {
                    int temp = arr[i,k];
                    arr[i,k] = arr[i,k+1];
                    arr[i,k+1] = temp;


                }
            }
            
        }
    }
    return arr;
}

int row = GetNumber("Введте количества строк массива ");
int colonm = GetNumber("Введте количества столбцов массива ");
int[,] matrix = new int[row,colonm];
 matrix = InitMatrix(matrix);
PrintArr(matrix);
Console.WriteLine();
matrix = DecreasingArr(matrix);
PrintArr(matrix);