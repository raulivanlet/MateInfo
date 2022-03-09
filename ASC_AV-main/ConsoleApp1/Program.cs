using System;

namespace ConsoleApp1 {
	class Program {
		static int centsInside = 0;
		static void Main(string[] args) {
			int leaveDispenser = 0;
			int cent5 =0, cent10=0;
			while (leaveDispenser == 0) {
				leaveDispenser = InsertValue();
			}
			while(centsInside != 0) {
				if (centsInside >= 10) {
					centsInside -= 10;
					cent10++;
				}
				else if (centsInside >= 5) {
					centsInside -= 5;
					cent5++;
				}
			}
			Console.Clear();
			Console.WriteLine("Am eliberat "+ cent10 + " monede de 10 bani");
			Console.WriteLine("Am eliberat " + cent5 + " monede de 5 bani");
			string consLine = Console.ReadLine();
		}


		private static int InsertValue() {
			int dispensedAmount = 0;
			while (centsInside >= 20) {
				centsInside -= 20;
				dispensedAmount++;
			}

			Console.Clear();
			Console.WriteLine("Credit valabil:" + centsInside);
			Console.WriteLine("Introduce suma de bani dorita , sau apasa q pentru a pleca de lanca automat");
			Console.WriteLine("1.Nickel (0.05$)");
			Console.WriteLine("2.Dime (0.10$)");
			Console.WriteLine("3.Quarter (0.25$)");
			for (int i = 0; i < dispensedAmount; i++) {
				Console.WriteLine("Am Dat un Obiect!");
			}

			int introduedValue = 0;
			string consLine = Console.ReadLine();
			//Leave the dispenser if value is q
			if (consLine == "q") {
				return 1;
			}

			//Insert cents if value is 1 , 2, 3
			introduedValue = Convert.ToInt32(consLine);
			if (introduedValue == 1) {
				centsInside += 5;
			}
			else if (introduedValue == 2) {
				centsInside += 10;
			}
			else if (introduedValue == 3) {
				centsInside += 25;
			}

			return 0;
		}
	}
}
