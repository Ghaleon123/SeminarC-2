// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

// Ввод данных
Console.WriteLine($"\n Найти точку пересечения двух прямых \n");

double[,] num3 = new double[2, 2];
double[] cPnum = new double[2];

// Условия выполнения программы
void InputCoefficients(){
  for (int num = 0; num < num3.GetLength(0); num++)
  {
    Console.Write($"Введите коэффициенты {num+1}-го уравнения (y = k * x + b):\n");
    for (int num1 = 0; num1 < num3.GetLength(1); num1++)
    {
      if(num1==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      num3[num,num1] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] num3)
{
  cPnum[0] = (num3[1,1] - num3[0,1]) / (num3[0,0] - num3[1,0]);
  cPnum[1] = cPnum[0] * num3[0,0] + num3[0,1];
  return cPnum;
}

void OutputResponse(double[,] num3)
{
  if (num3[0,0] == num3[1,0] && num3[0,1] == num3[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (num3[0,0] == num3[1,0] && num3[0,1] != num3[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(num3);
    Console.Write($"\nТочка пересечения прямых: ({cPnum[0]}, {cPnum[1]})");
  }
}

InputCoefficients();
OutputResponse(num3);

// Вывод ответа
