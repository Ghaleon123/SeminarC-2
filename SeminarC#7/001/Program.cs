// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

// Ввод данных
Console.WriteLine("введите количество строк");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] num = new double[lines, columns];
FillArrayRandomNumbers(num);
PrintArray(num);\

// Условия работы программы

void FillArrayRandomNumbers(double[,] array)
{
    for (int num1 = 0; num1 < array.GetLength(0); num1++)
    {
        for (int num2 = 0; num2 < array.GetLength(1); num2++)
        {
            array[num1, num2] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int num1 = 0; num1 < array.GetLength(0); num1++)
    {
        Console.Write("[ ");
        for (int num2 = 0; num2 < array.GetLength(1); num2++)
        {
            Console.Write(array[num1, num2] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Вывод ответа