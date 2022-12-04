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
        else Console.WriteLine("Ввели не число!"); 
    }
    return result;
}

// функция генерации массива со случайными целыми числами с заданным размером
string GetArray(int minValue, int maxValue, int arrayLength)
{
    Random rnd = new Random();
    int[] array = new int [arrayLength];
    for (int i = 0; i < array.Length; i++) array[i] = rnd.Next(minValue,maxValue);
    var str = string.Join(", ", array);
    Console.WriteLine($"[{str}]");
    return str;
}

int arrayLength = GetNumber("Введите размер массива");
int minValue = GetNumber("Введите MIN значение элемента");
int maxValue = GetNumber("Введите MAX значение элемента");

GetArray(minValue,maxValue + 1, arrayLength);