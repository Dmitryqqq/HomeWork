/*Задача 50. Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента или же указание,
  что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

// Введем количество строк массива
// Введем количество столбцов массива
// печатаем массив
// введем позицию искомого элемента
// ответ

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
 
 int row = GetNumer("Введите количество строк массива ");
 int colomn = GetNumer("Введите количество столбцов массива ");
 int [,]array = new int[row,colomn];
 array = InitArray(array);
 PrintArray(array);
int index = GetNumer("Введите индекс искомого числа ");
while( index<11 || index%10 == 0)
{
    Console.WriteLine("Введено не корректное число \n");
    index = GetNumer("Введите индекс искомого числа ");
}
if(index/10 > row || index%10 > colomn )
Console.WriteLine("Такого числа в массиве нет "); 
else Console.Write("Искомое число "+array[index/10-1 , index%10-1 ]);
