// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.


int CreateNumber() // генерация случайного целого числа
{
    return new Random().Next(1,100);
}

int DivisionRemaider(int Num1, int Num2) // Нахождение остатка от деления второго числа на первое
{
    if (Num1 == 0)
    {
        return -1;
    }
            return Num2 - Num2/Num1*Num1; 
}

int Number1 = CreateNumber()/10;
int Number2 = CreateNumber();
int Ostatok = DivisionRemaider(Number1, Number2);

if (Ostatok==0)
{
    Console.WriteLine("Число "+Number2+" является кратным числу "+Number1);
}
else
if (Ostatok==-1)
{
    Console.WriteLine("("+Number2+"/"+Number1+") На 0 делить нельзя!");
}
else
{
    Console.WriteLine("Остаток от деления числа "+Number2+" на число "+Number1+" равен "+Ostatok);
}
