// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Clear();
// Ввод данных
Console.WriteLine("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
string anyNumText = Convert.ToString(num);
// Условия для работы программы
if (anyNumText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}

// Вывод ответа