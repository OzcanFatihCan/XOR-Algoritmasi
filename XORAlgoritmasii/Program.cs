using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XORAlgoritmasii
{
    class Program
    {
        static void Main(string[] args)
        {
            //XOR ALGORİTMASI İLE ŞİFRELEME
            Console.Write("Şifrelemek istediğiniz veriyi girin: ");
            string metin = Console.ReadLine();
            Console.Write("\nAnahtarınızın ASCII tablosundaki onluk değerini giriniz: ");
            int anahtar = System.Convert.ToInt32(Console.ReadLine());
            string sifreli_metin = "";
            Console.WriteLine("\nMetin BIN         Anahtar BIN       Sonuç BIN       Harf Şifre Karşılığı");

            foreach (char c in metin)
            {
                int sonuc = System.Convert.ToInt32(c) ^ anahtar;
                Console.WriteLine(Binary(System.Convert.ToInt32(c)) + "     ^    " + Binary(anahtar) + "     =    " + Binary(sonuc) + "   -->  " + Convert.ToChar(sonuc));
                sifreli_metin += Convert.ToChar(sonuc);
            }
            Console.WriteLine("\nŞifrelenmiş metin: " + sifreli_metin);
            Console.ReadKey();
        }
        static string Binary(int n)
        {
            char[] b = new char[8];
            int pos = 7;
            int i = 0;
            while (i < 8)
            {
                if ((n & (1 << i)) != 0)
                {
                    b[pos] = '1';
                }
                else
                {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string(b);
        }
    }
    }

