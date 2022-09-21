// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Clear();
// Вводим данные
Console.Write("Введи M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"M={M}, N={N}");

// Условия выполнения программы
if (M>N)
for (int a = N; a <= M; a++)
    Console.Write($" {a}");
else
    for (int a = M; a <= N; a++)
        
Console.Write($" {a}");
// вывод ответа
