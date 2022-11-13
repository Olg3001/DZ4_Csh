// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры 
// и далее выводит массив на экран в одну строку.


Console.WriteLine("Programm to get the array from the row of numbers.");
Console.WriteLine("Input number of elemets in array:\t");
// отступ в виде табуляции \t

int elementsCount = int.Parse(Console.ReadLine()!);
int[] myArray = new int[elementsCount];

if (elementsCount < 1)
{
    Console.WriteLine("Wrong input. Number of elements shoud be > 0");
}

else
{
void ReadArray(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.WriteLine($"\nInput the array element under index number {i}:\t ");
        // \n чистая строка перед
        myArray[i] = int.Parse(Console.ReadLine()!);
    }
}

void PrintArray(int[] myArray)
{
    Console.WriteLine();

    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + " ");
    }
}

ReadArray(myArray);
PrintArray(myArray);
}
