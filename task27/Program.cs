// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int GetSumDigit(int number)
{
    int sum_digit = 0;
    while (number > 0)
    {
        sum_digit = sum_digit + number % 10;
        number = number / 10;
    }
    return sum_digit;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum_digit;
sum_digit = GetSumDigit(number);
Console.WriteLine($"сумма цыфр числа {number} равна {sum_digit}]");