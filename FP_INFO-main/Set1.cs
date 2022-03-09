using System;

public class Set1 {
	public static void Problema1() {
		Console.WriteLine("1.Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.");
		Console.WriteLine("A =");
		double a = Convert.ToDouble(Console.ReadLine()), b, x;
		if (a == 0) {
			Console.WriteLine("b trebuie sa fie 0");
		}
		else {
			Console.WriteLine("B =");
			b = Convert.ToDouble(Console.ReadLine());
			if (b == 0) {
				x = 0;
				Console.WriteLine("Numarul necunoscut x este:");
				Console.WriteLine(x);
			}
			else {
				x = -b / a;
				Console.WriteLine("Numarul necunoscut x este:");
				Console.WriteLine(x);
			}
		}
	}

	public static void Problema2() {
		Console.WriteLine("2.Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.");

		Console.WriteLine("A =");
		double a = Convert.ToDouble(Console.ReadLine()), b, c, x, delta;
		Console.WriteLine("B =");
		b = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("C =");
		c = Convert.ToDouble(Console.ReadLine());
		delta = b * b - 4 * a;
		if (delta == 0) {
			Console.WriteLine("Numarul necunoscut x este:");
			x = -b / 2 * a;
			Console.WriteLine(x);
		}
		else if (delta > 0) {
			Console.WriteLine("Numarul necunoscut x1 este:");
			x = (-b + Math.Sqrt(delta)) / (2 * a);
			Console.WriteLine(x);
			Console.WriteLine("Numarul necunoscut x2 este:");
			x = (-b - Math.Sqrt(delta)) / (2 * a);
			Console.WriteLine(x);
		}
		else if (delta < 0) {
			Console.WriteLine("Ecuatia nu are solutii reale");
		}
	}

	public static void Problema3() {
		Console.WriteLine("3.Determinati daca n se divide cu k, unde n si k sunt date de intrare.");
		Console.WriteLine("N =");
		int n = Convert.ToInt32(Console.ReadLine()), k;
		Console.WriteLine("K =");
		k = Convert.ToInt32(Console.ReadLine());
		if (n % k == 0)
			Console.WriteLine("Numarul n este divizibil cu k");
		else
			Console.WriteLine("Numarul n nu este divizibil cu k");
	}

	public static void Problema4() {
		Console.WriteLine("4.Detreminati daca un an y este an bisect.");
		Console.WriteLine("Y =");
		int y = Convert.ToInt32(Console.ReadLine());
		if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
			Console.WriteLine("Anul este bisect");
		else
			Console.WriteLine("Anul nu este bisect");
	}

	public static void Problema5() {
		Console.WriteLine("5.Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.");
		Console.WriteLine("NR =");
		int nr = Convert.ToInt32(Console.ReadLine()), k;
		Console.WriteLine("K =");
		k = Convert.ToInt32(Console.ReadLine());
		while (k > 1) {
			nr /= 10;
			--k;
		}
		nr %= 10;
		Console.WriteLine("Numarul este " + nr);
	}

	public static void Problema6() {
		Console.WriteLine("6.Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");
		Console.WriteLine("A =");
		int a = Convert.ToInt32(Console.ReadLine()), b, c;
		if (a < 0)
			while (a < 0) {
				Console.WriteLine("Numar Pozitiv");
				a = Convert.ToInt32(Console.ReadLine());
			}
		Console.WriteLine("B =");
		b = Convert.ToInt32(Console.ReadLine());
		if (b < 0)
			while (b < 0) {
				Console.WriteLine("Numar Pozitiv");
				b = Convert.ToInt32(Console.ReadLine());
			}
		Console.WriteLine("C =");
		c = Convert.ToInt32(Console.ReadLine());
		if (c < 0)
			while (c < 0) {
				Console.WriteLine("Numar Pozitiv");
				c = Convert.ToInt32(Console.ReadLine());
			}
		if ((a + b > c) && (a + c > b) && (b + c > a))
			Console.WriteLine("Numerele a,b,c pot filungimile laturilor unui triunghi");
		else
			Console.WriteLine("Numerele a,b,c nu pot filungimile laturilor unui triunghi");
	}

