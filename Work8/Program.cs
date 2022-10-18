// Задача 32: Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные,
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
            textArray += split;
        }
    }
    return textArray;
}

void ChangeArray(int[] arr) // замена знаков
{
    for (int i =0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int[] array = new int[4];
FillArray(array, -9, 9);
Console.WriteLine("Случайно заполненный массив: [" +StringArray(array, ", ") + "]");
ChangeArray(array);
Console.WriteLine("Массив с заменой элементов: " + "[" +StringArray(array, ", ") + "]");
