/*Задача 45: Напишите программу, которая будет создавать
 копию заданного массива с помощью поэлементного копирования.
 */

 int[] Copy(int[] arr)
 {
    int[] copyArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArr[i] = arr[i]; 
    }
    return copyArr;
 }

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    
}

 int[] mass = {3,5,8,5,2,6,-345,45,-34};
 int[] massCopy = Copy(mass);
 PrintArray(massCopy);
