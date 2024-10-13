using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF - ELSE

            // I made the following example for testing ;)
            //Console.Write("Sayısal bir değer giriniz: ");
            //int deger = int.Parse(Console.ReadLine());

            //Console.WriteLine("Girdiğiniz değer "+ deger);

            //// example 1
            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru Tebrikler Tatlı şey ;)");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış Gral!");

            //}
            //// example 2
            //string capital, country;
            //Console.Write("Başkenti giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("ülkeyi giriniz:");
            //country = Console.ReadLine();

            //if(capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("veriler doğrudur");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi!!");


            //}

            //// example 3

            //int number;

            //Console.Write("sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("sayıyı doğru tahmin ettin kardeş");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış zalım ");

            //}

            ////example 4
            //int exam1, exam2, exam3, avarage;
            //string result = "HATA!";          // result a ilk değer atamadım aşağıda hata verdi!!! 

            //Console.Write("Sınav 1 notunu gir: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2 notunu gir: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3 notunu gir: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + avarage);

            //if (avarage > 0 & avarage  <= 50)
            //{
            //    result = " sonuç VASAT";
            //}

            //if (avarage > 50 & avarage <= 70)
            //{
            //    result = " sonuç NORMAL ";
            //}

            //if (avarage > 70 & avarage <= 85)
            //{
            //    result = " Sonuç İYİ";
            //}   

            //if (avarage > 85 & avarage <=100)
            //{
            //    result = " sonuç ÇOK İYİ :)";

            //}



            //Console.WriteLine(result);

            //// EXAMPLE 4

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if (city == "bursa" | city == "gaziantep" | city == "elazığ ")
            //{
            //    Console.WriteLine("helal sana delikanlı ;)");
            //}
            //else
            //{
            //    Console.WriteLine("şehir yanlış girdin");
            //}

            ////example 5

            //Console.Write("kullanıcı adını gir zalım: ");
            //string username = Console.ReadLine();

            //if(username != "antepli")
            //{
            //    Console.WriteLine("kullanıcı adı kabul edilmedi tatlı şey:(");
            //}

            //else
            //{
            //    Console.WriteLine("Hoş geldin gral");
            //}


            #endregion

            #region MOD İŞLEMLERİ
            //// test
            //int number;
            //number = 26;
            //int result = number % 5;        // mod almak için "%" işareti kullanıyorum bana kalanı veriyor!!
            //Console.WriteLine(result);

            ////example11
            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());    // girilen sayı string türünde bu yüzden int türüne çeviriyorum

            //int result = number1 % number2;

            //Console.WriteLine("1. sayının 2. sayıya bölümünden kalan değer: " + result);

            //// example12
            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());     //klavyeden girilen değeri atadım!!! 

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine("kalan: " + number % 2);
            //    Console.WriteLine(number+ " sayısı çifttir");

            //}
            //else
            //{
            //    Console.WriteLine("kalan: " + number % 2);
            //    Console.WriteLine(number + " sayısı tektir");

            //}


            #endregion

            #region CHAR DEĞİŞKENLER İLE UYGULAMALAR

            //// EXAMPLE 13 
            //// g veya G yazılınca galatasaray f veya F yazınca fenerbahçe yazdır

            //char team;
            //Console.Write("Lütfen takımınızın baş harfini girin: ");
            //team = char.Parse(Console.ReadLine());  
            //if (team == 'g' | team == 'G')      // char olduğu için tek tırnak kullandım
            //{
            //    Console.WriteLine("takımın GALATASARAY gral ;)");
            //}

            //if (team == 'f' | team == 'F')      // char olduğu için tek tırnak kullandım
            //{
            //    Console.WriteLine("takımın fener");
            //}

            //if (team == 'b' | team == 'B')      // char olduğu için tek tırnak kullandım
            //{
            //    Console.WriteLine("takımın beşiktaş");
            //}
            //else
            //{
            //    Console.WriteLine("çok farklı bir değer girdin sakin ol ve tekrar dene!");

            //}
            #endregion
            #region ÖRNEK PROJE UYGULAMASI

            // EXAMPLE 14 - ABOUT RESTAURANT MENU

            Console.WriteLine("****** C# Eğitim kampı Restoran ******");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1- Ana yemekler; ");
            Console.WriteLine("2- Çorbalar; ");
            Console.WriteLine("3- Pizzalar; ");
            Console.WriteLine("4- içecekler; ");
            Console.WriteLine("5- TATLILAR;) ");

            string menuItem;

            #endregion


            Console.Read();         // I wrote it so that the terminal window closes immediately.


        }
    }
}
