// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Ввод данных
Console.WriteLine("введите число A");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число B");
int num2 = Convert.ToInt32(Console.ReadLine());

int deal = num1;
// Условия работы программы
for (int num3 = 1; num3 < num2; num3++){
deal = deal * num1;
}
Console.WriteLine("A в степени B равно: " + deal);

// Вывод ответа