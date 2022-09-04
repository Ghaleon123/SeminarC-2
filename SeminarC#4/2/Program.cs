// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Ввод данных
Console.WriteLine("введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int Z = 0;

// Условие работы программы
while (a > 0)
{
int numA = a % 10;
a = a / 10;
Z = Z + numA;
}
Console.WriteLine("сумма всех цифр в числе равна: " + Z);

// Вывод ответа
