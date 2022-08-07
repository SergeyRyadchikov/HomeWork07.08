void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + "; ");
        else
        {
            Console.Write(array[i]);
            Console.WriteLine();
        }
    }
}

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((new Random().NextDouble() * 20), 2);
    }
}

double DiffMaxMinArray(double[] coll)
{
    double min = coll[0];
    double max = coll[0];
    for (int j = 1; j < coll.Length; j++)
    {
        if (coll[j] < min) min = coll[j];
        if (coll[j] > max) max = coll[j];
    }
    return max - min;
}

Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] mass = new double[size];

FillArray(mass);
PrintArray(mass);
Console.Write("Разница между максимальным и минимальным элементом массива: " + Math.Round(DiffMaxMinArray(mass), 2));