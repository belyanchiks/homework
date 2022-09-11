// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbersFrom1ToA(int a)
{
    if (a >= 1)
    {
        int sum = 0;
        for (int i = a; i > 0; i= i / 10)
        {
            int ost =  i % 10;
            sum = sum + ost;
        }
        return sum;
    }
    else
    {
        Console.WriteLine("A должна быть не меньше 1!");
        return -1;
    }
}

int number = ReadNumber("Введите число :");
int sum = SumNumbersFrom1ToA(number);
Console.WriteLine($"Ответ = {sum}");