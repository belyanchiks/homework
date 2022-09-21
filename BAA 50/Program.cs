// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void getMatrix(int[,] matrix)
{
    Random rand = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(-15, 15);
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SearchingInMatrix(int[,] matrix)
{
    bool check = false;
    int a = ReadNumber("Введите строку: ");
    int b = ReadNumber("Введите столбец: ");
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == a && j == b)
            {
                Console.WriteLine($"Ваше число: {matrix[i, j]}");
                check = true;
                break;
            }
        }
    }
    if (!check) Console.WriteLine("Такого элемента нет!");
}

int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");

int[,] matrix = new int[m, n];
getMatrix(matrix);
SearchingInMatrix(matrix);