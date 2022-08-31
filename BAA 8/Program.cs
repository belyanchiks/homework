Console.Write("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
for (int i = a; i <= b; i++)
{
    if (i % 2 == 0) 
    {
        Console.Write(i + " ");
    }
}