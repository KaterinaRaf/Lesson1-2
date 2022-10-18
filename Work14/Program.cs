// Задача 49: Задайте двумерный массив. 
//Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int GetNumberFromConsole(string text) //пользовательский ввод данных
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue(int i, int j)
{
    return new Random().Next(0, 10);
}

void FillArray(int[,] arr) // заполнение двумерного массива
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
 
int[,] ChangeArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++) 
    {
        if (i++ % 2 == 0)
            for(int j = 0; j < arr.GetLength(1); j++) 
            if (j++ % 2 == 0)
            arr[i,j] = arr[i,j] * arr[i,j];
    }
    return arr;
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива m"),
    n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);

FillArray(array);
PrintArray(array);
int [,] array2 = ChangeArray(array);
Console.WriteLine("Новый массив: ");
PrintArray(array2);
