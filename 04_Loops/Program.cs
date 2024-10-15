using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOR LOOP
            // döngüler 1+2+3+4+5+6+7....
            // 3+3=6 +4 =10 + 5 = 15...
            // for (x;y;z)
            // x: başlangıç
            // y: bitiş
            // z: artış azalış

            ////example1  bir şeyi 5 defa ekrana yazdır yani tekrarlı iş yapma
            //int i;
            //for (i = 1; i <= 5; i++) 
            //{
            //    Console.WriteLine("C# eğitim kampı ders4: döngüler");
            //}

            ////example2
            //for (int i =1; i<=20; i++)    // i değişkenini for parantezi içinde de tanımlayabilirim
            //{
            //    Console.WriteLine(i);

            //}

            //example3

            //for (int i=3; i<=50; i+=3)
            //{
            //    Console.WriteLine(i);

            //}

            // EXAMPLE4 

            //Console.Write("lütfen bitiş değerini yazınız:");
            //int finishValue= int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("bu değeri girdin: " + finishValue);
            //}



            #endregion

            #region For Döngüsü ile Karar Yapıları

            for (int i = 0; i <= 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            #endregion

            Console.Read();
        }
    }
}
