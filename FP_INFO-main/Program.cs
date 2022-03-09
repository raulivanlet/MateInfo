using System;

namespace FP_Info {
	class Program {
		//Checkers
		private static bool exitProgram = false;
		private static bool isInMainMenu = false;
		private static bool isInSet1Menu = false;
		private static bool isInSet2Menu = false;
		private static bool InInSet3Menu = false;

		static void Main(string[] args) {
			if (exitProgram == false) {
				MainMenu();
			}
		}

		//Select Problem Set
		private static void MainMenuDontUse() {
			int nr = ReadConsole(Console.ReadLine());
			switch (nr) {
				case 1:
					Set1Menu();
					break;
				case 2:
					Set2Menu();
					break;
				case 3:
					Set3Menu();
					break;
				default:
					if (exitProgram == false) {
						NumberOutOfRange();
						MainMenu();
						break;
					}
					else {
						break;
					}
			}
		}

		//All menus drawing
		private static void MainMenu() {
			if (exitProgram == true) {
				Console.Clear();
				Console.WriteLine("Goodbye!! o7");
				System.Threading.Thread.Sleep(2000);
			}
			else {
				isInMainMenu = true;
				isInSet1Menu = false;
				isInSet2Menu = false;
				InInSet3Menu = false;
				Console.Clear();
				Console.WriteLine("		Raul Ivan Let - Probleme Fundamentele Programamrii");
				Console.WriteLine("Selecteaza Setul de probleme:");
				Console.WriteLine("1.Probleme - setul 1");
				Console.WriteLine("2.Probleme - setul 2 (secvente)");
				Console.WriteLine("3.Probleme - setul 3 (tablouri)");
				MainMenuDontUse();
			}

		}

		private static void Set1Menu() {
			int nr;
			string trow;
			isInMainMenu = false;
			isInSet1Menu = true;
			Console.Clear();
			Console.WriteLine("		Probleme - setul 1");
			Console.WriteLine("Selecteaza una dintre probleme, sau apasa q pentru a reveni:");
			Console.WriteLine("1.Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.");
			Console.WriteLine("2.Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.");
			Console.WriteLine("3.Determinati daca n se divide cu k, unde n si k sunt date de intrare.");
			Console.WriteLine("4.Detreminati daca un an y este an bisect.");
			Console.WriteLine("5.Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.");
			Console.WriteLine("6.Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");
			Console.WriteLine("7.(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.");
			Console.WriteLine("8.(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.");
			Console.WriteLine("9.Afisati toti divizorii numarului n.");
			Console.WriteLine("10.Test de primalitate: determinati daca un numar n este prim.");
			Console.WriteLine("11.Afisati in ordine inversa cifrele unui numar n.");
			Console.WriteLine("12.Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].");
			Console.WriteLine("13.Determianti cati ani bisecti sunt intre anii y1 si y2.");
			Console.WriteLine("14.Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.");
			Console.WriteLine("15.Se dau 3 numere. Sa se afiseze in ordine crescatoare.");
			Console.WriteLine("16.Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri).");
			Console.WriteLine("17.Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.");
			Console.WriteLine("18.Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2.");
			Console.WriteLine("19.Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.");
			Console.WriteLine("20.Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). (https://github.com/HoreaOros/ROSE2020/blob/master/2611/Program.cs).");
			Console.WriteLine("21.Ghiciti un numar intre 1 si 1024 prin intrebari de forma 'numarul este mai mare sau egal decat x ?'.");
			nr = ReadConsole(Console.ReadLine());
			switch (nr) {
				case 1:
					Console.Clear();
					Set1.Problema1();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 2:
					Console.Clear();
					Set1.Problema2();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 3:
					Console.Clear();
					Set1.Problema3();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 4:
					Console.Clear();
					Set1.Problema4();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 5:
					Console.Clear();
					Set1.Problema5();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 6:
					Console.Clear();
					Set1.Problema6();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 7:
					Console.Clear();
					Set1.Problema7();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 8:
					Console.Clear();
					Set1.Problema8();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 9:
					Console.Clear();
					Set1.Problema9();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 10:
					Console.Clear();
					Set1.Problema10();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 11:
					Console.Clear();
					Set1.Problema11();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 12:
					Console.Clear();
					Set1.Problema12();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 13:
					Console.Clear();
					Set1.Problema13();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 14:
					Console.Clear();
					Set1.Problema14();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 15:
					Console.Clear();
					Set1.Problema15();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 16:
					Console.Clear();
					Set1.Problema16();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 17:
					Console.Clear();
					Set1.Problema17();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 18:
					Console.Clear();
					Set1.Problema18();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 19:
					Console.Clear();
					Set1.Problema19();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 20:
					Console.Clear();
					Set1.Problema20();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				case 21:
					Console.Clear();
					Set1.Problema21();
					trow = Console.ReadLine();
					Set1Menu();
					break;
				default:
					if (exitProgram == false) {
						NumberOutOfRange();
						Set1Menu();
						break;
					}
					else {
						break;
					}
			}
		}

