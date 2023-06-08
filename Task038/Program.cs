// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();

int Prompt (string msg)
{
    Console.Write (msg);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

double [] GetArray (int count)
{
    double [] res =  new double [count];
    for (int i = 0; i < count; i++)
    {
        res [i] = new Random().Next(-1000,1001) / 100.00;    
    }
    return res;
}

void PrintArray (double [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void DiffMaxMin(double []array)
{
    double minNum = 0;
    double maxNum = 0;

    foreach (double el in array)
    {
        if (el > maxNum)
        {
            maxNum = el;
        }
        else if (el < minNum)
        {
            minNum = el;
        }
    }
    double diff = maxNum - minNum;
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {diff}");
}

int count =  Prompt ("Введите длину массива: ");
Console.WriteLine(); 
double [] array = GetArray (count);
PrintArray (array);
Console.WriteLine();
DiffMaxMin (array);
