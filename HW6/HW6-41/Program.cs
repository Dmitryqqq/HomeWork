/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

int GetNumer(string messege)
{
    bool isCorrect = false;
    int num = 0;
    while (!isCorrect)
    {
        Console.WriteLine(messege+" ");
        if(int.TryParse(Console.ReadLine() ?? "", out num))
        isCorrect = true;
        else Console.WriteLine("Вы ввели не корректное число \n");
        
    }
    return num;
}

int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = GetNumer($"Введите {i+1} число ");
    }
    return arr;
}

int CountMinus(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}

int number = GetNumer("Введте количество подсчитываемых чисел ");
int[] massiv = new int[number];
massiv = FillArray(massiv);
Console.WriteLine( CountMinus(massiv));
