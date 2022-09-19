// работа в группе 1
int CreateNumber()
{
    return new Random().Next(100,1000);
}
int DeleteSecondDigit(int Number)
{
    int Hundred = Number / 100;
    int Ed = Number % 10;
    return (Hundred*10+Ed);
}

int Number = CreateNumber();
Console.WriteLine(Number);
Console.WriteLine(DeleteSecondDigit(Number));