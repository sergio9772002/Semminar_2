/* Напишите программу, которая выводит случайное трехзначное число
и удаляет вторую цифру этого числа
Например:
456 -> 46
782 -> 72
918 -> 98
*/
int GetRandomNumberInRange(int start, int end)
{
    int result = 0;
    result = new Random().Next(start, end + 1);
    return result;
}
int GetSecondNumber(int number)
{
    int firstDigit = number / 100;
    int secondDigit = firstDigit % 10;
    int threeDigit = number % 10;
    int NewNumber = firstDigit * 10 + threeDigit;
    return NewNumber;

}
int randomNumber = GetRandomNumberInRange(100, 999);
Console.WriteLine(randomNumber);
int newNumber = GetSecondNumber(randomNumber);
Console.WriteLine($" {newNumber} ");