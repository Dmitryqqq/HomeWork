/*Задача 27: Напишите программу, которая принимает на вход число
 и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int GetNumer(string mess) // проверка введения числа
{
    bool isCorrect = true;
    int num = 0;
    while (isCorrect)
    {
        Console.WriteLine(mess+" ");
        if(int.TryParse(Console.ReadLine(), out num))
        isCorrect = false;
        else Console.WriteLine("Введено некорректное число \n");

    }
    return num;
}

int number = GetNumer("Введите число");
string numS = Convert.ToString(number);
int summ = 0;
for (int i = 0; i < numS.Length; i++)
{
    summ = summ + number % 10 ;
    number = number / 10;
}

Console.WriteLine(summ);
