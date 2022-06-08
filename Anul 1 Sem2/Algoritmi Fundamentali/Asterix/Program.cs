int n = 11 ,i ,j;
//n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
	n++;
int[,] mat = new int[n, n];
for (i = 0; i < n; i++)
	for (j = 0; j < n; j++) {

		if (i < n / 2 && j < n / 2) {
			Assign(1);
		}

		else if (j > n / 2 && i < n / 2) {
			Assign(2);
		}

		else if (i > n / 2 && j > n / 2) {
			Assign(i*10+j);
		}

		else if (i > n / 2 && j < n / 2) {
			Assign(6);
		}




		if ((j > n / 2 && i < n / 2) && (i + j > n-1)) {
			Assign(3);
		}

		if ((i > n / 2 && j > n / 2) && ( i + j < n)) {
			Assign(5);
		}
	}

for (i = 0; i < n; i++)
	for (j = 0; j < n; j++) {
		if (i == j) {
			Assign(0);
		}

		else if (i + j + 1 == n) {
			Assign(0);
		}

		else if (i == n / 2) {
			Assign(0);
		}

		else if (j == n / 2) {
			Assign(0);
		}
	}

for (i = 0; i < n; i++) {
	for (j = 0; j < n; j++) {
		Console.Write(mat[i, j] + " ");
	}
	Console.WriteLine();
}

void Assign(int nr) {	
	mat[i, j] = nr;
}