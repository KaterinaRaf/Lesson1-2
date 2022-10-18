// Задача про рекурсию.
// Написать рекурсивный метод деления одного числа на другое.
// Нужно получить остаток от деления и результат деления.

int countSets = 0;

(int, int, int) InputNumber(string text) //Кортеж - вывод из метода сразу нескольких данных!
{
    Console.WriteLine(text);
    return (Convert.ToInt32(Console.ReadLine()),
            Convert.ToInt32(Console.ReadLine()),
            Convert.ToInt32(Console.ReadLine()));
}

int DivisionRemainder(int number, int divider) // определение остатка от деления
{
    countSets++;
    if (number >= divider) // условие остановки рекурсии
    {
        number -= divider;
        return DivisionRemainder(number, divider);
    }
    else 
        return number;
}

int DivisionFull(int number, int divider) //определение результата от деления
{
    if (number >= divider) // условие остановки рекурсии
    {
        number -= divider;
        return DivisionFull(number, divider) + 1;
    }
    else 
        return 0;
}

/* int number = InputNumber("Введите числитель: "),
    divider = InputNumber("Введите знаменатель: ");

Console.WriteLine($"{number}/{divider}={DivisionFull(number, divider)}, остаток {DivisionRemainder(number, divider)}");
Console.WriteLine($"Количество проходов: {countSets}"); */

var number = InputNumber("Введите числитель: ");   //для кортежа
Console.WriteLine(number.Item1);    // Item обращение к номеру эл-та

