public class MultiCounter {
	private int size;
	private Counter[] counters;

	public MultiCounter(int size) {
		this.size = size;

	}

	internal void Increment() {
		counters = new Counter[size];
	}

	internal void Decrement() {
	}

	public override string ToString() {
		StringBuilder sb = new StringBuilder();
		sb.Append("[MultiCounter:]");
	}
}