// Напишите программу, которая принимает на вход целое или дробное число 
// и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

Console.WriteLine("Program to get the digits number of the inputed number.");
Console.Write("Input number:\t");
decimal number = decimal.Parse(Console.ReadLine()!);

if (number == 0)
{
    Console.WriteLine("There is 1 digit");
}

else
{
    while (number < 0)
    {
        number = number * -1;
    }

    while (number % 1 > 0)
    {
        number *= 10;
    }

    int newNumber = (int)number;

    int GetNumberOfDigits(int newNumber)
    {
        int count;
        for (count = 0; number > 1; count++)
        {
            number = number / 10;
        }
        return count;
    }

    int result = GetNumberOfDigits(newNumber);
    
    if (result == 1)
    {
        Console.WriteLine($"There is 1 digit");
    }
    else
    {
        Console.WriteLine($"There are {result} digits");
    }
}
