int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
if( n >= m)
{
    int[,] array = new int[n,n];
}
else
{
    int[,] array = new int[m, m];
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; i < m; i++)
    {
        array[i, j] = Convert.ToInt32(Console.ReadLine());
    }
        
}

