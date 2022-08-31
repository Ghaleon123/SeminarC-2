//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Ввод данных
Console.WriteLine("Введите число: ");
string? num = Console.ReadLine();

//Условие выполнения программы
void CheckingNumber(string num){
  if (num[0]==num[4] || num[1]==num[3]){
    Console.WriteLine($"Число: {num} - палиндром? Да.");
  }
  else Console.WriteLine($"Число: {num} - палиндром? Нет.");
}

if (num!.Length == 5){
  CheckingNumber(num);
}
else Console.WriteLine($"Введи правильное число");

//Вывод ответа