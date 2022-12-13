//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2
int[] RandomIntegers(int min, int max, int size = 10)
{
    int[] array = new int[size];
    Random r = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = r.Next(min, max + 1);
    }
    return array;
}


static int NewMethod1(int[] numbers)
{
    int count = 0;
    for (int j = 0; j < numbers.Length; j++)
    {
        if (numbers[j] % 2 == 0) count++;
    }
    return count;
}


int[] numbers = RandomIntegers(min: 100, max: 999);
int count = NewMethod1(numbers);

Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine(count);