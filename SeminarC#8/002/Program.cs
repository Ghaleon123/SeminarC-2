// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

// Ввод данных
Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

// Условия выполнения программы
int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int a = 1; a < array.GetLength(0); a++)
{
  int tempSumLine = SumLineElements(array, a);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = a;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] array, int a)
{
  int sumLine = array[a,0];
  for (int b = 1; b < array.GetLength(1); b++)
  {
    sumLine += array[a,b];
  }
  return sumLine;
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

void WriteArray (int[,] array)
{
  for (int a = 0; a < array.GetLength(0); a++)
  {
    for (int b = 0; b < array.GetLength(1); b++)
    {
      Console.Write(array[a,b] + " ");
    }
    Console.WriteLine();
  }
}

// Вывод ответа