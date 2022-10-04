// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке
// [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении
// сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

void FindNumber(int[] arr) // поиск заданного числа в массиве
{
    int count = 0;
    for (int i =0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        {
            count++;
        }
    }
    Console.WriteLine("Количество элементов массива от 10 до 99 равно " +count);
}



int[] array = new int[123];
FillArray(array, -200, 201);
FindNumber(array);