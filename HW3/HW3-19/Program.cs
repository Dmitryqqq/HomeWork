/*Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

*/

// ------- КАК ЧИСЛО ----


double GetNumer(string text) // Проверка на ввод числа
{
    bool isCorrect = false;
    double num = 0;

    while(!isCorrect)
    {
        Console.WriteLine(text+" ");

        if(double.TryParse(Console.ReadLine(), out num))
            isCorrect = true;
        else Console.WriteLine("Введено не корректное число \n");

            
    }
    return num;
}

double num = GetNumer("Введите число: ");
string vvod = Convert.ToString(num);

string isCorrect = "Да";

    for (int i = 0; i < vvod.Length/2; i++)
    {
        if(vvod[i] != vvod[vvod.Length-1-i])
        isCorrect = "Нет";
    }
Console.WriteLine(isCorrect);

