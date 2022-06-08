namespace Numere_Complexe;

public class Complex {
	private float _real;
	private float _imaginary;

	public float Real { get { return _real; } set { _real = value; } }
	public float Imaginary { get { return _imaginary; } set { _imaginary = value; } }

	public void Init(float real, float imaginary) {
		_real = real;
		_imaginary = imaginary;
	}

	public string View() {
		if (_imaginary > 0)
			return _real + "+" + _imaginary + "i";
		else
			return _real + "-" + (-1 * _imaginary) + "i";
	}

	public Complex Sum(Complex other) {
		Complex result = new Complex();
		result.Real = this.Real + other.Real;
		result.Imaginary = this.Imaginary + other.Imaginary;
		return result;
	}

	public override string ToString() {
		return "Sugondeze";
	}

	public static Complex operator +(Complex a, Complex b) {
		Complex result = new Complex();
		result._imaginary = a.Imaginary + b.Imaginary;
		result._real = a.Real + b.Real;
		return result;
	}

}