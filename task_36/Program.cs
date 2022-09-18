// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write("Введите число: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] numbers = new int [size];
ArrayRandomNums(numbers);
PrintArray(numbers);
void ArrayRandomNums(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-10, 101); // -100 > 100
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[");
    for(int k = 0; k < numbers.Length; k++)
    {
        Console.Write(numbers[k] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
int SumElement (int[] numbers)
{
    int sum = 0;
    for (int l = 1; l < numbers.Length; l = l + 2)
    {
        sum = numbers[l] + sum;
    }
    return sum;
}
Console.Write($"Сумма элементов, стоящих на нечётных позициях = {SumElement(numbers)}");