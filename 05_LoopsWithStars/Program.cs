using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YILDIZLARLA ŞEKİL ÇİZME 
            // alt alta 10 tane yıldız oluşturma

            //for (int i = 1; i <=10; i++)
            //{
            //    Console.WriteLine("*");
            //}


            // yan yana 10 tane yıldız oluşturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //    // Console.Write("**********");
            //}

            // alt alta her satırda 10 tane yıldız oluşturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //    // Console.Write("**********");
            //}

            // yıldızlarla dik üçgen oluşturma
            //for(int i = 1; i<=5; i++)         // satırları kontrol etmek için i yi atadım
            //{
            //    for (int j =1; j<= i; j++)        // sütunları kontrol etmek için j yi yazdım
            //    {
            //        Console.Write("*");         // yan yana 1 er yıldız yazıyor!!
            //    }
            //    Console.WriteLine();
            //} 

            // yıldızlarla ters dik üçgen oluşturma
            //for (int i = 5; i >= 1; i--)     // satırlar için i atadım
            //{
            //    for (int j = 1; j <= i; j++)        // sütunlar için j atadım
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region dik ve ters dik üçgen alt alta


            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(" *");
            //    }
            //    Console.WriteLine();
            //}
            //for (int k = 4; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write(" *");

            //    }
            //    Console.WriteLine();

            //}


            #endregion

            #region BAKLAVA DİLİMİ

            //int n = 10;      // yarı yükseklik değeri için tanımladım

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)     // sol taraftan boşluk bırakıyor
            //    {
            //        Console.Write(" ");
            //    }
            //    n = n - 1;

            //    for (int k = 1; k <= 2 * i - 1; k++)    // yazdırılacak yıldız sayısını belirliyor!
            //    {
            //        Console.Write('*');
            //    }

            //    Console.WriteLine();
            //    //n = n - 1;


            //}

            //// alt kısım 
            //for (int i = n+1; i>=1; i--)  
            //{
            //    for (int j = n-1; j> 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    n = n+1;

            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    //n = n + 1;

            //}






            #endregion

            #region  PİRAMİT

            //int n = 10;      // yarı yükseklik değeri için tanımladım

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j > 0; j--)     // sol taraftan boşluk bırakıyor
            //    {
            //        Console.Write(" ");
            //    }
            //    

            //    for (int k = 1; k <= 2 * i - 1; k++)    // yazdırılacak yıldız sayısını belirliyor!
            //    {
            //        Console.Write('*');
            //    }

            //    Console.WriteLine();

            //}


            #endregion

            #region TERS PİRAMİT

            int n = 5;
            for (int i = n; i>= 1; i--)
            {
                for (int j = n-i; j>0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k<=2*i-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            

            #endregion


            Console.Read();
        }
    }
}
