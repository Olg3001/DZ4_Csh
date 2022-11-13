// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double GetDegreeBForNumberA(int numberA, int numberB)
{
    double result = Math.Pow(numberA, numberB);
    return result;
}

Console.WriteLine("Programm to get degree B of number A.");
Console.WriteLine("Input number A: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Input positive integer B:\t");
int numberB = int.Parse(Console.ReadLine()!);

if (numberB < 1)
{
    Console.WriteLine("Wrong input");
}

else
{
    Console.WriteLine(numberA + "^" + numberB + " = " + GetDegreeBForNumberA(numberA, numberB));
}
