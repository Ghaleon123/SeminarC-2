// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
// Ввод данных

Console.WriteLine("Найдите разницу между максимальным и минимальным элементов массива из вещественных чисел:");

// Условия работы программы
double[] aRealNums = new double[10];
  for (int num = 0; num < aRealNums.Length; num++ )
  {
    aRealNums[num] = new Random().Next(1, 10);
    Console.Write(aRealNums[num] + " ");
  }

double maxNum = aRealNums[0];
double minNum = aRealNums[0];

  for (int num = 1; num < aRealNums.Length; num++)
  {
    if (maxNum < aRealNums[num])
    {
      maxNum = aRealNums[num];
    }
        if (minNum > aRealNums[num])
    {
      minNum = aRealNums[num];
    }
  }

  double D = maxNum - minNum;

  Console.WriteLine($"разница между между максимальным ({maxNum}) и минимальным({minNum}) элементами: {D}");

// Вывод ответа