		private static void Set2Menu() {
			int nr;
			string trow;
			isInMainMenu = false;
			isInSet2Menu = true;
			Console.Clear();
			Console.WriteLine("		Probleme - setul 2 (secvente)");
			Console.WriteLine("Selecteaza una dintre probleme, sau apasa q pentru a reveni:");
			Console.WriteLine("1.Se da o secventa de n numere.Sa se determine cate din ele sunt pare.");
			Console.WriteLine("2.Se da o secventa de n numere.Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.");
			Console.WriteLine("3.Calculati suma si produsul numerelor de la 1 la n.");
			Console.WriteLine("4.Se da o secventa de n numere.Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero.Daca numarul nu se afla in secventa raspunsul va fi -1.");
			Console.WriteLine("5.Cate elemente dintr - o secventa de n numere sunt egale cu pozitia pe care apar in secventa.Se considera ca primul element din secventa este pe pozitia 0.");
			Console.WriteLine("6.Se da o secventa de n numere.Sa se determine daca numerele din secventa sunt in ordine crescatoare.");
			Console.WriteLine("7.Se da o secventa de n numere.Sa se determine cea mai mare si cea mai mica valoare din secventa.");
			Console.WriteLine("8.Determianti al n - lea numar din sirul lui Fibonacci.Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n - 1) + f(n - 2).Exemplu: 0, 1, 1, 2, 3, 5, 8...");
			Console.WriteLine("9.Sa se determine daca o secventa de n numere este monotona.Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.");
			Console.WriteLine("10.Se da o secventa de n numere.Care este numarul maxim de numere consecutive egale din secventa.");
			Console.WriteLine("11.Se da o secventa de n numere.Se cere sa se caculeze suma inverselor acestor numere.");
			Console.WriteLine("12.Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.");
			Console.WriteLine("13.O < secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr - o secventa in ordine crescatoare prin rotiri succesive(rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul).Determinati daca o secventa de n numere este o secventa crescatoare rotita.");
			Console.WriteLine("14.O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita.");
			Console.WriteLine("15.O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere.Sa se determine daca este bitonica.");
			Console.WriteLine("16.O < secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive(rotire = primul element devine ultimul).Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.");
			Console.WriteLine("17.Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.Determinati daca secventa reprezinta o secventa de paranteze corecta si, daca este, determinati nivelul maxim de incuibare a parantezelor.De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.");
			nr = ReadConsole(Console.ReadLine());
			switch (nr) {
				case 1:
					Console.Clear();
					Set2.Problema1();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				case 2:
					Console.Clear();
					Set2.Problema2();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				case 3:
					Console.Clear();
					Set2.Problema3();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				case 4:
					Console.Clear();
					Set2.Problema4();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				case 5:
					Console.Clear();
					Set2.Problema5();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				case 6:
					Console.Clear();
					Set2.Problema6();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				case 7:
					Console.Clear();
					Set2.Problema7();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				case 8:
					Console.Clear();
					Set2.Problema8();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				case 9:
					Console.Clear();
					Set2.Problema9();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				case 10:
					Console.Clear();
					Set2.Problema10();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				case 11:
					Console.Clear();
					Set2.Problema11();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				case 12:
					Console.Clear();
					Set2.Problema12();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				case 13:
					Console.Clear();
					Set2.Problema13();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				case 14:
					Console.Clear();
					Set2.Problema14();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				case 15:
					Console.Clear();
					Set2.Problema15();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				case 16:
					Console.Clear();
					Set2.Problema16();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				case 17:
					Console.Clear();
					Set2.Problema17();
					trow = Console.ReadLine();
					Set2Menu();
					break;
				default:
					if (exitProgram == false) {
						NumberOutOfRange();
						Set2Menu();
						break;
					}
					else {
						break;
					}
			}
		}

