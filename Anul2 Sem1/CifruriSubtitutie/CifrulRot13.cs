using System.Text;

public class CifrulRot13: Substitutie {
    
    protected StringBuilder textNormal = new StringBuilder();
    protected StringBuilder textCriptat = new StringBuilder();
    protected int shiftVal;
    

    public CifrulRot13() : this("Default Text. No Text Recived"){}

    public CifrulRot13(string textNormal) {
        this.textNormal.Append(textNormal);
        this.shiftVal = 13;
    }
    
    
    override public void Encript(){
        this.textCriptat.Append(Encript(this.textNormal, shiftVal));
        System.Console.WriteLine($"{textNormal} ===> {textCriptat}  (Shifted by {shiftVal})");
        //System.Console.WriteLine($"{textNormal} ===> {textCriptat}  (Shifted by {shiftVal})");
    }

    override public void Decript(){
        this.textCriptat.Append(Encript(this.textNormal, shiftVal));
        System.Console.WriteLine($"{textNormal} ===> {textCriptat}  (Shifted by {shiftVal})");
        //System.Console.WriteLine($"{textCriptat} ===> {textNormal}  (Decripted by {shiftVal})");
    }

}