/* Написать программу, которая выводит случайное число из отрезка 
[10, 99] и показывает наибольшую цифру числа
Например:
78 -> 8
12 -> 2
85 -> 8
*/
int GetRandomNumberInRange(int start, int end)
{
    int result = 0;
    result = new Random().Next(start, end + 1);
    return result;
}
int GetMaxDigitFromNumber(int number)
{
    int max = number / 10;
    int secondDigit = number % 10;
    if (secondDigit > max)
    {
        max = secondDigit;
    }
    return max;
}
void main()
{
    int randomNumber = GetRandomNumberInRange(10, 99);
    int maxDigit = GetMaxDigitFromNumber(randomNumber);
    Console.WriteLine($"Для числа {randomNumber} большей цифрой является {maxDigit}");
}