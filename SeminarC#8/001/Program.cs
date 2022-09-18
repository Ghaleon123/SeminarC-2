// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

// Вводу данных
Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(array);
WriteArray(array);

// Условия выполнения программы


void OrderArrayLines(int[,] array)
{
  for (int a = 0; a < array.GetLength(0); a++)
  {
    for (int b = 0; b < array.GetLength(1); b++)
    {
      for (int c = 0; c < array.GetLength(1) - 1; c++)
      {
        if (array[a, c] < array[a, c + 1])
        {
          int T = array[a, c + 1];
          array[a, c + 1] = array[a, c];
          array[a, c] = T;
        }
      }
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int a = 0; a < array.GetLength(0); a++)
  {
    for (int b = 0; b < array.GetLength(1); b++)
    {
      array[a, b] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int a = 0; a < array.GetLength(0); a++)
  {
    for (int b = 0; b < array.GetLength(1); b++)
    {
      Console.Write(array[a, b] + " ");
    }
    Console.WriteLine();
  }
}

// Вывод ответа