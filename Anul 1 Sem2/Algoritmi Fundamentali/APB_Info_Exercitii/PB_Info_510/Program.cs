using System;

namespace PB_Info_510
{
	internal class Program
	{
		static void Main()
		{
			int i, j = 0, tmp;
			int n = 7;
			//int n = Convert.ToInt32(Console.ReadLine());
			int[] nr = new int[] { 13, 1, 10, 15, 3, 7, 11 };
			//string[] stringTmp = Console.ReadLine().Split(' ');
			int[] prim = new int[n];
			/*
			for (i =0; i < n; ++i)
			{
				 nr[i] = Convert.ToInt32(stringTmp[i]);
			}
			*/

			for (i = 0; i < n; ++i)
			{
				if (IsPrime(nr[i]) == true)
				{
					prim[j] = nr[i];
					j++;
				}
			}

			int saven = n;
			for (i = 0; i < n; ++i)
			{
				if (prim[i] == 0)
					n = i;
			}

			for (j = 0; j < n; j++)
			for (i = n; i > 0; --i)
			{
				if (prim[i] != 0 && i > 1)
					if (prim[i] <= prim[--i])
					{
						tmp = prim[i];
						prim[i] = prim[--i];
						prim[--i] = tmp;
					}
					else if (i == 1)
						if (prim[i] >= prim[++i])
						{
							tmp = prim[i];
							prim[i] = prim[++i];
							prim[++i] = tmp;
						}

			}

			for (i = 0; i < saven; i++)
			{
				Console.WriteLine(prim[i]);
			}
		}
		static bool IsPrime(int val)
		{
			if (val <= 2)
				return false;

			for (int i = 2; i < val; i++)
			{
				if (val % i == 0)
					return false;
			}

			return true;
		}
	}
}
