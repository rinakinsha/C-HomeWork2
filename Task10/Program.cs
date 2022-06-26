int SecondDigit()
{
    int number = new Random().Next(100, 1000);
    Console.WriteLine("Сгенерированное число: " + number);

    int twodigit = number / 10;
    int second = twodigit % 10;

    return second;
}

int result = SecondDigit();
Console.WriteLine("Вторая цифра сгенерированного числа: " + result);