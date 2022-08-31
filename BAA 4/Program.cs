Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine("Nubmer Max = " + a); 
}
else if (b > c)
{
    Console.WriteLine("Number Max = " + b); 
}
else
{
    Console.WriteLine("Number Max = " + c);
}
                    
