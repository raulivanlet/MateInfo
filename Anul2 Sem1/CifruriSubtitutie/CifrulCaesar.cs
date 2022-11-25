using System.Text;

public class CifrulCaesar: Substitutie {
    
    protected StringBuilder textNormal = new StringBuilder();
    protected StringBuilder textCriptat = new StringBuilder();
    protected int shiftVal;
    

    public CifrulCaesar() : this("Default Text. No Text Recived"){}

    public CifrulCaesar(string textNormal){
        this.textNormal.Append(textNormal);
        this.shiftVal = 3;
    }
    

    override public void Encript(){
        this.textCriptat.Append(Encript(this.textNormal, shiftVal));
        System.Console.WriteLine($"{textNormal} ===> {textCriptat}  (Shifted by {shiftVal})");
    }

    override public void Decript(){
        this.textCriptat.Append(Decript(this.textNormal, shiftVal));
        System.Console.WriteLine($"{textNormal} ===> {textCriptat}  (Decripted by {shiftVal})");
    }

}