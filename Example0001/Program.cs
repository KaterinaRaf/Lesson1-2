///void Insert()
//{
//Console.WriteLine("Вставить");
//}

int CreateNumber()
{
   int number = new Random().Next(10,100); 
   return number;
}

int MaxDigit(int number);
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
int maxDigit = MaxDigit(a);
Console.WriteLine(maxDigit);