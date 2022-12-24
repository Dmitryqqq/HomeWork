/*Задача 66: Задайте значения M и N. Напишите программу,
 которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

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

int RecSum(int n, int m)
{ 
    
    if (n < m)
    {        
        
        n = n + RecSum(n + 1, m);
    }
return n ;
}

int n = GetNumber("Введите число ");
int m = GetNumber("Введите число ");

Console.WriteLine(RecSum(n,m));
