int n = Convert.ToInt32(Console.ReadLine());
n++;
int[] array = new int[n];
int i = 0;
n--;
for (i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
array[i++] = 0;
n++;


for (i = 0; i < n; i++)
{
    int nrPerfect = 0;
    for (int j = 1; j < array[i]; j++)
    {
        if (array[i] % j == 0)
        {
            nrPerfect = nrPerfect + j;
        }
    }
    if (nrPerfect == array[i])
        array[i] = 1;
    else
        array[i] = 0;
}

for (i = 0; i < n; i++)
{
    if (i > 0 || i < --n)
        Console.Write(array[i] + " ");
    else
        Console.Write(array[i]);
}