using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Structura de date , push , cand dau Push() sa fac ordine

namespace _05_23
{
    internal class Program
    {
        static void Main()
        {
            Arrai arr = new Arrai();
            ArrayDarCorectCaAsaSeFaceLaNoi arrr = new ArrayDarCorectCaAsaSeFaceLaNoi();

            
            arr.Push(2);
            arr.Push(1);
            arr.Push(9);
            arr.Push(5141);
            arr.Push(7);
            arr.Push(10);
            arr.Print();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            arrr.Push(14);
            arrr.Push(1);
            arrr.Push(16);
            arrr.Push(4);

            arrr.Print();


            
        }

        
    }
}
