// Напишите программу, которая принимает на вход число (А) и 
//выдаёт сумму чисел от 1 до А. 7 -> 28; 4 -> 10; 8 -> 36

int GetNumber() // ввод числа
{
    int num = 0;
    while (num <= 1)
    {
    Console.WriteLine("Введите число больше 1!");
    num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
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
