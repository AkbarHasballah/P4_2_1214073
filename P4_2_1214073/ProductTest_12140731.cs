﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214073
{
    internal class ProductTest_12140731
    {
        static void Main(string[]args)
        {
            suratke1 surahke1 = new suratke1("Surah ke 1", "Al fatihah");
            suratke2 surahke2 = new suratke2("Surah ke 2", "Al Baqoroh");
            suratke2 surahke3 = new suratke3("Surah ke 3", "Al Imran");
            suratke2 surahke4 = new suratke4("Surah ke 4", "An Nissa");
            suratke2 surahke5 = new suratke5("Surah ke 5", "Al Maaidah");
            suratke2 surahke6 = new suratke6("Surah ke 6", "Al An'aam");
            suratke2 surahke7 = new suratke7("Surah ke 7", "Al A'raat");
            suratke2 surahke8 = new suratke8("Surah ke 8", "Al Anfaal");
            suratke2 surahke9 = new suratke9("Surah ke 9", "At Taubah");
            suratke2 surahke10 =new suratke10("Surah ke 10", "Yuunus");

            Console.WriteLine(" Ini dari Class surat ke 1");
            Console.WriteLine("surahke1 is a {0} called \"{1}\" and {2} as his surah", surahke1.MyType, surahke1.MyTitle, surahke1.surah);

            Console.WriteLine(" Ini dari Class surat ke 2");
            Console.WriteLine("surahke2 is a {0} called \"{1}\" and {2} as his surah", surahke2.MyType, surahke2.MyTitle, surahke2.surah);

            Console.WriteLine(" Ini dari Class surat ke 3");
            Console.WriteLine("surahke2 is a {0} called \"{1}\" and {2} as his surah", surahke3.MyType, surahke3.MyTitle, surahke3.surah);

            Console.WriteLine(" Ini dari Class surat ke 4");
            Console.WriteLine("surahke2 is a {0} called \"{1}\" and {2} as his surah", surahke4.MyType, surahke4.MyTitle, surahke4.surah);

            Console.WriteLine(" Ini dari Class surat ke 5");
            Console.WriteLine("surahke2 is a {0} called \"{1}\" and {2} as his surah", surahke5.MyType, surahke5.MyTitle, surahke5.surah);

            Console.WriteLine(" Ini dari Class surat ke 6");
            Console.WriteLine("surahke2 is a {0} called \"{1}\" and {2} as his surah", surahke6.MyType, surahke6.MyTitle, surahke6.surah);

            Console.WriteLine(" Ini dari Class surat ke 7");
            Console.WriteLine("surahke2 is a {0} called \"{1}\" and {2} as his surah", surahke7.MyType, surahke7.MyTitle, surahke7.surah);

            Console.WriteLine(" Ini dari Class surat ke 8");
            Console.WriteLine("surahke2 is a {0} called \"{1}\" and {2} as his surah", surahke8.MyType, surahke8.MyTitle, surahke8.surah);

            Console.WriteLine(" Ini dari Class surat ke 9");
            Console.WriteLine("surahke2 is a {0} called \"{1}\" and {2} as his surah", surahke9.MyType, surahke9.MyTitle, surahke9.surah);

            Console.WriteLine(" Ini dari Class surat ke 10");
            Console.WriteLine("surahke2 is a {0} called \"{1}\" and {2} as his surah", surahke10.MyType, surahke10.MyTitle, surahke10.surah);
        }
    }
}
