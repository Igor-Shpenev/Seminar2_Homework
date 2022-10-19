// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int SecondDigit(int number)
{
    int digit23 = number % 100;
    int digit2 = digit23 / 10;
    return digit2;

}

int randNum = new Random().Next(100, 1000);
int result = SecondDigit(randNum);
Console.WriteLine($"Second digit of number {randNum} is {result}");
