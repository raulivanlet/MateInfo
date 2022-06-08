using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numar_Rational {
	internal class NumarRationalClass {
		private int numitor;
		private int numarator;
		private bool isNegative = false;
		public NumarRationalClass(): this (0){ }

		public NumarRationalClass(int val): this (val ,0) { }

		public NumarRationalClass(int val1 ,int val2) {
		if(val1 <0){
			val1 *= -1;
			isNegative = true;
		}
		if ( val2 < 0 ) {
			val2 *= -1;
			if(isNegative == true)
				isNegative = false;
			else
				isNegative = true;
		}

		numarator = val1;
		numitor = val2;

		}

		public override string ToString(){
			string val = numarator + " / " + numitor;
			if ( isNegative )
				val = "- " + val;
			return val;
		}



	}
}