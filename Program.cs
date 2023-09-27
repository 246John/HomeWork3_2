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

//-----------------------------------------------------------------------

// "Задача 13": Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.

Console.WriteLine("Введите число: ");
Number = Convert.ToInt32(Console.ReadLine());

if (Number < 0) {Number *= -1;}

if (Number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (Number >=100 && Number <= 999)
{
    Console.WriteLine($"Третья цифра числа: {Number % 10}");
}
else if (Number > 999)
{
    while (Number > 999)
    {
        Number /= 10;   
    }
    Console.WriteLine($"Третья цифра числа: {Number % 10}");
}

//-----------------------------------------------------------------------

// "Задача 15": Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.WriteLine("Введите цифру дня недели: ");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());

if (DayOfWeek > 7 || DayOfWeek < 1)
{
    Console.WriteLine("Введите корректное значение! (1-7)");
}
else if (DayOfWeek == 6 || DayOfWeek == 7)
{
    Console.WriteLine("Выходной день! ^.^");
}
else
{
    Console.WriteLine("Будний день. :(");
}
