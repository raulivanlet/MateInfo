int n = Convert.ToInt32(Console.ReadLine()) , i = 0;
n++;
int[] array = new int[n];
n--;
for (i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
array[i++] = 0;
n++;

//Aranjeaza array-ul
for (i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (array [i] > array[j])
        {
            int tmp = array [i];
            array [i] = array [j];
            array [j] = tmp;
        }
    }
}

//Printeaza doar valorile prime
for (i = 0; i < n; i++)
{
    bool isPrime = true;

    if (array[i] !<= 1)
        isPrime = false;

    else
        for (int j = 2; j < array[i]; j++)
            if (array[i] % j == 0)
                isPrime = false;

    if(isPrime == true)
        Console.Write(array[i] + " ");
}