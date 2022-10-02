// Задача 31: Задайте массив из 12 элементов, заполненный случайными
// числами из промежутка [-9, 9]. Найдите сумму отрицательных и
// положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных
// чисел равна 29, сумма отрицательных равна -20.

//метод всегда возвращает только ОДНО число!!! Поэтому 2 метода пишем для этой задачи

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)  // массив начинается с нуля, длина на 1 символ меньше должен быть
    {
        arr[i] = new Random().Next(-9,10);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int GetSumPositive(int[] arr)   // при работе с массивами не передаем данные, а только ссылку на массив
{
    int sum = 0; //обязательно при входе в метод обнуляем переменную
    for (int i = 0; i < arr.Length; i++)   //перебираем массив
    {
        if (arr[i] > 0)
            sum += arr[i];   //сдвигаем по табуляции, так как действие по условию
    }
    return sum;
}

int GetSumNegative(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
            sum += arr[i];
    }
    return sum;
}

int[] GetSums(int[] arr)   //метод с массивом возвращает несколько однотипных переменных
{
    int[] sumArray = new int[2] {0, 0}; // [0] - сумма положительных, [1] - сумма отрицательных
    sumArray[0] = 0; // либо выше {0, 0};
    sumArray[1] = 0; // либо выше {0, 0};

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            sumArray[0] += arr[i];
        if (arr[i] < 0)
            sumArray[1] += arr[i];
    }
    return sumArray;
}

int LimitedArraySum(int[] array, bool direction, int limit)
{
    int sum = 0;

    if (direction)  // не надо проверять булевую переменную на true/false
    {
        for(int i = 0; i < array.Length; i++)
        
            if (array[i] > limit)
                sum += array[i];   
    }
    else
    {
        for(int i = 0; i < array.Length; i++)
        
            if (array[i] < limit)
                sum += array[i];  
    }
    return sum;
}


//***********************************
int[] massiv = new int[12];
FillArray(massiv);
PrintArray(massiv);

Console.WriteLine("Сумма положительных: " + GetSumPositive(massiv));
Console.WriteLine("Сумма отрицательных: " + GetSumNegative(massiv));

// Выходной массив из 2-х эл-тов 
// int[] OutMassiv = new int[2];
// OutMassiv = GetSums(massiv);
// Console.WriteLine("Сумма положительных: " + OutMassiv[0]);
// Console.WriteLine("Сумма отрицательных: " + OutMassiv[1]);


Console.WriteLine("Сумма положительных: " + GetSums(massiv)[0]); // указываем эл-т массива []
Console.WriteLine("Сумма отрицательных: " + GetSums(massiv)[1]);

Console.WriteLine("Сумма положительных: " + LimitedArraySum(massiv,true,0));
Console.WriteLine("Сумма отрицательных: " + LimitedArraySum(massiv,false,0));