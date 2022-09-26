// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int n = ReadNumber("Введите размерность: ");
int[,] spiralMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
  spiralMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(spiralMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}