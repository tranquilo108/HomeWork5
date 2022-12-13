//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6]-> 0

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

static int NewMethod2(int[] numbers)
{
    int sum = 0;
    for (int j = 1; j < numbers.Length; j += 2)
    {
        sum += numbers[j];
    }
    return sum;
}

int[] numbers = RandomIntegers(min: -100, max: 100, size: 10);
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine(NewMethod2(numbers));