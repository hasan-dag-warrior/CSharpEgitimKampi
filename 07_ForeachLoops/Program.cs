using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loops 

            //Foreach(1; 2; 3; 4)   // for döngüsüne göre daha efektif çalışıyor,

            // 1: değişken türü
            // 2: değişken adı
            // 3: in
            // 4: liste, koleksiyon, Dizi

            // example 1
            //string[] cities = { "milano", "roma", "budapeşte", "muğla", "elazığ", "gazientep" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            // example 2
            //int[] numbers = { 45, 78, 985, 635, 007, 74, 11, 22, 33, 7892, 205 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);

            //}

            // example 3
            //int[] numbers = { 45, 78, 985, 635, 007, 74, 11, 22, 33, 7892, 205 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)    // sadece ikiye bölünen tam sayıları getirdi!!
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            // example 4
            //int[] numbers = { 45, 78, 985, 635, 007, 74, 11, 22, 33, 7892, 205 };

            //int total = 0;      // başlangıçta total değişkeninin değerini sıfır verdim!! 

            //foreach (int i in numbers) 
            //{
            //    total += i;
            //    if (total > 200)    // toplam 200 sayısını geçince yazdırmaya başlıyor
            //    {
            //        Console.WriteLine(total);

            //    }

            //}
            //Console.WriteLine("dizideki tüm sayıların toplamı: " + total);

            // LİSTE OLUŞTURMA VERİ TABANLARINDA LİSTELERİ KULLANACAĞIZ

            // example 5
            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 8
            //};

            //foreach (int number in numbers)     // bu döngü liste lerlede çalışabilir sıkıntı yok
            //{
            //    Console.WriteLine(number);

            //}

            // example 6

            //string word = "MERHABA **";

            //foreach (char c in word) 
            //{
            //    Console.WriteLine(c);            
            //}







            #endregion

            #region ÖRNEK SINAV SİSTEMİ UYGULAMASI

            // example -- 7 -- 
            // klavyeden öğrenci isimleri, notları, sınıflarını alalım  not ortalamalarını hesaplayalım 

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması ");
            Console.WriteLine();
            Console.WriteLine();        // boşluk bıraktım


            // sınıftaki öğrenci sayısını kullanıcıdan aldım
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());   // öğrenci sayısını kullanıcıdan aldım
            Console.WriteLine($"Student count: {studentCount}");
            Console.WriteLine("------------------------------");


            // öğrenci isim ve not ortalamaları için dizi oluşturdum
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // her öğrenci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz:  ");

                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;       // 3 sınav notunu topluyoruz


                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;

            }

            
            // sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {

                Console.WriteLine("-----******------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                // öğrencilerin ortalamasını ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kalmıştır");

                }

                Console.WriteLine("-----******------");

            }


            #endregion

            Console.Read();
        }
    }
}
