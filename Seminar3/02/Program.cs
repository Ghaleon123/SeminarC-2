//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine(" Введите координаты: ");
int x1 = Cte("x", "A");
int y1 = Cte("y", "A");
int z1 = Cte("z", "A");
int x2 = Cte("x", "B");
int y2 = Cte("y", "B");
int z2 = Cte("z", "B");

int Cte(string cN, string pN)
{
    Console.Write($"Введите координату {cN} точки {pN}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Dec(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double sLength =  Math.Round (Dec(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {sLength}");