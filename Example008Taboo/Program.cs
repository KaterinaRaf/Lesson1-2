// метод для поиска 

int GetNumber()
//{
    //*******первый способ******
    //string text = ""; //текст, который ввел пользователь
    //do 
    // {
        
    //     text = Console.ReadLine(); // проверка 
    // }
    // while (text.IndexOf(',') >= 0 || text.IndexOf('.') >= 0);
//     return Convert.ToInt32(text); // если нет лишних знаков (точки или зпт)
// }
//Console.WriteLine(GetNumber());
    
    //*****второй способ с текстовым оповещением******
{
    string text = ""; //текст, который ввел пользователь
    bool key = true;
    while (key)
    {
        text = Console.ReadLine();
        if (text.IndexOf(',') >= 0 || text.IndexOf('.') >= 0) // проверка на наличие символов введеных пользователем
        {
            Console.WriteLine("Введите верное число!!!");
            key = true;
        }
        else
        {
            key = false;
        }
    }

    return Convert.ToInt32(text); // если нет лишних знаков (точки или зпт)
}

Console.WriteLine(GetNumber());