// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
    int res = num / 100;
    int res2 = num / 10%10;
Console.WriteLine(res2);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
    if (num / 100 > 0)
    {
        int res1 = num / 100; 
        int res2 = res1 % 10;
        Console.WriteLine($"Третья цифра {res2} ");
    }
    else  
    {
        Console.WriteLine("Нет третьей цифры");
    }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели ");
int numdays =Convert.ToInt32(Console.ReadLine());
    if (numdays > 5)
{
    Console.WriteLine("Да, выходной день!");
} 
    else if (numdays <= 5)
    {
      Console.WriteLine("Нет, это рабочий день :( ");  
    }
    

    

    

    



