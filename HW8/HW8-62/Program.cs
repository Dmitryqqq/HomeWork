/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07

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

int [,] InitArr(int [,]arr)
{
int [,] array = new int[,]
{
{01 ,02, 03, 04},
{12 ,13, 14, 05},
{11 ,16, 15, 06},
{10 ,09, 08, 07}
};
return array;
}

int [,] matrix = new int[4,4];
matrix = InitArr(matrix);
PrintArr(matrix);


// Сегодня день энергетикаю я 23 года в отрасли допишу позже, честно ))