// Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.
// Ввод данных
int [] numbers = new int[8];
Console.Write("[");

// Условие работы программы
for (int num = 0; num < numbers.Length; num++)
 {
    numbers [num] = new Random().Next(0, 11);
    Console.Write(" " + Method (num) + " ");
 }
Console.Write("]");

int Method (int num)
{
    return numbers[num];
}

// Вывод ответа
