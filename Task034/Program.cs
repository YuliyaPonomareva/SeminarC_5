// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int Prompt (string msg)
{
    Console.Write (msg);
    int val = int.Parse(Console.ReadLine()!);
    return val;
}

int [] GetArray (int size)
{
    int [] res =  new int [size];
    for (int i = 0; i < size; i++)
    {
        res [i] = new Random().Next(100,1000);    
    }
    return res;
}

void PrintArray (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void FindEvenNum (int [] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0)
        {
            count ++;
        }
    }
    Console.WriteLine($"Количество четных чисел = {count}");
}

int value = Prompt ("Из скольки элементов создадим массив? - ");
int [] array = GetArray(value);
PrintArray (array);
Console.WriteLine();
FindEvenNum(array);