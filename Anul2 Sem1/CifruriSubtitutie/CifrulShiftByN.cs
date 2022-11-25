using System.Text;

public class CifrulShiftByN: Substitutie {
    
    protected StringBuilder textNormal = new StringBuilder();
    protected StringBuilder textCriptat = new StringBuilder();
    protected int shiftVal;
    

    public CifrulShiftByN() : this("Default Text. No Text Recived"){}

    public CifrulShiftByN(string textNormal) : this(textNormal, 1){}

    public CifrulShiftByN(string textNormal, int shiftVal){
        this.textNormal.Append(textNormal);
        this.shiftVal = shiftVal;
    }
    

    override public void Encript(){
        this.textCriptat.Append(Encript(this.textNormal, shiftVal));
        System.Console.WriteLine($"{textNormal} ===> {textCriptat}  (Shifted by {shiftVal})");
        //this.textCriptat.Append(Encript(this.textNormal, shiftVal));
        //System.Console.WriteLine($"{textNormal} ===> {textCriptat}  (Shifted by {shiftVal})");
    }

    override public void Decript(){
        this.textCriptat.Append(Decript(this.textNormal, shiftVal));
        System.Console.WriteLine($"{textNormal} ===> {textCriptat}  (Decripted by {shiftVal})");
        //System.Console.WriteLine($"{textCriptat} ===> {textNormal}  (Decripted by {shiftVal})");
    }

}