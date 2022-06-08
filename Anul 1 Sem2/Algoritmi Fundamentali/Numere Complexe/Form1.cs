namespace Numere_Complexe;

public partial class Form1 : Form {
	public Form1() {
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e) {
		listBox1.Items.Clear();
		listBox1.Items.Add("Sugondeze");
		listBox1.Items.Add("Nuts");
		listBox1.Items.Clear();
		Complex x = new Complex();
		Complex y = new Complex();
	}
}
