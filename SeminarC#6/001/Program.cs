// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

// Ввод данных

Console.WriteLine("Cколько чисел больше 0 ввёл пользователь ");
Console.Write("Введи число numМ(количество чисел): ");
int numM = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[numM];

// Условия работы программы
void InputNumbers(int numM){
for (int num1 = 0; num1 < numM; num1++)
  {
    Console.Write($"Введи {num1+1} число: ");
    massiveNumbers[num1] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int num1 = 0; num1 < massiveNumbers.Length; num1++)
  {
    if(massiveNumbers[num1] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(numM);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");

// Вывод ответа