// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

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


void CountDisting(int[,] arr) // поиск заданного числа в массиве
{
    int unicum = 0;
    int count = 0;
    while (unicum <= 9)
    {
        for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
        if (arr[i,j] == unicum)
            count++;
        }
    }
    Console.WriteLine($"Значение элемента массива {unicum} встречается {count} раз");
    unicum++;
    count = 0;
    }
}


//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива m"),
    n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);
FillArray(array);
PrintArray(array);
Console.WriteLine();
CountDisting(array);

