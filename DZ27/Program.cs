// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int DigitsSum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

Console.WriteLine("Programm to get the digits sum of the number.");
Console.WriteLine("Input number: ");
int number = int.Parse(Console.ReadLine()!);

if (number >= 0)
{
    DigitsSum(number);
}
else
{
    number = number * -1;
    DigitsSum(number);
}

Console.WriteLine("The digits sum of the number is " + DigitsSum(number));