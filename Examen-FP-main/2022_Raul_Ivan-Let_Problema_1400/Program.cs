int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    array [i] = Convert.ToInt32(Console.ReadLine());
}



int[] val = new int[n];
for (int i = 0; i < n; i++)
{
    val[array[i]] = val[array[i]] + 1;
}

bool isPal = true;
for (int i = 0; i < val.Length; i++)
{
    if (val[i] != 0)
    {
        if (val[i]! > val[i++])
            isPal = false;
    }
}

if(isPal ==true)
    Console.WriteLine("DA");
else
    Console.WriteLine("NU");