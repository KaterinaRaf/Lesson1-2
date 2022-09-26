// Напишите программу, которая принимает на вход число (А) и 
//выдаёт сумму чисел от 1 до А. 7 -> 28; 4 -> 10; 8 -> 36

int GetNumber()
{
    Console.WriteLine("Введите число А");
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum1toA(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
      sum += i;
    }
    return sum;
}

int A = GetNumber();
Console.WriteLine("Сумма чисел от 1 до " + A + " равна " + GetSum1toA(A));
