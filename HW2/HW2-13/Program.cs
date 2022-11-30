/*
Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int GetNumer(string message)
{
    bool isCorrect = false;
    int result = 0;
    
    while(!isCorrect)
    
    {
        Console.Write(message+" ");

        if(int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Вы ввели не корректное число. \n");
    }
    
    return result;
}

int num = GetNumer("Введите  число:");
 if (num <100)
 {
    Console.WriteLine("третьей цифры нет.");
 }
 else
  {
    Console.WriteLine(num%1000/100);
  }