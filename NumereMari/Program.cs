using System.Numerics;

//Ia numerele din consola
Console.WriteLine("Scrie numarul unu");
//string string1 = Console.ReadLine();
//string string1 = "273813801938711398716378163131312";
string string1 = "1111111111";

Console.WriteLine("Alege operatia:");
Console.WriteLine("1.Adunare");
Console.WriteLine("2.Scadere");
Console.WriteLine("3.Inmultire");
Console.WriteLine("4.Inpartire");
//int operation = Convert.ToInt32(Console.ReadLine());
int operation = 1;

Console.WriteLine("Scrie numarul doi");
//string string2 = Console.ReadLine();
//string string2 = "10131350937653895378639485";
string string2 = "111111111";


int string1Lenght ,string2Lenght, index;
bool isString1Negative = false , isString2Negative = false ,charIsValid = true;
string1Lenght = string1.Length;
string2Lenght = string2.Length;

int[] nr1 = new int[string1Lenght];
int[] nr2 = new int[string2Lenght];

if (IsNegative(string1[0]) == 1)
{
	isString1Negative = true;
}
else if (IsNegative(string1[0]) == 0)
{
	isString1Negative = false;
}
else if (IsNegative(string1[0]) == -1)
{
	isString1Negative = false;
	charIsValid = false;
}

if (charIsValid)
{
	for(index=0; index < string1Lenght && charIsValid == true; index++)
    {
		
		if(IsDecimal(string1[index]) != -1)
			nr1[index] = IsDecimal(string1[index]);
        else
        {
            Console.WriteLine("string 1 is invalid");
			charIsValid = false;
        }

    }


	if(charIsValid == true)
    {
		if (IsNegative(string2[0]) == 1)
		{
			isString2Negative = true;
		}
		else if (IsNegative(string2[0]) == 0)
		{
			isString2Negative = false;
		}
		else if (IsNegative(string1[0]) == -1)
		{
			isString2Negative = false;
			charIsValid = false;
		}


		for (index = 0; index < string2Lenght && charIsValid == true; index++)
		{

			if (IsDecimal(string2[index]) != -1)
				nr2[index] = IsDecimal(string2[index]);
			else
			{
				Console.WriteLine("string 2 is invalid");
				charIsValid = false;
			}

		}

	}

	//1.Adunare
	//2.Scadere
	//3.Inmultire
	//4.Inpartire
	//Make the Add or Substract OPERATIONS
	if ( (isString1Negative == false) && (operation == 1) && (isString2Negative == false) || (isString1Negative == false) && (operation == 2) && (isString2Negative == true) )
	{
		//P = A + B
		//P = A -(-B)

		if (string1Lenght >= string2Lenght)
        {
			int[] rez = new int[string1Lenght++];
			for (index = string1Lenght; index >=0; index--)
            {
				if ( (string1Lenght - index > 0 && string2Lenght - index > 0) && (index < string1Lenght && index < string2Lenght ) )
                {
					rez[index] += string1[index] + string2[index];
					if (rez[index] >= 10)
						rez[index--]++;
				}
				/*
				 * 
				 else if(string1Lenght - index > 0 && index < string1Lenght)
                {
					rez[index] += string1[index];
					if (rez[index] >= 10)
						rez[index--]++;
				}
				 */
				else if (index > 1 && index < string1Lenght)
                {
					rez[index] += string1[index];
					if (rez[index] >= 10)
						rez[index--]++;
				}
				else if (string2Lenght - index > 0 && index < string2Lenght)
				{
					rez[index] += string2[index];
					if (rez[index] >= 10)
						rez[index--]++;
				}
				
			}


		}
        else
        {
			int[] rez = new int[string2Lenght++];

			for (index = string2Lenght++; index >= 0; index--)
			{

			}
		}

		


	}
	else if  ( (isString1Negative == false) && (operation == 2) && (isString2Negative == false) || (isString1Negative == false) && (operation == 1) && (isString2Negative == true) )
	{
		/*
		 *	P = A - B
		 *	P = A + (-B)
		 * 
		 *	if A > B 
		 *		P = A - B
		 *		rezultat = A - B; 
		 *	else 
		 *		
		 *		- P = B - A
		 *		rezultat = B - A; rezultat = rezultat * -1;
		 */
	}
	else if ( (isString1Negative == true) && (operation == 2) && (isString2Negative == false) )
	{
		/*
		 *	P = -A - B 
		 *	-P = A + B 
		 * 
		 *	rezultat = A + B; rezultat = rezultat * -1; 
		 */
	}
	else if ( (isString1Negative == true) && (operation == 2) && (isString2Negative == true) || (isString1Negative == true) && (operation == 1) && (isString2Negative == false) )
	{
		/*
		 *	P = -A - (-B) 
		 *	P = -A + B sau P = B - A 
		 * 
		 *	if B > A 
		 *	P = B - A
		 *	rezultat = B - A;
		 *	
		 *	else
		 *	- P = A else
		 *	rezultat = A - B; rezultat = rezultat * -1;
		 */
	}

}





