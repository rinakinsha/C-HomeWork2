void ThirdDigit(int number)
{
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
        Console.WriteLine("Третья цифра Вашего числа: " + third);
        
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

 Console.Write("Введите число: ");
 int num = Convert.ToInt32(Console.ReadLine());
 
ThirdDigit(num);