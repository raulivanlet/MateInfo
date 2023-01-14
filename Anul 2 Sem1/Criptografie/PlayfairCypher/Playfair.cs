using System.Text;

internal class Playfair {

    StringBuilder textToEncrypt = new StringBuilder();

    StringBuilder keyword = new StringBuilder();
    

    char[,] table = new char[5,5];

    public Playfair(string textToEncrypt, string keyword){
        this.keyword.Append(keyword.ToUpper());
        this.textToEncrypt.Append(textToEncrypt.ToUpper());
        CreateTable();
    }


    private void Encrypt(){

    }


    private void CreateTable(){
        StringBuilder alphabet = new StringBuilder("ABCDEFGHIKLMNOPQRSTUVXYZ");
        RemoveI();

        for(int i=0; i<5; i++){
            for(int j=0; j<5; j++){

                if( i*5 + j < keyword.Length){
                    char chr = keyword[i*5+j];
                    table[i,j] = chr;

                    for(int k=0; k < alphabet.Length; k++){
                        if( chr == alphabet[k] ){
                            StringBuilder tmp = new StringBuilder();
                            alphabet.Remove(k, 1);
                        }
                            
                    }
                }
                    
                else if (i*5 + j - keyword.Length < alphabet.Length){
                    table[i,j] = alphabet[i*5 + j - keyword.Length];
                }
                    
            }
        }

    }


    private void RemoveI(){
        StringBuilder tmp = new StringBuilder();
        var unique = new HashSet<char>(keyword.ToString());

        foreach (char c in unique){
            if(c == 'J')
                tmp.Append('I');
            else if(c != ' ')
                tmp.Append(c);
        }

        keyword.Clear();
        keyword.Append(tmp);
    }


    public void Print(){

        for(int i=0; i<5; i++){
            for(int j=0; j<5; j++){
                System.Console.Write($"{table[i,j]} ");
            }
            System.Console.Write("\n");
        }

    }


}
