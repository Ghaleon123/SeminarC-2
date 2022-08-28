// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
// Ввод данных
Console.Write("Введите цифру дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
// Условия для работы программы
void CheckingTheDayOfTheWeek (int day) {
  if (day == 6 || day == 7) {
  Console.WriteLine("(Выходной) -> да");
  }
  else if (day < 1 || day > 7) {
    Console.WriteLine("не является днем недели");
  }
  else Console.WriteLine("(не выходной) -> нет");
}

CheckingTheDayOfTheWeek(day);

// Вывод ответа