// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

// Ввод данных

Console.WriteLine("введите количество строк");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int num2 = Convert.ToInt32(Console.ReadLine());

int[,] num = new int[num1, num2];
FillArrayRandomNumbers(num);

// Условия выполнения программы
for (int num4 = 0; num4 < num.GetLength(1); num4++)
{
    double avarage = 0;
    for (int num3 = 0; num3 < num.GetLength(0); num3++)
    {
        avarage = (avarage + num[num3, num4]);
    }
    avarage = avarage / num1 ;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(num);



void FillArrayRandomNumbers(int[,] array)
{
    for (int num3 = 0; num3 < array.GetLength(0); num3++)
    {
        for (int num4 = 0; num4 < array.GetLength(1); num4++)
        {
            array[num3, num4] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int num3 = 0; num3 < array.GetLength(0); num3++)
    {
        Console.Write("[ ");
        for (int num4 = 0; num4 < array.GetLength(1); num4++)
        {
            Console.Write(array[num3, num4] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Вывод ответа