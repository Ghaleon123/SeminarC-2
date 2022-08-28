// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
// Ввод данных
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string stringNum = Convert.ToString(num);
Console.WriteLine("вторая цифра введеного числа -> "+stringNum[1]);

// Вывод ответа
