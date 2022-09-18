//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// int value = Console.ToInt32(Next)

// bool IsEven (int value)
// {
//     return value % 2 == 0;
// } 

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
ArrayRandomNums(numbers);
Console.WriteLine("массив: ");

PrintArray(numbers);
int count = 0;

for (int l = 0; l < numbers.Length; l++)
if (numbers[l] % 2 == 0)
count++;

Console.WriteLine($"{numbers.Length}, {count} числа чётные");

void ArrayRandomNums(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}