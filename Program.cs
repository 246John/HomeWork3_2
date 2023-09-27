using System.Globalization;

Console.Clear();

// "Задача 10": Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int N2 = Number / 10 % 10;
if ((Number < 1000 && Number > 99) || (Number > -1000 && Number < -99))
{
    Console.WriteLine($"Ввод: {Number}, результат: {N2}");
}
else
{
    Console.WriteLine("Число не трёхзначное!");
}