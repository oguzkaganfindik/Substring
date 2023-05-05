using System;

namespace AltMetin
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string orijinalMetin = "Hello World!";
            int baslangicIndex = 6;
            int uzunluk = 6;
            string altMetin = AltMetinGetir(orijinalMetin, baslangicIndex, uzunluk);
            Console.WriteLine(altMetin);
        }

        static string AltMetinGetir(string metin, int baslangicIndex, int uzunluk)
        {
            char[] sonuc = new char[uzunluk];

            int i = 0;
            while (i < uzunluk && baslangicIndex + i < metin.Length)
            {
                sonuc[i] = metin[baslangicIndex + i];
                i++;
            }

            return new string(sonuc, 0, i);
        }
    }
}







