// Задайте массив вещественных чисел. найти разницу между мин и макс элементами массива.

Console.Write("Введите размер массива: ");
int array = Convert.ToInt32(Console.ReadLine());
double[] x = new double [array];
ArrayRandomNums(x);
PrintArray(x);
void ArrayRandomNums(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100, 101);
        numbers[i] /= 10;
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[");
    for(int k = 0; k < numbers.Length; k++)
    {
        Console.Write($"({numbers[k]}) ");
    }
    Console.Write("]");
    Console.WriteLine();
}
double minValue (double[] x)
{
    double min = x[0];
    for (int i = 1; i < x.Length; i++)
    {
        if (min > x[i]) 
        min = x[i];
    }
    return min;
}double maxValue (double[] x)
{
    double max = x[0];
    for (int i = 1; i < x.Length; i++)
    {
        if (max < x[i])
        max = x[i];
    }
    return max;
}
double difference (double[] x)
{
    return maxValue(x) - minValue(x);
}
Console.Write(difference(x));




