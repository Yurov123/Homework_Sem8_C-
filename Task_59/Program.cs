// В прямоугольной матрице найти строку с наименьшей суммой элементов

Console.Clear();

int[][] a;
Console.WriteLine("Enter n:"); 
int n = int.Parse(Console.ReadLine()); 
Console.WriteLine("Enter m:");
int m = int.Parse(Console.ReadLine());
a = new int[n][];
int[] sum = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = new int[n];
    for (int j = 0; j < m; j++)
    {
        Console.Write("Enter а[{0}][{1}] = ", i, j); 
        a[i][j] = int.Parse(Console.ReadLine());
        sum[i] += a[i][j];
    }

}
int max = Array.IndexOf(sum, sum.Max());
int min = Array.IndexOf(sum, sum.Min());

Console.Write("Maximum sum of array elements by rows {0} \n Array:", max);
for (int j = 0; j < m; j++)
{
    Console.Write(" {0} ", a[max][j]);
}
Console.WriteLine();
Console.Write("Minimum sum of array elements across rows {0} \n Array:", min);
for (int j = 0; j < m; j++)
{
    Console.Write(" {0} ", a[min][j]);
}



