/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int GetNumber(string text) 
{
    Console.WriteLine(text);
    int result = 0;
    bool isCorrect = false;
    while (!isCorrect) 
    {
        if (int.TryParse(Console.ReadLine(), out result)) isCorrect = true;
        else Console.WriteLine("Ввели не число");
    }
    return result;
}
//сразу присваиваем модуль числа, чтоб не считать "-" в цикле:
int number = Math.Abs(GetNumber("Введите число"));
int s = 0;

for (int i = 0; i < number.ToString().Length; i++)
{
    s = s + Convert.ToInt32(" " + number.ToString()[i]);
}

Console.WriteLine($"Сумма цифр в числе {number} равняется {s}.");