		private static void Set3Menu() {
			int nr;
			string trow;
			isInMainMenu = false;
			InInSet3Menu = true;
			Console.Clear();
			Console.WriteLine("		Probleme - setul 3 (tablouri)");
			Console.WriteLine("Selecteaza una dintre probleme, sau apasa q pentru a reveni:");
			Console.WriteLine("1.Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.");
			Console.WriteLine("2.Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. ");
			Console.WriteLine("3.Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). ");
			Console.WriteLine("4.Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. ");
			Console.WriteLine("5.Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. ");
			Console.WriteLine("6.Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. ");
			Console.WriteLine("7.Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.");
			Console.WriteLine("8.Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. ");
			Console.WriteLine("9.Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. ");
			Console.WriteLine("10.Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. ");
			Console.WriteLine("11.Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). ");
			Console.WriteLine("12.Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. ");
			Console.WriteLine("13.Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. ");
			Console.WriteLine("14.Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). ");
			Console.WriteLine("15.Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. ");
			Console.WriteLine("16.Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.");
			Console.WriteLine("17.Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.");
			Console.WriteLine("18.Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x.");
			Console.WriteLine("19.Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar).");
			Console.WriteLine("20.Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem.");
			Console.WriteLine("21.Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar).");
			Console.WriteLine("22.Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat.");
			Console.WriteLine("23.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare.");
			Console.WriteLine("24.Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).");
			Console.WriteLine("25.(Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate.");
			Console.WriteLine("26.Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere.");
			Console.WriteLine("27.Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat.");
			Console.WriteLine("28.Quicksort. Sortati un vector folosind metoda QuickSort.");
			Console.WriteLine("29.MergeSort. Sortati un vector folosind metoda MergeSort.");
			Console.WriteLine("30.Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima.");
			Console.WriteLine("31.(Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara).");
			nr = ReadConsole(Console.ReadLine());
			switch (nr) {
				case 1:
					Console.Clear();
					Set3.Problema1();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 2:
					Console.Clear();
					Set3.Problema2();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 3:
					Console.Clear();
					Set3.Problema3();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 4:
					Console.Clear();
					Set3.Problema4();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 5:
					Console.Clear();
					Set3.Problema5();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 6:
					Console.Clear();
					Set3.Problema6();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 7:
					Console.Clear();
					Set3.Problema7();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 8:
					Console.Clear();
					Set3.Problema8();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 9:
					Console.Clear();
					Set3.Problema9();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 10:
					Console.Clear();
					Set3.Problema10();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 11:
					Console.Clear();
					Set3.Problema11();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 12:
					Console.Clear();
					Set3.Problema12();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 13:
					Console.Clear();
					Set3.Problema13();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 14:
					Console.Clear();
					Set3.Problema14();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 15:
					Console.Clear();
					Set3.Problema15();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 16:
					Console.Clear();
					Set3.Problema16();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 17:
					Console.Clear();
					Set3.Problema17();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 18:
					Console.Clear();
					Set3.Problema18();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 19:
					Console.Clear();
					Set3.Problema19();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 20:
					Console.Clear();
					Set3.Problema20();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 21:
					Console.Clear();
					Set3.Problema21();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 22:
					Console.Clear();
					Set3.Problema22();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 23:
					Console.Clear();
					Set3.Problema23();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 24:
					Console.Clear();
					Set3.Problema24();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 25:
					Console.Clear();
					Set3.Problema25();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 26:
					Console.Clear();
					Set3.Problema26();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 27:
					Console.Clear();
					Set3.Problema27();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 28:
					Console.Clear();
					Set3.Problema28();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 29:
					Console.Clear();
					Set3.Problema29();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 30:
					Console.Clear();
					Set3.Problema30();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				case 31:
					Console.Clear();
					Set3.Problema31();
					trow = Console.ReadLine();
					Set3Menu();
					break;
				default:
					if (exitProgram == false) {
						NumberOutOfRange();
						Set3Menu();
						break;
					}
					else {
						break;
					}
			}
		}

		//Read console
		private static int ReadConsole(string valString) {
			if (valString == "q" || valString == "Q") {
				Exit();
			}
			else {
				if (int.TryParse(valString, out int valInt)) {
					valInt = Convert.ToInt32(valString);
					return valInt;
				}
			}
			return 0;
		}

		//Select valid number
		private static void NumberOutOfRange() {
			Console.Clear();
			Console.WriteLine("Selecteaza un numar valid");
			Console.ReadLine();
		}

		//Exit current window
		private static void Exit() {
			if (isInMainMenu) {
				exitProgram = true;
			}
			else if (isInSet1Menu) {
				MainMenu();
			}
			else if (isInSet2Menu) {
				MainMenu();
			}
			else if (InInSet3Menu) {
				MainMenu();
			}
		}
	}
}
