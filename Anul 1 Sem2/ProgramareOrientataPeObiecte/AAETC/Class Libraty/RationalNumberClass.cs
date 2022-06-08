namespace Class_Libraty;

/*
public Enum Sign {
	Pozitiv,
	Negativ
}
*/

public class RationalNumberClass {
	public int Numitor { get; set; }
	public int Numarator { get; set; }

	//public Sign Semn { get; set; }

	public RationalNumberClass(int Numarator ,int Numitor) {
		if ( Numitor == 0 )
			throw new ArgumentException();
		if ( Numarator < 0 && Numitor > 0 || Numarator > 0 && Numitor < 0 )
			Console.WriteLine("Semn Negativ");
		else
			Console.WriteLine("Semn Pozitiv");

	Numarator = Math.Abs(Numarator);
	Numitor = Math.Abs(Numitor);

	public override string ToString() {
		string result = $"{Numarator}/{Numitor}";
		if ( Semn == Sign.Negative )
			result = "-" + result;
		return result;
	}
}
