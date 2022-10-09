//Задача 51: Задайте двумерный массив. 
//Найдите сумму элементов, находящихся на главной диагонали 
//(с индексами (0,0); (1;1) и т.д. !!! i==j !!!
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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
 
int DiagonalSum(int[,] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.GetLength(0); i++) 
    {
        for(int j = 0; j < arr.GetLength(1); j++) 
        if (i == j)
            sum += arr[i,j];
    }
    return sum;
}
//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива m"),
    n = GetNumberFromConsole("Введите размерность массива n");
int[,] array = InitializateArray(m,n);

FillArray(array);
PrintArray(array);
Console.WriteLine("Сумма элементов главной диагонали: " +DiagonalSum(array));
