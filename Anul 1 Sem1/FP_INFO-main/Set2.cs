using System;
using System.Collections.Generic;

public class Set2 {
	public static void Problema1() {
		Console.WriteLine("1.Se da o secventa de n numere.Sa se determine cate din ele sunt pare.");
		Console.WriteLine("Nr n=");
		int nr = Convert.ToInt32(Console.ReadLine()), nrFor, nrPare = 0;
		int i;
		for (i = 0; i < nr; i++) {
			nrFor = Convert.ToInt32(Console.ReadLine());
			if (nrFor % 2 == 0)
				nrPare++;
		}
		Console.WriteLine(nrPare + " numere sunt pare din " + nr + " numere.");
	}

	public static void Problema2() {
		Console.WriteLine("2.Se da o secventa de n numere.Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.");
		Console.WriteLine("Nr n=");
		int nr = Convert.ToInt32(Console.ReadLine()), nrFor, nrNeg = 0, nrZero = 0, nrPoz = 0;
		int i;
		for (i = 0; i < nr; i++) {
			nrFor = Convert.ToInt32(Console.ReadLine());
			if (nrFor < 0)
				nrNeg++;
			if (nrFor == 0)
				nrZero++;
			if (nrFor > 0)
				nrPoz++;
		}
		Console.WriteLine(nrNeg + " numere sunt negative, " + nrZero + " numere zero si " + nrPoz + " numere pozitive din " + nr + " numere.");
	}

	public static void Problema3() {
		Console.WriteLine("3.Calculati suma si produsul numerelor de la 1 la n.");
		Console.WriteLine("Nr n=");
		int nr = Convert.ToInt32(Console.ReadLine()), suma = 0, produs = 1;
		for (int i = 0; i < nr; i++) {
			suma += i;
			produs *= i;
		}
		Console.WriteLine("Suma numerelor de la 1 la " + nr + " este " + suma + " ,iar produsul numerelor este " + produs + ".");
	}

	public static void Problema4() {
		Console.WriteLine("4.Se da o secventa de n numere.Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero.Daca numarul nu se afla in secventa raspunsul va fi -1.");
		int nr = Convert.ToInt32(Console.ReadLine()), i, tmp;
		List<int> array = new List<int>();
		for (i = 0; i < nr; i++) {
			tmp = Convert.ToInt32(Console.ReadLine());
			array.Add(tmp);
		}

		Console.WriteLine("Caut numarul n=");
		nr = Convert.ToInt32(Console.ReadLine());
		tmp = -1;
		for (i = 0; i < array.Count | tmp == -1; i++) {
			if (nr == array[i]) {
				tmp = i;
			}
		}
		Console.WriteLine("Numarul " + nr + " se afla pe pozitia " + tmp + " a secventei.");
	}

	public static void Problema5() {
		Console.WriteLine("5.Cate elemente dintr - o secventa de n numere sunt egale cu pozitia pe care apar in secventa.Se considera ca primul element din secventa este pe pozitia 0.");
		int nr = Convert.ToInt32(Console.ReadLine()), i, tmp;
		List<int> array = new List<int>();
		for (i = 0; i < nr; i++) {
			tmp = Convert.ToInt32(Console.ReadLine());
			array.Add(tmp);
		}

		tmp = 0;
		for (i = 0; i < array.Count; i++) {
			if (i == array[i]) {
				tmp++;
			}
		}
		Console.WriteLine(tmp + " elemente sunt egale cu pozitia pe care apar in secventa");
	}

	public static void Problema6() {
		Console.WriteLine("6.Se da o secventa de n numere.Sa se determine daca numerele din secventa sunt in ordine crescatoare.");
		int nr = Convert.ToInt32(Console.ReadLine()), i, tmp;
		List<int> array = new List<int>();
		for (i = 0; i < nr; i++) {
			tmp = Convert.ToInt32(Console.ReadLine());
			array.Add(tmp);
		}

		tmp = 0;
		for (i = 0; i < array.Count; i++) {
			if (array[i] > array[i++]) {
				tmp++;
			}
		}
		if (tmp == 0)
			Console.WriteLine("Numerele din secventa sunt in ordine crescatoare");
		else
			Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare");
	}

