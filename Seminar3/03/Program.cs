// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
int ce = Convert.ToInt32(Console.ReadLine());

void Cube(int[] ce){
  int cer = 0;
  int length = ce.Length;
  while (cer <  length){
    ce[cer] = Convert.ToInt32(Math.Pow(cer, 3));
    cer++;
  }
}

void PrintArry(int[] cl){
  int count = cl.Length;
  int index = 0;
  while(index < count){
    Console.Write(cl[index]+ " ");
    index++;
  }
} 

int[] ar = new int[ce+1];
Cube(ar);
PrintArry(ar);