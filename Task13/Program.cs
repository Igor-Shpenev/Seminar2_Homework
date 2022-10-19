// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num)
{
    int result;
    while (num >= 1000)
    {
        num = num / 10;
    }
    if (num >= 100)
    {
        result = num % 10;
    }
    else
    {
        result = -1;
    }
    return result;
}

int result = ThirdDigit(number);
if (result == -1)
    Console.WriteLine("There is no third digit here!");
else
    Console.WriteLine($"Third digit number {number} is {result}");