int IsDecimal(char var)
{
	switch (var)
	{
		case '0':
			return 0;

		case '1':
			return 1;

		case '2':
			return 2;

		case '3':
			return 3;

		case '4':
			return 4;

		case '5':
			return 5;

		case '6':
			return 6;

		case '7':
			return 7;

		case '8':
			return 8;

		case '9':
			return 9;

		default:
			return -1;
	}
}

int IsNegative(char firstChar)
{
	if (firstChar == '-')
		return 1;
	else if (IsDecimal(firstChar) != -1)
		return 0;
	else
		return -1;
}

if (true)
{
	/*

bool negative;
char index;

Console.WriteLine(n);
if (n % 6 == 0)
	n = n / 6;
else
{
	n = n / 6;
	n++;
}
int[] nr1 = new int[n];


n = string1.Length;
negative = false;
index = ' ';
if (string1[0] == '-')
{
    Console.WriteLine("string 1 is negative");
	negative = true;
	for (i = 1; i < n; i++)
	{
		int chr = Convert.ToInt32(string1[i]);


		nr1[n] =nr1[i] + chr * 10;

		if (i % 6 == 0)
        {
			n++;
        }
	}
}

else
{
	negative = false;
	for (i = 0; i < n; i++)
	{
		char chr = string1[i];
	}
}




i = 0;
foreach (char c in string1)
{
	if (i % 6 == 0)
		nr1[n] = Convert.ToInt32(c);
	else
	{
		nr1[n] = nr1[n] * 10 + Convert.ToInt32(c);
		n++;
		if (i == 5)
			n++;
	}
}

for (i = 0; i < n; i++)
{
	int save = nr1[i];
	for(int j = 0; j < 5; j++)
    {
		int tmp = save % 10;
		Console.Write(tmp);
		save = save / 10;
    }
}


*/


	/*
	Console.WriteLine("Hello, World!");
	Console.WriteLine("Scrie numarul unu");
	string string1 = Console.ReadLine();
	Console.WriteLine("Alege operatia:");
	Console.WriteLine("1.Adunare");
	Console.WriteLine("2.Scadere");
	Console.WriteLine("3.Inmultire");
	Console.WriteLine("4.Inpartire");
	int operation = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Scrie numarul doi");
	string string2 = Console.ReadLine();

	BigInteger BigInt1 = 0;
	BigInteger BigInt2 = 0;
	try {
		BigInt1 = BigInteger.Parse(string1);
	}
	catch (FormatException) {
		Console.WriteLine("Unable to convert the string '{0}' to a BigInteger value.", BigInt1);
	}

	if (BigInteger.TryParse(string2, out BigInt2)) {
	}
	else
		Console.WriteLine("Unable to convert the string '{0}' to a BigInteger value.", string2);

	if (operation == 1) {
		BigInt1 = BigInt1 + BigInt2;
	}
	if (operation == 2) {
		BigInt1 = BigInt1 - BigInt2;
	}
	if (operation == 3) {
		BigInt1 = BigInt1 * BigInt2;
	}
	if (operation == 4) {
		BigInt1 = BigInt1 / BigInt2;
	}
	Console.WriteLine("Rezultat=" + BigInt1);
	*/
}