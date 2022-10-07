// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int GetSecondNumber(int num)
{
    int dec = (num / 10) % 10;
    return dec;  
}

int number = new Random().Next(100, 999);              
int secondNumber = GetSecondNumber(number);
Console.WriteLine($"A number {number} without a second number {secondNumber}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
void PrintThirdNumber(int num)
{
    if(num / 100 == 0)
        Console.WriteLine("Third number absent");
    else
        {
            while(num / 1000 > 0)
            {
                num = num / 10;
            }    
        }
    Console.WriteLine(num %  10);
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintThirdNumber(number);
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool IsWeekend(int day)
{
    return day > 5;
}

Console.Write("Input weekday: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 7)
    Console.WriteLine($"Not weekday!");
else
{
    if(IsWeekend(day))
        Console.WriteLine($"This day is weekend!");
    else
        Console.WriteLine($"Not weekend!");
}
*/