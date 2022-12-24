/*Задача 68: Напишите программу вычисления функции Аккермана
 с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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

int Ackkerman(int m, int n)
{ 
    
    if (m == 0)
    {        
        return n + 1;
    }
    else if(n == 0)
        {
            return Ackkerman(m - 1,1);

        }
        else
        {
            return Ackkerman(m-1,Ackkerman(m,n-1));
        }   

}


int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");

Console.WriteLine(Ackkerman(m,n));