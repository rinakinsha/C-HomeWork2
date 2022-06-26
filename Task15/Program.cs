void DayOfTheWeek (int day)
{
    if (day == 0)
    {
        Console.WriteLine("Понимаю, что в программировании нумерация начинается с 0, но не в этом случае, приятель :) ");
    }
    if (day > 0 & day <= 5)
    {
        Console.WriteLine("К сожалению, день под этим номером - не выходной :( ");
    }
    if (day > 5 & day <= 7)
    {
        Console.WriteLine("Выходно-о-о-й ~(^.^)~");
    }
    if (day > 7)
    {
        Console.WriteLine("Всего в неделе 7 дней, не пытайтесь меня обмануть -_-");
    }
}

Console.Write("Введите порядковый номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

DayOfTheWeek (number);