	public static void Problema7() {
		Console.WriteLine("7.(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.");
		Console.WriteLine("A =");
		int a = Convert.ToInt32(Console.ReadLine()), b;
		Console.WriteLine("B =");
		b = Convert.ToInt32(Console.ReadLine());
		int tmp = a;
		a = b;
		b = tmp;
		Console.WriteLine("Numarul a =" + a + " numarul b =" + b + ".");
	}

	public static void Problema8() {
		Console.WriteLine("8.(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.");
		Console.WriteLine("A =");
		int a = Convert.ToInt32(Console.ReadLine()), b;
		Console.WriteLine("B =");
		b = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Numarul a =" + b + " numarul b =" + a + ".");
	}

	public static void Problema9() {
		Console.WriteLine("9.Afisati toti divizorii numarului n.");
		Console.WriteLine("N =");
		int n = Convert.ToInt32(Console.ReadLine());
		for (int i = 0; i < n; i++) {
			if (n % i == 0)
				Console.WriteLine(i + "este divizor al lui " + n);
		}
	}

	public static void Problema10() {
		Console.WriteLine("10.Test de primalitate: determinati daca un numar n este prim.");
		Console.WriteLine("N =");
		int n = Convert.ToInt32(Console.ReadLine()), sf = 0;
		for (int i = 2; i < n; i++) {
			if (n % i == 0)
				sf = 1;
		}
		if (sf == 0)
			Console.WriteLine("Numarul " + n + " este prim");
		else
			Console.WriteLine("Numarul " + n + " nu este prim");
	}

	public static void Problema11() {
		Console.WriteLine("11.Afisati in ordine inversa cifrele unui numar n.");
		Console.WriteLine("N =");
		int n = Convert.ToInt32(Console.ReadLine());
		int tmp = 0;
		while (n != 0) {
			tmp = tmp * 10 + n % 10;
			n /= 10;
		}
		n = tmp;
		Console.WriteLine("Inversul numarului N este " + n);
	}

	public static void Problema12() {
		Console.WriteLine("12.Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].");
		Console.WriteLine("N =");
		int n = Convert.ToInt32(Console.ReadLine()), a, b, nr = 0;
		Console.WriteLine("A =");
		a = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("B =");
		b = Convert.ToInt32(Console.ReadLine());
		if (a > b) {
			int tmp = b;
			b = a;
			a = tmp;
		}
		for (int i = a; i < b; i++) {
			if (i % n == 0)
				nr++;
		}
		if (nr == 0)
			Console.WriteLine("Nu sunt numere divizibile nu " + n + " in intervalul " + a + " " + b);
		else
			Console.WriteLine("Sunt " + nr + " numere divizibile nu " + n + " in intervalul " + a + " " + b);
	}

	public static void Problema13() {
		Console.WriteLine("13.Determianti cati ani bisecti sunt intre anii y1 si y2.");
		int y1, y2, nr = 0;
		Console.WriteLine("y1 =");
		y1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("y2 =");
		y2 = Convert.ToInt32(Console.ReadLine());
		if (y1 > y2) {
			int tmp = y2;
			y2 = y1;
			y1 = tmp;
		}
		for (int i = y1; i < y2; i++) {
			if ((i % 4 == 0) && (i % 100 != 0))
				nr++;
			else if (i % 400 == 0)
				nr++;
		}
		if (nr != 0) {
			if (nr > 1)
				Console.WriteLine("Intre anii " + y1 + " si " + y2 + " sunt " + nr + " ani bisecti");
			else
				Console.WriteLine("Intre anii " + y1 + " si " + y2 + " este " + nr + " un an bisect");
		}
		else
			Console.WriteLine("Intre anii " + y1 + " si " + y2 + " nu sunt ani bisecti");
		//
		//
		//
		//
		//not finished / De testat
		//
		//
		//
		//
	}

	public static void Problema14() {
		Console.WriteLine("14.Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.");
		int nr, nrmirror, mirror = 0;
		Console.WriteLine("Nr =");
		nr = Convert.ToInt32(Console.ReadLine());
		nrmirror = nr;

		int digits = 0;
		while (nr != 0) {
			digits++;
			nr /= 10;
		}
		nr = nrmirror;
		for (int i = 0; i < digits; i++) {
			mirror = mirror * 10 + nr % 10;
			nr /= 10;
		}
		nr = nrmirror;
		if (nr == mirror)
			Console.WriteLine("Numarul " + nr + " este palindrom.");
		else
			Console.WriteLine("Numarul " + nr + " este palindrom.");
		//( nr % 2 !=0)		12321
		//( nr % 2 ==0)		1221
		//
		//
		//
		//not finished / De testat
		//
		//
		//
		//
	}

