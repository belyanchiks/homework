// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран. 
// Данные вводятся с консоли пользователем

int Read (string message)
{
Console.WriteLine(message);
return Convert.ToInt32(Console.ReadLine());
}

int [] Numb  = new int[8];
int i = 0 ;
 while (i < Numb.Length)
 {
 int NumberA = Read("Введите число: ");
 Numb[i] = NumberA;
 i++;
 }
 Console.WriteLine("Ваш массив: ");
 i = 0;
 while (i < Numb.Length)
 {
    Console.Write(Numb[i]+"   ");
 i++;
 }