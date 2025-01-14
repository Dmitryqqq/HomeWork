﻿/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
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
            Console.Write("{0:d2}",arr[i,j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int [,] InitArr(int [,]arr)
{
    int lenArr = arr.GetLength(0);
    int turn = 1;
    int count = 0;
    int i = 0;
    int j = -1;
    int step = 0;

    while (lenArr-0.5*turn > 0)
    {
      
            step = 0;
            while (step < lenArr - 0.5*turn)
            {
                j = j +1;
                count++;
                arr[i,j] = count;
                step++;
            }
       
            turn ++;    
            step = 0;
            while (step < lenArr - 0.5*turn)
            {
                i = i +1;
                count++;
                arr[i,j] = count;
                step++;
            }
        
            turn ++;       
            step = 0;
            while (step < lenArr - 0.5*turn)
            {
                j = j - 1;
                count++;
                arr[i,j] = count;
                step++;
            }
         
            turn ++;      
            step = 0;
            while (step < lenArr - 0.5*turn)
            {
                i = i -1;
                count++;
                arr[i,j] = count;
                step++;
            }
          
            turn ++;  


    }
    
   return arr;   
}

int number = GetNumber("Введите размер квадратного массива ");
int [,] matrix = new int[number,number];
matrix = InitArr(matrix);
PrintArr(matrix);


