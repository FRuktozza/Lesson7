Console.WriteLine("Введите высоту массива");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ширину массива");
int n = Convert.ToInt32(Console.ReadLine());

double[,] nums = new double[m, n];

Random random = new Random();
double maximum = 9.9;
double minimum = -9.9;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        nums[i, j] = random.NextDouble() * (maximum - minimum) + minimum;
        Console.Write($"{nums[i, j]:f1} ");
    }
    Console.WriteLine();
}