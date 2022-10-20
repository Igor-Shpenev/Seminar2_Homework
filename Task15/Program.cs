// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Enter a number from 1 to 7: ");
int number = Convert.ToInt32(Console.ReadLine());

int DayWeek(int num)
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine($"Day of the week number {number} is a weekend");   
    }
    else
    {
        Console.WriteLine($"Day of the week number {number} is not a weekend");
    }
    return num;
}

int day = DayWeek(number);
if (day > 7)
{
    Console.WriteLine("Incorrectly entered number!");
}

