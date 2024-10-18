using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TEMEL DİZİ ÖRNEKLERİ
            //2.4.6.7.8.
            // sarı, kırmızı, mavi, turuncu..
            // elazığ, bursa, gaziantep
            // değişken türü [] DiziAdı = new Değişken Türü[eleman sayısı]

            ////dizi tanımlama
            //string[] colors = new string[4];        // bu dizi 4 elmandan oluşacak bir dizi
            //colors[0] = "red";
            //colors[1] = "black";
            //colors[2] = "blue";
            //colors[3] = "white";

            //Console.WriteLine(colors[3]);

            //// example 2
            //string[] cities = new string[5];

            //cities[0] = "elazığ";
            //cities[1] = "bursa";
            //cities[2] = "Gaziantep";
            //cities[3] = "adana";
            //cities[4] = "muğla";

            //Console.WriteLine(cities[4]);   
            //Console.WriteLine(cities[3]);
            //Console.WriteLine(cities[2]);
            //Console.WriteLine(cities[1]);
            //Console.WriteLine(cities[0]);

            ////example 3
            //int[] numbers = new int[10];
            //numbers[0] = 50; 
            //numbers[1] = 25; 
            //numbers[2] = 65; 
            //numbers[3] = 87;
            //numbers[7] = 22;

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine(numbers[6]);      // index 6 tanımlamadım bu yüzden otomatik olarak 0 geldi
            //Console.WriteLine(numbers[7]);

            //example 4
            //string[] cities = { "Gaziantep", "Bursa", "Elazığ", "Muğla", "İzmir", "Adana" };

            //Console.WriteLine(cities[0]);


            #endregion

            #region DİZİDEKİ TÜM ELEMANLARI LİSTELEME

            //example 1
            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //example2
            //int[] numbers = { 4, 85, 96, 74, 126, 635, 488, 520, 7456, 2365, 1120 };        // number adında dizi oluşturdum ve atama yaptım 

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //example3 char değerler için de sıralama yapabiliyorum
            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            // example 4 dizideki en büyük sayıyı bul

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 88 };

            //int maxNumber = myArray[0];     // başlangıçta max sayı değişkenine 0. indexi atadım
            //for (int i = 0; i < myArray.Length; i++) 
            //{
            //    if(myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);


            //example 5 
            //string[] persons = { "ali", "serpil", "hasan", "rumeysa", "beyda" };
            //Console.WriteLine(persons.Length);

            // example 6
            //int[] numbers = { 45, 85, 52, 41, 41, 86, 10, 22, 35 };
            //Array.Sort(numbers);        // sayıları büyükten küçüğe sıraladım
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine();
            //Console.WriteLine("********");
            //Console.WriteLine();

            //Array.Reverse(numbers);             // sayıları tersine sıraladı
            //for(int i = 0;i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region DİZİ METOTLARI

            // example1
            //string[] customers = { "ali", "buse", "çınar", "ayşegül", "merve" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);


            // example 2
            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin en büyük Elemanı: " + numbers.Max());
            //Console.WriteLine("Dizinin en küçük Elemanı: " + numbers.Min());




            #endregion

            #region  KULLANICIDAN DEĞER ALMA

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();

            //}

            //Console.WriteLine();
            //Console.WriteLine("-----****------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);

            //}

            // example 22

            //int[] numbers = { 10, 20, 45, 65, 80, 97, 78 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            // example 33
            int[] numbers = { 21, 32, 13, 84, 55, 06, 47, 48, 69, 60 };

            Console.WriteLine("Çift sayılar: ");

            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] %2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }

            }

            Console.WriteLine();
            Console.WriteLine("Tek sayılar: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }

            }





            #endregion


            Console.Read();


        }
    }
}
