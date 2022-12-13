//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

double[] RandomIntegers(int min, int max, int size = 10)
{
    double[] array = new double[size];
    Random r = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = r.Next(min, max + 1);
    }
    return array;
}


static double NewMethod3(double[] array)
{
    double diff = 0;
    double min = array[0];
    double max = array[0];
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > max)
        {
            max = array[j];
        }
        if (array[j] < min)
        {
            min = array[j];
        }
    }
    diff = max - min;
    return diff;
}

double[] numbers = RandomIntegers(min: 1, max: 100, size: 10);
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine(NewMethod3(numbers));