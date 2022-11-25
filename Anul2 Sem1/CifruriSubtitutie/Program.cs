//cifrul Caesar, (criptare, decriptare, criptanaliza)
//cifrul ROT13, (criptare, decriptare, criptanaliza)
//cifrul ShiftByN, (criptare, decriptare, criptanaliza)
//substitutia monoalfapbetica cu o permutare aleatorie a alfabetului.


internal class Program
{
    private static void Main(string[] args)
    {
        //Loop until valid inputs is given
        bool inputIsWrong = true;
        while( inputIsWrong == true){
            inputIsWrong = true;
            Console.Clear();
            System.Console.WriteLine("Selecteaza algoritmul dorit:");
            System.Console.WriteLine("1.Cifrul Caesar");
            System.Console.WriteLine("2.Cifrul Rot13");
            System.Console.WriteLine("3.Cifrul ShiftByN");
            string? readConsole = Console.ReadLine();


            //Caesar Cypher
            if (readConsole == "1"){
                inputIsWrong = false;
                System.Console.WriteLine("Scrie Textul dorit");
                string? cypher = Console.ReadLine();

                System.Console.WriteLine("Selecteaza Optiunea:");
                System.Console.WriteLine("1.Encripteaza");
                System.Console.WriteLine("2.Decripteaza");
                readConsole = Console.ReadLine();

                if(cypher != null){
                    CifrulCaesar cifCes = new CifrulCaesar(cypher);
                    if(readConsole == "1")
                        cifCes.Encript();

                    else if(readConsole == "2")
                        cifCes.Decript();

                }
                readConsole = Console.ReadLine();
            }


            //Rot13
            else if (readConsole == "2"){
                inputIsWrong = false;
                System.Console.WriteLine("Scrie Textul dorit");
                string? cypher = Console.ReadLine();

                System.Console.WriteLine("Selecteaza Optiunea:");
                System.Console.WriteLine("1.Encripteaza");
                System.Console.WriteLine("2.Decripteaza");
                readConsole = Console.ReadLine();

                if(cypher != null){
                    CifrulRot13 cifCes = new CifrulRot13(cypher);
                    if(readConsole == "1")
                        cifCes.Encript();

                    else if(readConsole == "2")
                        cifCes.Decript();

                }
                readConsole = Console.ReadLine();
            }


            //ShiftByN
            else if (readConsole == "3"){
                inputIsWrong = false;
                System.Console.WriteLine("Scrie Textul dorit");
                string? cypher = Console.ReadLine();

                System.Console.WriteLine("Selecteaza Optiunea:");
                System.Console.WriteLine("1.Encripteaza");
                System.Console.WriteLine("2.Decripteaza");
                readConsole = Console.ReadLine();
                

                System.Console.WriteLine("Valoarea Shift-ului");
                string? shiftValStr = Console.ReadLine();
                int shiftVal = 1;
                if(shiftValStr != null){
                    shiftVal = Int32.Parse(shiftValStr);
                }
                    

                if(cypher != null){

                    CifrulShiftByN cifCes = new CifrulShiftByN(cypher, shiftVal);
                    if(readConsole == "1")
                        cifCes.Encript();

                    else if(readConsole == "2")
                        cifCes.Decript();

                }
                readConsole = Console.ReadLine();
            }


            else if (readConsole == "q" || readConsole == "Q"){
                inputIsWrong = false;
                System.Console.WriteLine("Goodbye!");
                var dump = System.Console.ReadLine();
            }


        }
    }
}