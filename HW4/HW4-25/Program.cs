/*Задача 25:
 Напишите цикл, который принимает на вход два числа (A и B)
  и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetNumer(string messege)
{
    bool isCorrect =true;
    int num = 0;
    while (isCorrect)
    {
        Console.WriteLine(messege+" ");
        if(int.TryParse(Console.ReadLine(), out num))
        isCorrect= false;
        else Console.WriteLine("Введено неверное число");
    }
    return num;
}

int A = GetNumer("Введите число А");
int B = GetNumer("Введите степень, число В");

Console.WriteLine(Math.Pow(A,B));