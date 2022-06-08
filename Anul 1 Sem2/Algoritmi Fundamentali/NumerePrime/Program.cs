/*
-----------------------------------------------------metoda 1
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int i = 0;
while (i< n)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
i = 0;

while (i < n)
{
    if (array[i] == 0 || array[i] == 1 || array[i] == 2)
        Console.Write("");
    else{
        int prim = 1;
        for(int j=2; j <= i; j++)
        {
            if (array[i] % j == 0)
                prim++;
        }
        if (prim == 1)
        {
            Console.WriteLine(array[i]);
        }
    }
    i++;
}
*/

int n = int.Parse(Console.ReadLine());
if(IsPrim(n))
    Console.WriteLine("Este Prim");
else
    Console.WriteLine("Nu este Prim");

if (IsPalindrom(n))
    Console.WriteLine("Este Palindrom");
else
    Console.WriteLine("Nu este Palindrom");

if (IsNumarPerfect(n))
    Console.WriteLine("Este Numar Perfect");
else
    Console.WriteLine("Nu este Numar Perfect");


static bool IsPalindrom(int n)
{
    int og = 0;
    int cn = n;
    while (n != 0)
    {
        og = og * 10 + n % 10;
        n = n / 10;
    }
    if (og == cn)
        return true;
    else
        return false;
}

static bool IsPrim(int n)
{
    
    if(n < 2)
        return false;
    if (n % 2 ==0)
        return false;
    if (n == 2)
        return true;
    for(int i=3;i*i < n; i += 2)
    {
        if (n % 2 == 0)
            return false;
    }
    return true;
}

static bool IsNumarPerfect(int n)
{
    if(n == 6 || n == 26 || n == 496 || n == 8128)
        return true;
    return false;
}