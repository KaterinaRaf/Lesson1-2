///void Insert(int a)
//{
//Console.WriteLine("Вставить " + a);
//}

int CreateNumber()
{
   int number = new Random().Next(10,100); 
   return number;
}

int MaxDigit(int number)
{
    int Decin = number / 10;
    int Edinic = number % 10;
    
    if (Decin >= Edinic)
    {
        return Decin;
    }
    else 
    {
        return Edinic;
    }
  }

int a = CreateNumber();
Console.WriteLine(a);
Console.WriteLine(MaxDigit(a));