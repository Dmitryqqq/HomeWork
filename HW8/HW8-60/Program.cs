/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
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

int[,,] InitMatrix(int [,,] array)
{
    int[,,] array1 = new int[array.GetLength(0),array.GetLength(1),array.GetLength(2)];
    Random rnd = new Random();
    int number = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (true)
                {
                     number= rnd.Next(10,100);
                    if(!Serch(array1,number))
                    {
                        array1[i,j,k] = number;
                        break;
                    }
                }
                
                
            }
            
        }
    }
    return array1;
}

bool Serch(int[,,]arr, int number)
{   bool rezalt = false;
   for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                
                if (arr[i,j,k] == number) rezalt = true;
                
            }
            
        }
    }
    return rezalt; 
}


void PrintArr(int [,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }   
        
    }
}

int num = GetNumber("Введите размер массива");
int [,,] matrix = new int[num,num,num];
matrix = InitMatrix(matrix);
PrintArr(matrix);

