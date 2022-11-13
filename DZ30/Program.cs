// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями 
// и единицами в случайном порядке.. Далее надо посчитать количество нулей и единиц,
// если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.

Console.WriteLine("Programm to get the new array from '0' and '1'.");
Console.WriteLine("If the number of '1' will be more than number of '0', you'll see 'TRUE', else 'False'");

Console.WriteLine("Input the number of the elements in array:\t");
int number = int.Parse(Console.ReadLine()!);

int[] array = new int[number];

if (number < 2)
{
    Console.WriteLine("Impossible to compare less than 2 elements");
}

else
{
void FillArray (int[] array)
{
    int length = array.Length;
    int index = 0;
    Random random = new Random();
    while (index < length)
    {
        array[index] = random.Next(0, 2);
        index++;
    }
}

void PrintArray(int[] arr)
{
    Console.Write("Array:\t");
    int count = arr.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(arr[position] + " ");
        position++;
    }
}

void TrueOrFalse(int[] array)
{
    int countZero = 0;
    int countOne = 0;
    
    for (int i = 0; i < number; i++)
    {
        if(array[i] == 0)
        {
            countZero++;
        }
        else
        {
            countOne++;
        }
    }

    if (countOne > countZero)
    {
        Console.WriteLine("\nTRUE");
        // с новой строки  \n
    }
    else
    {
        Console.WriteLine("\nFalse");
    }
}
FillArray(array);
PrintArray(array);
TrueOrFalse(array);
}
