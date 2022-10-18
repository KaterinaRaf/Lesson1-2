// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 2D пространстве.
// Math.Sqrt(int a); Math.Pow(x,2);


double GetNumber(string name) // метод для ввода чисел
{
    Console.WriteLine("Введите координату " + name);
    return Convert.ToDouble(Console.ReadLine());
}

double x1 = GetNumber("x1");
double x2 = GetNumber("x2");
double y1 = GetNumber("y1");
double y2 = GetNumber("y2");

double S = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
Console.WriteLine("Расстояние = " + S);
