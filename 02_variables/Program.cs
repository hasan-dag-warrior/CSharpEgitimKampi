using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // deneme amaçlı aşağıdakileri yazdım
            Console.WriteLine("belki bir gün; tatlı şey");

            
            Console.WriteLine();
            Console.WriteLine("*****--------*****");
            #region DOUBLE DEĞİŞKENLER
            //double number;
            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, patatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + patatoPrice +" TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine();        // boşlu bırakmak için yazdım

            //double appleGram, orangeGram, strawGram, patatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.75;
            //patatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawGram * strawberryPrice;  
            //double patatoTotalPrice = patatoGram * patatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;


            //Console.WriteLine("Elmanın toplam Fiyatı: " + appleTotalPrice + " TL");
            //Console.WriteLine("alınan ürün: elma - " + " birim fiyat: " + applePrice + " gramajj: " + appleGram + " toplam fiyat: " + appleTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("Portakalın toplam fiyatı: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Çileğin Toplam Fiyatı: " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Patatesin Toplam Fiyatı: " + patatoTotalPrice + " TL");
            //Console.WriteLine("Domatesin Toplam Fiyatı: " + tomatoTotalPrice + " TL");


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;


            //Console.WriteLine();
            //Console.WriteLine("alışveriş Toplam tutarı: " + shoppingTotalPrice + " TL");


            #endregion

            #region CHAR DEĞİŞKENLER

            // ABCDEFGH
            //DEF....
            //TOPLANTI SAAT 20:00'DE
            // char değişkenini atamak için çift tırnak değil tek 'tırnak' kullanıyoruz 

            //char symbol;
            //symbol = 's';       // tek tırnak kullandım!!!
            //Console.WriteLine("char değişkenine atadığım değer::  " + symbol);




            #endregion
            #region KLAVYEDEN VERİ GİRİŞLERİ STRING DEĞİŞKENLER

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIDNumber;    // strin türünde değişken tanımladım

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();     //passanger değişkeninin girdiğim değeri üzerine yazacak,

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();
            //Console.WriteLine();          // 1 satır boşluk bırakmak için yazdım

            //Console.Write("ilçe: ");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("Şehir: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yolcu yaş: ");             // SONRA BU GİRDİLERİN TAMAMINA KOŞULLAR KOYMAM GEREKECEK SADECE SAYI VEUA SADECE STRING İFADE KULLAN GİBİ!!
            //passangerAge = Console.ReadLine();

            //Console.Write("Yolcu ID: ");
            //passangerIDNumber = Console.ReadLine();



            //Console.WriteLine("-------------");
            //Console.WriteLine("Yolcu: " + passangerName + " " + passangerSurname + 
            //    " yolcunun bilgileri " + " yaş: " + passangerAge + " " + passangerDistrict + " " + passangerIDNumber + " " + passangerCity);





            #endregion

            #region Klavyeden veri girişleri INT DEĞİŞKENLER ve DÖNÜŞÜMLER!!

            //int shoesPrice, computerPrice, watchPrice, chairPrice;

            //shoesPrice = 1000;
            //computerPrice = 35000;
            //watchPrice = 600;
            //chairPrice = 5000;

            //int shoesCount, computerCount, watchCount, chairCount;

            //Console.Write("Lütfen aldığıızn aykkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());     // dönüştürme yapıyorum

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz;");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığıızn saat sayısını giriniz: ");
            //watchCount = int.Parse(Console.ReadLine());     // dönüştürme yapıyorum

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz;");
            //chairCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + watchPrice * watchCount + chairPrice * chairCount;
            //Console.WriteLine("toplam ödenecek tutar: " + totalPrice);

            #endregion

            #region KLAVYEDEN ONDALIKLI SAYI GİRİŞİ İŞLEMLERİ

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());   // girilen değeri double değişken türüne çeviriyorum ve sonrasında atamasını yapıyorum!!!

            //Console.Write("Lütfen 2.sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());   // girilen değeri double değişken türüne çeviriyorum ve sonrasında atamasını yapıyorum!!!

            //Console.Write("Lütfen 3.sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());   // girilen değeri double değişken türüne çeviriyorum ve sonrasında atamasını yapıyorum!!!

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("sınav ortalamanız: " + result);


            #endregion

            #region KLAVYEDEN KARAKTER GİRİŞLERİ
            char gender;
            Console.Write("Cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("seçtiğiniz Cinsiyet: " + gender);

            #endregion
            Console.Read();

        }
    }
}
