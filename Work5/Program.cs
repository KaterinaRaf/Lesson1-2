// Задача 26: Напишите программу, которая принимает на вход число 
//и выдаёт количество цифр в числе. 456 -> 3


int numLength(int x)
{
    int i = 0;
    while(x > 0 || x < 0)
    {
        x = Math.Abs(x / 10);  // модуль числа
        i++;
    }
    return i;
}


Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

int s = numLength(x);
Console.WriteLine("Длина введеного числа = " + s + " знаков");
