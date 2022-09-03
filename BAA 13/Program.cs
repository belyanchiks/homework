// Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
string Per = Convert.ToString(A);
if (Per.Length > 2)
{
  Console.WriteLine("Третья цифра  " + Per[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}