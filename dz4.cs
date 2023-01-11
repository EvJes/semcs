// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число А ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int numB = Convert.ToInt32(Console.ReadLine());
int step = numA;

for (int i = 1; i<numB; i++)
{
    step = step * numA;
}
Console.WriteLine("А в стемени В равно: " + step);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int numI = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (numI > 0)
{
    int num = numI % 10;
    numI = numI /10;
    sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
