// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();
// Ввод данных
Console.WriteLine("Количество чётных чисел в массиве: ");
int[] numS = new int[10];

// Условия для работы программы
void FillArray(int[] array, int min, int max){
  for (int num = 0; num<array.Length; num++ ){
    array[num] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array){
    for (int num = 0; num<array.Length; num++ ){
    Console.Write(array[num] + " ");
  }
  Console.WriteLine();
}

int QuantityPositive(int[] array){
    int b = 0;
    for (int num = 0; num<array.Length; num++ ){
    if (array[num] % 2 == 1)
    {
      b++;
    }
  }
  return b;
}

FillArray(numS, 100, 1000);
WriteArray(numS);
Console.WriteLine();

int b = QuantityPositive(numS);
Console.WriteLine($"Количество чётных чисел в массиве: {b}");


// Вывод ответа