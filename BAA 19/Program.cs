// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99999 || number < 10000)
{
Console.WriteLine("Введите пятизначное число");
}
else if (number /10000 == number %10 && (number /1000)%10 == (number/10) % 10)
{
Console.WriteLine("Палиндром");
}
else
{
Console.WriteLine("Не является палиндромом");
}