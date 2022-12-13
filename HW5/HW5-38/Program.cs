/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

int GetNumber(string messege)
{
    bool isCorrect = false;
    int number = 0;
    while (!isCorrect)
    {
        Console.WriteLine(messege+" ");
        if(int.TryParse(Console.ReadLine() ?? "",out number))
        isCorrect = true;
        else Console.WriteLine("Введено не корректное число ");
    }
    return number;
}

double []InitArray(int size)
{
    Random rnd = new Random();
    double []array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(rnd.NextDouble()*100);
    }
    return array;
}

void PrintArray(double []arr)
{    
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]+", ");

        
    }
    Console.WriteLine("]");
}

int num = GetNumber("Введте размер массива");
double []arr = InitArray(num);
PrintArray(arr);
   int maxIndex = 0;
   int minIndex = 0;
   double max = arr[0];
   double min = arr[0];
for (int i = 0; i < num; i++)
{
    if(max < arr[i]) 
    {max = arr[i]; maxIndex = i;}

    if(min > arr[i]) 
    {min = arr[i]; minIndex = i;}
}
Console.WriteLine(arr[maxIndex]-arr[minIndex]);
Console.WriteLine(arr[0].GetType());
