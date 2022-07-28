// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int Number = Convert.ToInt32(number);

if (Number > 9999 && Number < 100000)
{
    int a = Number % 10;
    int b = Number % 100 / 10;
    int c = Number % 1000 / 100;
    int d = Number % 10000 / 1000;
    int e = Number % 100000 / 10000;
    if (a == e && b == d)
    {
        Console.WriteLine($"{Number} - палиндром.");
    }
    else Console.WriteLine($"{Number} - не палиндром.");
}
else Console.WriteLine("Введите пятизначное число");