/*Задача 23

Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int GetNumer(string messege)
{
    bool isCorrect = true;
    int num = 0;
    while (isCorrect)
    {
        Console.WriteLine(messege+" ");
        if(int.TryParse(Console.ReadLine(), out num ))
        isCorrect = false;
        else Console.WriteLine("Вы ввели не корректное число \n");   
    }
    return num;
}

int num = GetNumer("Введите число");
for (int i = 1; i <= num; i++)
{
    Console.Write(Math.Pow(i,3)+", ");
}