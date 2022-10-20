// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int num)
{
    int result;
    while (num >= 1000)   // уменьшаем заданное число до трехзначного
    {
        num = num / 10;
    }
    if (num >= 100)
    {
        result = num % 10;  // отделяем остаток - третью цифру
    }
    else
    {
        result = -1;        // отрицательный результат - третьей цифры нет
    }
    return result;
}

int result = ThirdDigit(number);
if (result == -1)
    Console.WriteLine("There is no third digit here!");
else
    Console.WriteLine($"Third digit number {number} is {result}");


