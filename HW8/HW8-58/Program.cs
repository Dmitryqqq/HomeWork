/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
            array[i,j] = rnd.Next(1,6);
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

void PrintArr2(int [,] arr,int [,] arr2)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]+" ");
        }
        Console.Write("| ");
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            Console.Write(arr2[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationMatrix(int[,] arr,int[,] arr2)
{
    int [,] matrix = new int[arr.GetLength(0),arr2.GetLength(1)];
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {   
        for (int j = 0; j < arr2.GetLength(1); j++)
        {   
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                matrix[i,j] = matrix[i,j] + arr[i,k]*arr2[k,j];
            }
             
        }
        


    }
    return matrix;
}

int row = GetNumber("Введте размер массива ");
int[,] matrix1 = new int[row,row];
int[,] matrix2 = new int[row,row];
int [,] matrix = new int[matrix1.GetLength(0),matrix2.GetLength(1)];
matrix1 = InitMatrix(matrix1);
matrix2 = InitMatrix(matrix2);
PrintArr2(matrix1,matrix2);
Console.WriteLine();
matrix = MultiplicationMatrix(matrix1,matrix2);
PrintArr(matrix);