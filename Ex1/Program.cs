/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetNumber(string text)
{
    int result = 0;
    bool isCorrect = false;
    Console.WriteLine(text);
    while (!isCorrect) 
    {
        if (int.TryParse(Console.ReadLine(), out result)) isCorrect = true;
        else Console.WriteLine("Ввели не число!");
    }
    return result;
}

int number = GetNumber("Введите число, чтоб возвести его в степень");
int pow = GetNumber("Введите степень");

Console.WriteLine($"Число {number} в степени {pow} = {Math.Pow(number, pow)}");