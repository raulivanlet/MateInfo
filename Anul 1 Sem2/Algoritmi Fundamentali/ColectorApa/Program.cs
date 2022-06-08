List<int> colector = new List<int>();
string read = "Default";

Console.Clear();
Console.WriteLine("Introduce marimea colectorului");
Console.WriteLine("Apasa Q sau q sa opresti");
read = Console.ReadLine();

while (read != "Q" && read != "q") {
	colector.Add(Convert.ToInt32(read));
	Console.Clear();
	Console.WriteLine("Introduce marimea colectorului");
	Console.WriteLine("Apasa Q sau q sa opresti");
	Print();
	read = Console.ReadLine();
}

int edgeLeft = colector[0];
int edgeRight = colector[colector.Count];

for (int i = 0; i < colector.Count; i++) {
	Console.WriteLine("hi");
}


void Print() {
	for (int i = 0; i < colector.Count(); i++) {
		Console.Write("");
		for (int j = 0 ,n = colector[i]; j < n; j++) {
			Console.Write("#");
		}
		Console.WriteLine();
	}
}