/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

/*
задаем размер масива.
заполняем массив случайными числами
подсчитываем необходимые нечетные элементы
*/

// задаем размер масива.
 int GetNumber(string messege)
 {
    bool isCorrect = false;
    int number = 0;
    while (!isCorrect)
    {
        Console.WriteLine(messege+" ");
        if(int.TryParse(Console.ReadLine() ?? "", out number))
        isCorrect = true;
        else Console.WriteLine("Введено не корректное число \n");
    }
    return number;
 }
 
// заполняем массив случайными числами
void InitArray(int []array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i+=2)
    {
        array[i] = rnd.Next(-100,100);
    }

}
 
int CountEven(int []array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        count = count + array[i];
    }
    return count;
}

void PrintArray(int []array)
{ Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+", ");
    }
    Console.WriteLine("]");
}


int num = GetNumber("Введите размер массива ");
int []arr = new int[num];
InitArray(arr);
PrintArray(arr);
Console.WriteLine(CountEven(arr));
