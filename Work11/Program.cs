// Задача 40: Напишите программу, которая принимает на
//  вход три числа и проверяет, 
//  может ли существовать треугольник с сторонами такой длины.
//       ***Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива {i+1}");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void CheackArray(int[] arr)
{
    if (arr[0] + arr[1] > arr[2] && arr[0] + arr[2] > arr[1] && arr[1] + arr[2] > arr[0])
    {
        Console.Write("Треугольник с такими сторонами может существовать!");
    }
    else Console.Write("Треугольник с такими сторонами НЕ может существовать!");
    Console.WriteLine();
}

//КОД ОСНОВНОЙ ПРОГРАММЫ
int[] array = new int[3];
FillArray(array);
CheackArray(array);
