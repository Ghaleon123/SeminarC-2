// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

// Ввод данных
Console.WriteLine("введите номер строки");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int numM = Convert.ToInt32(Console.ReadLine());
int [,] num = new int [10,10];
FillArrayRandomNumbers(num);

// Условия выполнения программы

if (numN > num.GetLength(0) || numM > num.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {numN} строки и {numM} столбца равно {num[numN-1,numM-1]}");
}

PrintArray(num);

void FillArrayRandomNumbers(int[,] array)
{
    for (int num1 = 0; num1 < array.GetLength(0); num1++)
        {        
            for (int num2 = 0; num2 < array.GetLength(1); num2++)
            {
                array [num1,num2] = new Random().Next(-100, 100)/10;
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int num1 = 0; num1 < array.GetLength(0); num1++)
    {
        Console.Write("[ ");
        for (int num2 = 0; num2 < array.GetLength(1); num2++)
        {
            Console.Write(array[num1,num2] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

// Вывод ответа