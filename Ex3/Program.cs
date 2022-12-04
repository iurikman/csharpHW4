/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
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

int[] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = GetNumber("Введите число");    
}
var str = string.Join(", ", array);
Console.WriteLine($"[{str}]");