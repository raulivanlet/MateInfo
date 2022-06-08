﻿using System;

public class Set3 {
	public static void Problema1() {
		//De refacut
		Console.WriteLine("1.Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.");
		Console.WriteLine("Nr n=");
		/*
		int[] array;
		array = new int[10];
		array[0] = 1;


		int[][] arrays;
		arrays = new int[10][];
		arrays[1][1] = 1;


		int[,] arrayz;
		arrayz = new int[10, 10];


		List<int> list = new List<int>();
		list.Add(1);
		list.Remove(1);
		*/

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
		Console.WriteLine("2.Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1.");
		Console.WriteLine("N este egal cu:");
		int n = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("K este egal cu:");
		int k = Convert.ToInt32(Console.ReadLine());
		int[] vector = new int[n];
		int i;
		for (i = 0; i < n; i++) {
			Console.WriteLine("Enter line " + i + " value:");
			Console.Clear();
			vector[i] = Convert.ToInt32(Console.ReadLine());
		}

		bool foundValue = false;
		for (i = 0; i < n || foundValue == true; i++) {
			if (k == vector[i])
				foundValue = true;
		}

		if (foundValue)
			Console.WriteLine("Am gasit numarul " + k + " in indexul " + i + "");
	}

	public static void Problema3() {
		Console.WriteLine("3.Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).");
		Console.WriteLine("N este egal cu:");
		int n = Convert.ToInt32(Console.ReadLine());
		int[] vector = new int[n];
		for (int i = 0; i < n; i++) {
			Console.WriteLine("Enter line " + i + " value:");
			Console.Clear();
			vector[i] = Convert.ToInt32(Console.ReadLine());
		}

		int min = vector[0], max = vector[0];
		for (int i = 0; i < n; i++) {
			if (max < vector[i])
				max = vector[i];
			if (min > vector[i])
				min = vector[i];
		}

		Console.WriteLine(min + " este minumul vectorului dat, iar " + max + "este maximul.");
	}

	public static void Problema4() {
		Console.WriteLine("4.Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.");
		Console.WriteLine("N este egal cu:");
		int n = Convert.ToInt32(Console.ReadLine());
		int[] vector = new int[n];
		for (int i = 0; i < n; i++) {
			Console.WriteLine("Enter line " + i + " value:");
			Console.Clear();
			vector[i] = Convert.ToInt32(Console.ReadLine());
		}


		int min = vector[0], max = vector[0], minCount = 0, maxCount = 0;
		for (int i = 0; i < n; i++) {
			if (max < vector[i]) {
				max = vector[i];
				maxCount = 0;
			}
			else if (max == vector[i])
				maxCount++;

			if (min > vector[i]) {
				min = vector[i];
				minCount = 0;
			}
			else if (min == vector[i])
				minCount++;

		}

		Console.WriteLine(min + " este valoarea minima a vectorului dat, gasit de " + minCount + "ori, iar " + max + "este valoarea maxima , gasita de " + maxCount + " ori.");
	}

	public static void Problema5() {
		Console.WriteLine("5.Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero.");
		Console.WriteLine("N este egal cu:");
		int n = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("E este egal cu:");
		int e = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("K este egal cu:");
		int k = Convert.ToInt32(Console.ReadLine());
		int[] vector = new int[n];
		for (int i = 0; i < n; i++) {
			Console.WriteLine("Enter line " + i + " value:");
			Console.Clear();
			vector[i] = Convert.ToInt32(Console.ReadLine());
		}

		vector[--k] = e;

		for (int i = 0; i < n; i++) {
			Console.WriteLine("The line " + i + " has value:" + vector[i]);
		}
	}

	public static void Problema6() {
		Console.WriteLine("6.Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.");
		Console.WriteLine("N este egal cu:");
		int n = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("K este egal cu:");
		int k = Convert.ToInt32(Console.ReadLine());
		int[] vector = new int[n];
		for (int i = 0; i < n; i++) {
			Console.WriteLine("Enter line " + i + " value:");
			Console.Clear();
			vector[i] = Convert.ToInt32(Console.ReadLine());
		}

		for (int i = k--; i < n--; i++) {
			vector[i] = vector[i++];
		}

		for (int i = 0; i < n; i++) {
			Console.WriteLine("The line " + i + " has value:" + vector[i]);
		}
	}

	public static void Problema7() {
		Console.WriteLine("7.Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.");
		Console.WriteLine("N este egal cu:");
		int n = Convert.ToInt32(Console.ReadLine());
		int[] vector = new int[n];
		for (int i = 0; i < n; i++) {
			Console.WriteLine("Enter line " + i + " value:");
			Console.Clear();
			vector[i] = Convert.ToInt32(Console.ReadLine());
		}

		for (int i = 0; i < n / 2; i++) {
			int tmp = vector[i];
			vector[i] = vector[n - i];
			vector[n - i] = tmp;
		}

		for (int i = 0; i < n; i++) {
			Console.WriteLine("The line " + i + " has value:" + vector[i]);
		}
	}

