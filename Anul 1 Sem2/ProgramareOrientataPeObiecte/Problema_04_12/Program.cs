Counter heads = new Counter("heads");
Counter tails = new Counter("tails");

Random random = new Random();

for (int i = 0; i < 1000; i++) {
	switch (random.Next(2)) {
		case 0:
			heads.Increment();
			break;
		case 1:
			tails.Increment();
			break;
		default:
			break;
	}
}

Console.WriteLine($" Heads: {heads.Count} ,Tails: {tails.Count}");

Console.WriteLine(heads.ToString());
Console.WriteLine(tails.ToString());

heads.Reset();
tails.Reset();

Console.WriteLine("Waiting for input...");
Console.WriteLine("Test1314141123");
Console.ReadLine();

MultiCounter mc = new MultiCounter(1);