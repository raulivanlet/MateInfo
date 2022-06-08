public class Counter {

	private string id;
	private int count;
	private Counter nextCounter;

	public int Count {
		get { return count; }
	}

	public Counter(string id) {
		this.id = id;
		nextCounter = null;
	}

	public void Increment() {
		++count;
	}

	public void Reset() {
		count = 0;
	}

	public string ToString() {
		return $"[Counter: {this.Count}]";
	}
}