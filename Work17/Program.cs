// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами
// первую и последнюю строку массива.


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

void ChangeArray(int[,] arr)
{
    int temp;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        temp = arr[0, j];
        arr[0, j] = arr[arr.GetLength(0) - 1, j];
        arr[arr.GetLength(0) - 1, j] = temp;
    }       
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива m"),
    n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);
FillArray(array);
PrintArray(array);
Console.WriteLine();
//Console.WriteLine("Новый массив: ");
ChangeArray(array);
PrintArray(array);
