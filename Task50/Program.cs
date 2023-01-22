int[,] InitArray(int m, int n)
{
    int[,] nums = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            nums[i, j] = random.Next(0, 100);
        }
    }

    return nums;
}

Console.WriteLine("Введите высоту массива");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ширину массива");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = InitArray(m, n);

Console.WriteLine("Введите индекс i");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс j");
int j = Convert.ToInt32(Console.ReadLine());

if (i >= m || j >= n)
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine(array[i, j]);
}