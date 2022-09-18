// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается 
// при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Вводите числа /стоп-слово 'stop'");

int i = 0;
bool check = true;       
while (check == true)
{
    string n = Console.ReadLine();
    if (n != "stop" && Convert.ToInt32(n) >0) i++;
    else if (n == "stop")
    {
        check = false;
        break;
    }
}

Console.WriteLine("");
Console.WriteLine($"Чисел больше нуля: {i}");