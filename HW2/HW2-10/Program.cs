/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int GetNumer(string message)
{
    bool isCorrect = false;
    int result = 0;
    
    while(!isCorrect)
    
    {
        Console.Write(message+" ");

        if(int.TryParse(Console.ReadLine(), out result) && result>99 && result<1000)
            isCorrect = true;
        else
            Console.WriteLine("Вы ввели не корректное число. \n");
    }
    
    return result;
}

int num = GetNumer("Введите трёхзначное число:");
Console.WriteLine(num%100/10);
