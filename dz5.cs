// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размера массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] num = new int[size];
RandonNum(num);
Console.WriteLine("В этом массиве: ");
PrintArray(num);

void RandonNum(int[] num)
{
    for(int i = 0; i < size; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}


int count = 0;

for (int x = 0; x < num.Length; x++)
{
if (num[x] % 2 == 0)
count++;
}
Console.WriteLine($"из {num.Length} чисел, {count} четных");


void PrintArray(int[] num)
{
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("[]");
    Console.WriteLine();
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 4;
int[] num = new int[size];
ArRandomNum(num);
PrintArray(num);

int sumNumIEven = 0;

for (int i = 1; i < num.Length; i += 2)
{
    sumNumIEven += num[i];
}
Console.Write(sumNumIEven);

void ArRandomNum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = 10;
int[] num = new int[size];
ArrayRandomNum(num);
PrintArray(num);

int max = num[0];
int min = num[0];

for (int i = 0; i < num.Length; i++)
{
    if (num[i] > max)
    {
        max = num[i];
    }
    else if (num[i] < min)
    {
        min = num[i];
    }
}

Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Минимальное число: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");

void ArrayRandomNum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 555);
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}