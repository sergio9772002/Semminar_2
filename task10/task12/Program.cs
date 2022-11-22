/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли
второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток
от деления.
Например:
34, 5 - не кратно, остаток 4
16, 4 - кратно
*/
int userNumber1 = new int();
Console.WriteLine("Введите первое число");
userNumber1 = Convert.ToInt32(Console.ReadLine());
int userNumber2 = new int();
Console.WriteLine("Введите второе число");
userNumber2 = Convert.ToInt32(Console.ReadLine());
int del = userNumber2 % userNumber1;
if (del == 0) Console.WriteLine("Число 2 кратно числу 1");
else
{
    Console.WriteLine($"Число 2 не кратно числу 1, остаток {del}");
}