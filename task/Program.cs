// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

using static System.Console;

string[] GetArray()
{
    Write("Введите значения массива через пробел: ");
    return ReadLine().Split(" ");
}

string[] ResultArray(string[] array)
{
    int count = 0;
    string[] result = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }
    return result;
}

string[] array = GetArray();
string[] result = ResultArray(array);

Console.WriteLine("Массив из строк, длина которых меньше, либо равна 3 символам:");
WriteLine($"[{string.Join(" ", result)}]");