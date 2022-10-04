// Задача 33: Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

void FillArray(int[] array, int min, int max) // Случайный ввод массива по заданному диапозону
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

string StringArray(int[] array, string split) // преобразование массива в строку с заданным разделителем
{
    int length = array.Length;
    string textArray = String.Empty;
    for (int i = 0; i < length; i++)
    {
        textArray += array[i];
        if (i < length-1)
        {
            textArray += split; // добавление разделителя между эл-тами в строку
        }
    }
    return textArray;
}

int FindNumber(int[] arr, int find) // поиск заданного числа в массиве
{
    for (int i =0; i < arr.Length; i++)
    {
        if (arr[i] == find)
        {
            return i;
        }
    }
    return -1;
}



int[] array = new int[4];
FillArray(array, -9, 9);
Console.WriteLine("Случайно заполненный массив: [" +StringArray(array, ", ") + "]");

int number = 0;
Console.WriteLine("Введите число для поиска в массиве: ");
number = Convert.ToInt32(Console.ReadLine());
if (FindNumber(array, number) < 0)
        Console.WriteLine("Число " +number+ " в массиве не присутствует");
else
        Console.WriteLine("Число " +number+ " в массиве присутствует");