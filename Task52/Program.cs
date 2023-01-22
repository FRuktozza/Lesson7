Console.WriteLine("Введите высоту массива");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ширину массива");
int n = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[m, n];

for (int i = 0; i < m; i++)
{
    Console.WriteLine($"Вводите элементы строки {i+1}");
    for (int j = 0; j < n; j++)
    {
        nums[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

double mean;
Console.WriteLine("Среднее арифметическое каждого столбца");

for (int j = 0; j < n; j++)
{
    mean = 0.0;
    
    for (int i = 0; i < m; i++)
    {
        mean += nums[i, j];
    }
    Console.Write($"{mean / (double) m:f1}; ");
}