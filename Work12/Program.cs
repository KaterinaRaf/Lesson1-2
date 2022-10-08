// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число для преобразования в двоичный код");
int a = Convert.ToInt32(Console.ReadLine());
int temp = a;
int index = 0;
while( temp > 0)
{
    index++;
    temp /= 2; //деление на 2
}
// Console.WriteLine(index);
int[] arr = new int[index]; // складывание полученных чисел в массив в обратном порядке
for (int i = arr.Length - 1; i >= 0; i--)
{
    arr[i] = a % 2;
    a /= 2;
}

PrintArray(arr);