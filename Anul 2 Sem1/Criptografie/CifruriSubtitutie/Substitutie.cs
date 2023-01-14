using System.Text;

public class Substitutie {

    private StringBuilder textNormal = new StringBuilder();
    private StringBuilder textCriptat = new StringBuilder();
    private int shiftVal;

    public Substitutie() : this("Default Text. No Text Recived" ,1){}
    public Substitutie(string textNormal) : this(textNormal, 3){}
    public Substitutie(string textNormal, int shiftVal){
        this.textNormal.Append(textNormal);
        this.shiftVal = shiftVal;
    }

    protected String Encript(StringBuilder text, int shiftBy){
        StringBuilder outS = new StringBuilder();
        for(int i=0; i< text.Length; i++){
            char chr = text[i];

            if( char.IsLetter(chr) ){

                if(char.IsUpper(chr))
                    chr = (char)(((int)text[i] +shiftBy - 65) % 26 + 65);
                else
                    chr = (char)(((int)text[i] +shiftBy - 97) % 26 + 97);
                
                outS.Append(chr);
            }
            else
                outS.Append(chr);

        }
        return outS.ToString();
    }

    protected String Decript(StringBuilder text, int shiftBy){
        StringBuilder outS = new StringBuilder();
        for(int i=0; i< text.Length; i++){
            char chr = text[i];

            if( char.IsLetter(chr) ){

                if(char.IsUpper(chr))
                    chr = (char)(((int)text[i] -shiftBy - 65 + 26) % 26 + 65);
                else
                    chr = (char)(((int)text[i] -shiftBy - 97 + 26) % 26 + 97);
                
                outS.Append(chr);
            }
            else
                outS.Append(chr);

        }
        return outS.ToString();
    }

    virtual public void Encript(){
        this.textCriptat.Append(Encript(this.textNormal, shiftVal));
        System.Console.WriteLine($"{textNormal} ===> {textCriptat}  (Shifted by {shiftVal})");
    }

    virtual public void Decript(){
        this.textCriptat.Append(Decript(this.textNormal, shiftVal));
        System.Console.WriteLine($"{textNormal} ===> {textCriptat}  (Decripted by {shiftVal})");
    }

}