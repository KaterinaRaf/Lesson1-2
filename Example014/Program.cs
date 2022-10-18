// Задача 63: Задайте значение вещественное N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

double GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToDouble(Console.ReadLine());
}

void WriteNumbers(double lastNumber)  // метод цикла
{
    int counter = 1;
    while(counter <= lastNumber)
    {
        if (counter + 1 <= lastNumber)
            Console.Write(counter + ", ");
        else
            Console.Write(counter);
        counter++;
    }
}

string WriteNumbersRecursion(int startNumber, double lastNumber)  // первый метод рекурсии
{
    if (startNumber <= lastNumber)
        return startNumber + ", " + WriteNumbersRecursion(startNumber+1, lastNumber);
    
    return string.Empty;
}

void WriteNumbersRecursionVoid(int startNumber, double lastNumber) //второй метод рекурсии
{
    if (startNumber <= lastNumber)
    {
        Console.Write(startNumber + ", ");
        WriteNumbersRecursionVoid(startNumber+1, lastNumber);
    }     
}

double number = GetNumberFromConsole("Введите вещественное число!");
WriteNumbers(number);
Console.WriteLine();
Console.Write(WriteNumbersRecursion(1, number));
Console.WriteLine();
WriteNumbersRecursionVoid(1, number);