	public static void Problema8() {
		Console.WriteLine("8.Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.");
		Console.WriteLine("N este egal cu:");
		int n = Convert.ToInt32(Console.ReadLine());
		int[] vector = new int[n];
		for (int i = 0; i < n; i++) {
			Console.WriteLine("Enter line " + i + " value:");
			Console.Clear();
			vector[i] = Convert.ToInt32(Console.ReadLine());
		}

		int lastVector = vector[n];
		vector[n] = vector[0];
		for (int i = 0; i < n--; i++) {
			vector[i] = vector[i++];
		}
		vector[n--] = lastVector;

		for (int i = 0; i < n; i++) {
			Console.WriteLine("The line " + i + " has value:" + vector[i]);
		}
	}

	public static void Problema9() {
		Console.WriteLine("9.Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.");
		/*
		Console.WriteLine("N este egal cu:");
		int n = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("K este egal cu:");
		int k = Convert.ToInt32(Console.ReadLine());
		int[] vector = new int[n];
		for (int i = 0; i < n; i++) {
			Console.WriteLine("Enter line " + i + " value:");
			Console.Clear();
			vector[i] = Convert.ToInt32(Console.ReadLine());
		}

		int lastVector = vector[n-k];
		vector[n-k] = vector[0];
		for (int i = 0; i < n-k-1; i++) {
			vector[i] = vector[i++];
		}
		vector[n-k-1] = lastVector;

		for (int i = 0; i < n; i++) {
			Console.WriteLine("The line " + i + " has value:" + vector[i]);
		}
		*/
	}

	public static void Problema10() {
		Console.WriteLine("10.Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1.");
		Console.WriteLine("N este egal cu:");
		int n = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("K este egal cu:");
		int k = Convert.ToInt32(Console.ReadLine());
		int[] vector = new int[n];
		for (int i = 0; i < n; i++) {
			Console.WriteLine("Enter line " + i + " value:");
			Console.Clear();
			vector[i] = Convert.ToInt32(Console.ReadLine());
		}

		int foundNumber = -1;
		for (int i = 0; i < n; i++) {
			if (vector[i] == k)
				foundNumber = i;
		}
		
		Console.WriteLine("The line " + foundNumber + " has value " + k + ".");
	}

	public static void Problema11() {
		Console.WriteLine("11.Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).");
        Console.WriteLine("N=");
		int n = Convert.ToInt32(Console.ReadLine());
		for (int i = 0; i <= n; i++)
        {

			if( (i <= 1) || (i == 2) || (i % 2 == 0) )
				Console.WriteLine(i);
            else 
				for (int j = 0; j < i; j++)
                {

                }
        }

	}

	public static void Problema12() {
		Console.WriteLine("12.Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.");
	}

	public static void Problema13() {
		Console.WriteLine("13.Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.");
	}
	public static void Problema14() {
		Console.WriteLine("14.Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului).");
	}

	public static void Problema15() {
		Console.WriteLine("15.Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.");
	}

	public static void Problema16() {
		Console.WriteLine("16.Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.");
	}

	public static void Problema17() {
		Console.WriteLine("17.Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.");
	}

	public static void Problema18() {
		Console.WriteLine("18.Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x.");
	}

	public static void Problema19() {
		Console.WriteLine("19.Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar).");
	}

	public static void Problema20() {
		Console.WriteLine("20.Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem.");
	}

	public static void Problema21() {
		Console.WriteLine("21.Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar).");
	}

	public static void Problema22() {
		Console.WriteLine("22.Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat.");
	}

	public static void Problema23() {
		Console.WriteLine("23.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare.");
	}

	public static void Problema24() {
		Console.WriteLine("24.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).");
	}

	public static void Problema25() {
		Console.WriteLine("25.(Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate.");
	}

	public static void Problema26() {
		Console.WriteLine("26.Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere.");
	}

	public static void Problema27() {
		Console.WriteLine("27.Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat.");
	}

	public static void Problema28() {
		Console.WriteLine("28.Quicksort. Sortati un vector folosind metoda QuickSort.");
	}

	public static void Problema29() {
		Console.WriteLine("29.MergeSort. Sortati un vector folosind metoda MergeSort.");
	}

	public static void Problema30() {
		Console.WriteLine("30.Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima.");
	}

	public static void Problema31() {
		Console.WriteLine("31. (Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara).");
	}

}
