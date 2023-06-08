// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int Prompt (string msg)
{
    Console.Write (msg);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int [] GetArray (int count, int minVal, int maxVal)
{
    int [] res =  new int [count];
    for (int i = 0; i < count; i++)
    {
        res [i] = new Random().Next(minVal,maxVal+1);    
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

void SumNecesseryNum (int [] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i %2 !=0)
        {
            sum = sum + arr[i];
        }
    }
    Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях = {sum}");
}

int count =  Prompt ("Введите длину массива: ");
int minVal = Prompt ("Введите минимальное значение элементов массива: ");
int maxVal = Prompt ("Введите максимальное значение элементов массива: ");
Console.WriteLine(); 
int [] array = GetArray (count, minVal, maxVal);
PrintArray (array);
Console.WriteLine();
Console.WriteLine();
SumNecesseryNum (array);
Console.WriteLine();