	public static void Problema15() {
		Console.WriteLine("15.Se dau 3 numere. Sa se afiseze in ordine crescatoare.");
		int nr1, nr2, nr3, tmp;
		Console.WriteLine("Nr 1 =");
		nr1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Nr 2 =");
		nr2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Nr 3 =");
		nr3 = Convert.ToInt32(Console.ReadLine());
		if (nr1 > nr2) {
			tmp = nr1;
			nr1 = nr2;
			nr2 = tmp;
		}
		if (nr2 > nr3) {
			tmp = nr1;
			nr1 = nr2;
			nr2 = tmp;
		}
		Console.WriteLine("Numerele in ordine crescatoare:" + nr1 + " " + nr2 + "" + nr3);
		//
		//
		//
		//
		//not finished / De verificat
		//
		//
		//
		//
	}

	public static void Problema16() {
		Console.WriteLine("16.Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri).");
		int nr1, nr2, nr3, nr4, nr5, tmp;
		Console.WriteLine("Nr 1 =");
		nr1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Nr 2 =");
		nr2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Nr 3 =");
		nr3 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Nr 4 =");
		nr4 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Nr 5 =");
		nr5 = Convert.ToInt32(Console.ReadLine());
		if (nr1 > nr2) {
			tmp = nr1;
			nr1 = nr2;
			nr2 = tmp;
		}
		if (nr2 > nr3) {
			tmp = nr2;
			nr2 = nr3;
			nr3 = tmp;
		}
		if (nr3 > nr4) {
			tmp = nr3;
			nr3 = nr4;
			nr4 = tmp;
		}
		if (nr4 > nr5) {
			tmp = nr4;
			nr4 = nr5;
			nr5 = tmp;
		}
		Console.WriteLine("Numerele in ordine crescatoare:" + nr1 + " " + nr2 + "" + nr3 + "" + nr4 + "" + nr5);
		//
		//
		//
		//
		//not finished / De verificat
		//
		//
		//
		//
	}

	public static void Problema17() {
		Console.WriteLine("17.Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.");
		//
		//
		//
		//
		//not finished
		//
		//
		//
		//
	}

	public static void Problema18() {
		Console.WriteLine("18.Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2.");
		//
		//
		//
		//
		//not finished
		//
		//
		//
		//
	}

	public static void Problema19() {
		Console.WriteLine("19.Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.");
		int nr, nrTmp, nrSave;
		Console.WriteLine("Nr =");
		nr = Convert.ToInt32(Console.ReadLine());
		nrSave = nr;
		int cif1 = 0, cif2 = 0;
		bool initializedVal1 = false, initializedVal2 = false, good = true;
		while (nr != 0) {
			nrTmp = nr % 10;
			nr /= 10;
			if (initializedVal1 == false) {
				initializedVal1 = true;
				cif1 = nrTmp;
			}
			else if (initializedVal2 == false) {
				initializedVal2 = true;
				cif2 = nrTmp;
			}
			else if (initializedVal1 == true && cif1 == nrTmp) {

			}
			else if (initializedVal2 == true && cif2 == nrTmp) {

			}
			else {
				good = false;
			}
		}
		if (good)
			Console.WriteLine("Nr " + nrSave + " este format doar din 2 cifre.");
		else
			Console.WriteLine("Nr " + nrSave + " nu este format doar din 2 cifre.");
		//
		//
		//
		//
		//not finished / de verificat
		//
		//
		//
		//
	}

	public static void Problema20() {
		Console.WriteLine("20.Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). (https://github.com/HoreaOros/ROSE2020/blob/master/2611/Program.cs).");
		//
		//
		//
		//
		//not finished
		//
		//
		//
		//
	}

	public static void Problema21() {
		Console.WriteLine("21.Ghiciti un numar intre 1 si 1024 prin intrebari de forma 'numarul este mai mare sau egal decat x ?'.");
		//
		//
		//
		//
		//not finished
		//
		//
		//
		//
	}
}
