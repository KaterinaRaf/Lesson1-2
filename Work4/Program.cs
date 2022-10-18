// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.


Console.WriteLine("Введите число!");
int N = Convert.ToInt32(Console.ReadLine());

void Tab(int a)
{
    int i = 0;
    while (i < a)
    {
        Console.WriteLine(Math.Pow(i,2));
        i++;
    }
}
Tab(N);
