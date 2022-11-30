/*
Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int GetNumer(string message)
{
    bool isCorrect = false;
    int result = 0;
    
    while(!isCorrect)
    
    {
        Console.Write(message+" ");

        if(int.TryParse(Console.ReadLine(), out result) && result>0 && result<8)
            isCorrect = true;
        else
            Console.WriteLine("Вы ввели не корректное число. \n");
    }
    
    return result;
}

int num = GetNumer("Введите день недели (число от 1 до 7):");
if(num == 6 || num == 7)Console.WriteLine("да");

else Console.WriteLine("нет");