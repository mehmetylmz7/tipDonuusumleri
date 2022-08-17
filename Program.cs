﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipDonusumleri1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion (Bilinçsiz Dönüşüm)

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d:"+d);     //45

            long h = d;
            Console.WriteLine("h:" + h);     //45

            float i = h;
            Console.WriteLine("i:" + i);     //45

            string e = "mehmet";
            char f = 'y';
            object g = e + f + d;
            Console.WriteLine("g:" + g);     //mehmety45



            // Explicit Conversion   (Bilinçli Dönüşüm)

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);     //4

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);     //100

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);     //10




            // ToString Methodu

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);     //yy:6

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" + zz);     //zz:12.5


            //System.Convert

            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + Toplam);     //Toplam:30



            // Parse 

            ParseMethod();
        }


        public static void ParseMethod()
        {

            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);              // string->int
            double1 = Double.Parse(metin2);            // string->double

            Console.WriteLine("rakam1:" + rakam1);     //rakam1:10
            Console.WriteLine("double1:" + double1);   //double1:10,25



            Console.ReadLine();


        }



    }
}
