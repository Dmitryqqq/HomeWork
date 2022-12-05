// Определить количество цифр в числе

double GetNumer(string messege) // Проверка введенного числа.
{
    bool isCorrect = true;
    double number = 0;
    while (isCorrect)
    {
        Console.WriteLine(messege+" ");
        if(double.TryParse(Console.ReadLine(), out number))
        isCorrect = false;
        else Console.WriteLine("Введено не корректное число");
    }
    return number;
}

double num = GetNumer("Введите число ");
Console.WriteLine("Введено  "+num);
Console.WriteLine($"В этом числе {NumLength(num)} знаков");

int NumLength(double number) // Подсчет количества знаков в числе
{   int len = 1;
    double num = Math.Abs(number);
     while ( num/10 < 1)
    { 
        len = len + 1;
        num = num / 10;
    }
    return len;
}

