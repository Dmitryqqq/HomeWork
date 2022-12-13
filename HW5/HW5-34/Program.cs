/* Задача 34: Задайте массив заполненный случайными положительными
 трёхзначными числами. Напишите программу, 
 которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int GetNumber (string messege)
{
    bool isCorrect = false;
    int number = 0;
    Console.WriteLine(messege+" ");
    while(!isCorrect)
    {
        if(int.TryParse(Console.ReadLine() ?? "", out number))
          isCorrect = true;
        else Console.WriteLine("Введено некорректное число");
        
    }
    return number;
}

int []GetArray(int size)
{   int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100,1000);
    }
    return arr;
}

int CountEven(int []arr)
{   int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]%2 == 0) count++; 
    }
    return count;

}

void PrintMass(int []arr)
{    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+", ");

    }
    Console.WriteLine("]");
}

int num = GetNumber("Введите размер массива ");
int[] massiv = GetArray(num);
PrintMass(massiv);
Console.WriteLine(CountEven(massiv));


