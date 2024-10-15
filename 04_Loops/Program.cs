using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            ////example5
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            ////example 6
            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //    totalValue += i;        // total value değerini for döngüsü ile kontrol ettim!!

            //}

            //Console.WriteLine("toplam değer::: " + totalValue);

            //// example 7
            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)     // i eğer 2'ye tam bölünüyorsa
            //    {
            //        totalValue += i;    // total value değerine i ekle dedim
            //        Console.WriteLine(i);

            //    }
            //}
            //Console.WriteLine("---***---");
            //Console.WriteLine(totalValue);


            // example 8

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;

            //        Console.WriteLine("sayaç: " + count);
            //        Console.WriteLine("7'ye bölünen sayılar:: " + i);

            //    }
            //}

            //// example 9!! -  bir bakteri türü her saatin sonund akendini ikiye bölerek çoğaltmaktadır

            //int bacterium = 1;

            //for(int i = 1; i<= 24; i++)     // i değeri ile 24 saatlik periyodu kontrol ediyorum
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saat sonunda: " + bacterium);

            //}



            #endregion

            #region WHILE LOOP

            //// example 5
            //int i = 1;

            //while (i <= 10)     // i küçük eşit 10 olduğu sürece aşağıdaki işlemi yap
            //{
            //    Console.WriteLine("selam dostlar!! ");
            //    i++;

            //}

            //// example 6
            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 ==0)
            //    {
            //        Console.WriteLine(i + " 3 e bölümü sıfır olan sayıdır");
            //    }
            //    i++;

            //}

            //// example 7 
            //int i = 1;
            //int sum = 0;

            //while (i<=10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);




            #endregion

            #region  Örnek Sınav sorusu

            // klavyeden girilen 3 basamaklı sayının basamakları toplamını
            //hesaplayan kodu yazınız.

            // 456 --> 4+5+6 yapacağız

            //Console.Write("3 basmaklı bir sayı gir Gral: ");    // kullanıcıdan giriş istedim
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //hundreds = number / 100;
            //tens = (number % 100) / 10;

            //sum = ones + tens + hundreds;

            //Console.WriteLine(sum);


            #endregion

            Console.Read();
        }
    }
}
