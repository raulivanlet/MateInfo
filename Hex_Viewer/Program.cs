const string inputFile = "ReadFile.txt";
const string outputFile = "OutFile.txt";

using (BinaryWriter writer = new BinaryWriter(File.Open(inputFile, FileMode.Create)))
{
    writer.Write("Hello There\nHello");
}

byte currentByte;
int currentByteNumber = 0;
string printString = "";
bool wroteIndex = false;

if (File.Exists(inputFile))
{
    using (BinaryReader reader = new BinaryReader(File.Open(inputFile, FileMode.Open)))
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(outputFile, FileMode.Create)))
        {
            currentByte = reader.ReadByte();
            if (currentByte == 0)
                Console.Write("File is empty");

            else
            {
                while (reader.PeekChar() != -1)
                {
                    if (currentByteNumber % 16 == 0)
                    {
                        if (wroteIndex == true)
                        {
                            wroteIndex = false;
                            printString = Convert.ToString(currentByteNumber);
                            writer.Write(printString + "0 ");
                        }
                        else
                        {
                            wroteIndex = true;
                            writer.Write(printString);
                        }

                    }

                    currentByte = reader.ReadByte();
                    printString = printString + Convert.ToString(currentByte);
                    string hex = currentByte.ToString("X2");

                    writer.Write(hex + " ");
                    currentByteNumber++;

                    if (currentByteNumber % 8 == 0 && currentByteNumber % 16 != 0)
                    {
                        writer.Write("| ");
                    }
                }

                for (currentByteNumber = 0; currentByte != 0; currentByte = reader.ReadByte())
                {
                    if (currentByteNumber % 16 == 0)
                    {
                        if (wroteIndex == true)
                        {
                            wroteIndex = false;
                            printString = Convert.ToString(currentByteNumber);
                            writer.Write(printString + "0 ");
                        }
                        else
                        {
                            wroteIndex = true;
                            writer.Write(printString);
                        }

                    }

                    currentByte = reader.ReadByte();
                    printString = printString + Convert.ToString(currentByte);
                    string hex = currentByte.ToString("X2");

                    writer.Write(hex + " ");
                    currentByteNumber++;

                    if (currentByteNumber % 8 == 0 && currentByteNumber % 16 != 0)
                    {
                        writer.Write("| ");
                    }
                }

            }


        }
    }
}