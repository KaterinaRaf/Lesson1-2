// Задача 55: Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.


int GetNumberFromConsole(string text) //пользовательский ввод данных
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue(int i, int j)
{
    return new Random().Next(0, 10);
}

void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++) // длина массива в строках
    {
        for(int j = 0; j < arr.GetLength(1); j++) // длина массива в столбце
        {
            arr[i,j] = GetRandomValue(i, j); // принимает значения из метода
        }
    }
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] InitializateArray(int m, int n) // создание массива. int[,] = возвращает двумерный массив
{
    return new int[m,n];
}

void TranspositionArray(int[,] arr)
{
    int[,] result = new int[arr.GetLength(1), arr.GetLength(0)];
    int a = arr.GetLength(1),
        b = arr.GetLength(0);
    if (a == b)
        {
        for(int i = 0; i < arr.GetLength(0); i++)
            for(int j = 0; j < arr.GetLength(1); j++)
                result[j, i] = arr[i, j];
        Console.WriteLine("Перевернутый массив: ");
        PrintArray(result);
        }
    else 
    Console.WriteLine("Для переворота массив должен быть квадратным!");
}


//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива m"),
    n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);
FillArray(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
TranspositionArray(array);
