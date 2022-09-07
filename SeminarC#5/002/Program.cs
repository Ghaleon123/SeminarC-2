// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
// Ввод данных
Console.WriteLine("Сумма элементов,на нечётных позициях:");
Console.Write("Введи количество элементов массива: ");
int numE = Convert.ToInt32(Console.ReadLine()); 

int RandomNums(int numE, int min, int max)
  {
  int[] randomNums = new int[numE];
  int sumE = 0;
  Console.Write("Получившийся массив: ");

    for (int num = 0; num <randomNums.Length; num++ ){
      randomNums[num] = new Random().Next(min, max);

      Console.Write(randomNums[num] + " ");

      if (num % 2 != 1)
      {
        sumE = sumE + randomNums[num];
      }
    }
  return sumE;
  }

int randomNums =  RandomNums(numE, 1, 10);

Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: "+ (randomNums) );


// Вывод ответа
