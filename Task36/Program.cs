void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ", ");
        else
        {
            Console.Write(array[i]);
            Console.WriteLine();
        }
    }
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

int SumElements(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) res += array[i];
    }
    return res;
}

Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[size];

FillArray(mass);
PrintArray(mass);
Console.Write($"Сумма элементов на нечетной позиции: {SumElements(mass)}");