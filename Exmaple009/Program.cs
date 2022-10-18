// Интерполяция вывода строк через $ и {имя_переменной} так правильнее оформлять

int a = 5;
int b = 2;

Console.WriteLine($"Переменные: а={a}, b={b}");

//рандом вещественных (с дробной частью) чисел от 0 до 100

double number = new Random().NextDouble();  //в скобках нельзя выбирать число
double number1 = new Random().NextDouble(); // разряды выбираются путем умножения
double number2 = new Random().NextDouble(); // на 10, 100, 1000, ....

Console.WriteLine($"Числа: {Math.Round(number*100, 2)}, {number1*100}, {number2*100}");
