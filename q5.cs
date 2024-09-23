using System;
using System.IO;

class reads
{
    public static void Main(string[] args)
    {
        // FileInfo fi = new FileInfo();
        FileStream fs = new FileStream("d://out.txt",FileMode.OpenOrCreate, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        string fileContent = sr.ReadToEnd();
        sr.Close();
        fs.Close();
        Console.WriteLine(fileContent);
    }


}
