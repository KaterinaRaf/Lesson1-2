// 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка.

double GetNumber(string name) // метод для ввода чисел
{
    Console.WriteLine("Введите координату " + name);
    return Convert.ToDouble(Console.ReadLine());
}

int GetNumChet(double x, double y) // метод для расчета
{
    if (x > 0 && y > 0) // логическое И
    return 1; // первая четверть
    else
    if (x < 0 && y > 0) 
    return 2; 
    else
    if (x < 0 && y < 0) 
    return 3; 
    else
    return 4; 
}

double x = GetNumber("x");
double y = GetNumber("y");

Console.WriteLine("Четверть: " + GetNumChet(x,y));