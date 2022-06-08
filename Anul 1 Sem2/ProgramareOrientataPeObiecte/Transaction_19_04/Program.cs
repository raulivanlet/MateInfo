﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction_19_04 {
	internal class Program {

      //ASD 2015 - Transactions
      static void Main() {
         Transaction[] a = new Transaction[4];
         a[0] = new Transaction("Turing   6/17/1990  644.08");
         a[1] = new Transaction("Tarjan   3/26/2002 4121.85");
         a[2] = new Transaction("Knuth    6/14/1999  288.34");
         a[3] = new Transaction("Dijkstra 8/22/2007 2678.40");

         Console.WriteLine("Nesortat");
         foreach (var item in a) {
            Console.WriteLine(item);
         }

			Console.WriteLine();
         Console.WriteLine("Sortat dupa data");
         Array.Sort(a, new Transaction.DataOrder());
         foreach (var item in a) {
            Console.WriteLine(item);
         }

			Console.WriteLine();
         Console.WriteLine("Sortat dupa nume");
         Array.Sort(a, new Transaction.NumeOrder());
         foreach (var item in a) {
            Console.WriteLine(item);
         }

			Console.WriteLine();
         Console.WriteLine("Sortat dupa suma");
         Array.Sort(a, Transaction.SUMA_ORDER);
         foreach (var item in a) {
            Console.WriteLine(item);
         }
      }
	}
}
