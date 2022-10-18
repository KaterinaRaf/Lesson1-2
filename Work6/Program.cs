//Задача 28: Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N. 4 -> 24    5 -> 120 
// Факториал !

int GetNumber()
{
            Console.WriteLine("Введите число: ");
      return Convert.ToInt32(Console.ReadLine());
}

int GetProduct (int number)
{
    int product = 1;
    for (int i = 1; i <= number; i++)
    {
        product = product * i;
    }
    return product;
}

int number = GetNumber();
Console.WriteLine("Произведение цифр равно: " + GetProduct(number));
