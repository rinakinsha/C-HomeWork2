void ThirdDigit()
{
    Console.Write("Введите число: ");

    int number = Convert.ToInt32(Console.ReadLine());

    if(number<0)
    {
        number = number*-1;
    }
    if (number>=100)
    {
        while (number>1000)
        {
            number = number/10;
        }

        int third = number%10;
        Console.WriteLine("Третьей цифра Вашего числа: " + third);
        
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

ThirdDigit();