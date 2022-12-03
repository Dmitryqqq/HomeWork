/*Задача 29: Напишите программу, которая задаёт массив
 из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

*/

int GetNumer(string mess)
{
    bool isCorrect = false;
    int number = 0;
    while (!isCorrect)
    {
        Console.WriteLine(mess+" ");
        if(int.TryParse(Console.ReadLine(), out number))
        isCorrect = true;
        else Console.WriteLine("Введено не корректное число");
        
    }        
     return number;
    
}

int size = GetNumer("Введите размер массива");


 int []InitMass(int size, int A, int B) // заполнение массива размера size 
                                          //случайными числами от А до В 
 {
    int[] massiv = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = rnd.Next(A,B+1);
    }
    return massiv;
 }

 int[] mass = InitMass(size, 1, 99);

void PrintMass(int []massiv)   // Распечатываем массив
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]}, ");
    }
}

Console.Write("[");
PrintMass(mass);
Console.WriteLine("]");
Console.WriteLine("Печатаем через foreach");
foreach (int item in mass)
{
    Console.Write($"{item}; ");
}