	public static void Problema7() {
		Console.WriteLine("7.Se da o secventa de n numere.Sa se determine cea mai mare si cea mai mica valoare din secventa.");
		int nr = Convert.ToInt32(Console.ReadLine()), i, tmp, max, min;
		List<int> array = new List<int>();
		for (i = 0; i < nr; i++) {
			tmp = Convert.ToInt32(Console.ReadLine());
			array.Add(tmp);
		}

		max = array[i]; min = array[i];
		for (i = 0; i < array.Count; i++) {
			if (min > array[i])
				min = array[i];
			if (max < array[i])
				max = array[i];
		}
		Console.WriteLine("Cea mai mare valoare din secventa este " + max + " iar cea mai mica valoare este " + min + ".");
	}

	public static void Problema8() {
		Console.WriteLine("8.Determianti al n - lea numar din sirul lui Fibonacci.Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n - 1) + f(n - 2).Exemplu: 0, 1, 1, 2, 3, 5, 8...");
		int nr = Convert.ToInt32(Console.ReadLine()), i, tmp = 0;
		List<int> array = new List<int>();
		for (i = 0; i < nr; i++) {
			if (i == 0)
				tmp = array[i] = 0;
			else if (i == 1)
				tmp = array[i] = 1;
			else
				tmp = array[i] = array[i - 1] + array[i - 2];
			array.Add(tmp);
		}
		Console.WriteLine("Al " + nr + "-lea numar din sirul lui fibonacci este" + tmp + ".");
	}

	public static void Problema9() {
		Console.WriteLine("9.Sa se determine daca o secventa de n numere este monotona.Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.");
		int nr = Convert.ToInt32(Console.ReadLine()), i, tmp;
		List<int> array = new List<int>();
		for (i = 0; i < nr; i++) {
			tmp = Convert.ToInt32(Console.ReadLine());
			array.Add(tmp);
		}

		tmp = 0;
		for (i = 1; i < nr; i++) {
			if (array[i] != array[i - 1])
				tmp = 1;
		}
		if (tmp == 1)
			Console.WriteLine("Secventa nu este monotona.");
		else
			Console.WriteLine("Secventa este monotona.");
	}

	public static void Problema10() {
		Console.WriteLine("10.Se da o secventa de n numere.Care este numarul maxim de numere consecutive egale din secventa.");
		int nr = Convert.ToInt32(Console.ReadLine()), i, tmp, currentCons = 0, lastmax = 0;
		List<int> array = new List<int>();
		for (i = 0; i < nr; i++) {
			tmp = Convert.ToInt32(Console.ReadLine());
			array.Add(tmp);
		}

		for (i = 1; i < nr; i++) {
			if (array[i] != array[i - 1]) {
				if (lastmax <= currentCons)
					lastmax = currentCons;
				currentCons = 0;
			}
			else {
				currentCons++;
			}
		}
		Console.WriteLine("Numarul maxim de numerel consecutive este " + lastmax + ".");
	}

	public static void Problema11() {
		Console.WriteLine("11.Se da o secventa de n numere.Se cere sa se caculeze suma inverselor acestor numere.");
	}

	public static void Problema12() {
		Console.WriteLine("12.Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.");
	}

	public static void Problema13() {
		Console.WriteLine("13.O < secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr - o secventa in ordine crescatoare prin rotiri succesive(rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul).Determinati daca o secventa de n numere este o secventa crescatoare rotita.");
	}
	public static void Problema14() {
		Console.WriteLine("14.O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita.");
	}

	public static void Problema15() {
		Console.WriteLine("15.O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere.Sa se determine daca este bitonica.");
	}

	public static void Problema16() {
		Console.WriteLine("16.O < secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive(rotire = primul element devine ultimul).Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.");
	}

	public static void Problema17() {
		Console.WriteLine("17.Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.Determinati daca secventa reprezinta o secventa de paranteze corecta si, daca este, determinati nivelul maxim de incuibare a parantezelor.De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.");
	}
}
