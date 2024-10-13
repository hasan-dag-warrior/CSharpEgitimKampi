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

            //Console.WriteLine("****** C# Eğitim kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("1- Ana yemekler; ");
            //Console.WriteLine("2- Çorbalar; ");
            //Console.WriteLine("3- Kebaplar; ");
            //Console.WriteLine("4- içecekler; ");
            //Console.WriteLine("5- TATLILAR;) ");
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi:");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------- Ana yemekler -------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Soslu Tavuk");
            //    Console.WriteLine("2- Kızartma tabağı");
            //    Console.WriteLine("3- Kuru fasulye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("------- Ana yemekler -------");

            //    Console.WriteLine();


            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------- Çorbalar -------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek");
            //    Console.WriteLine("2- Ezo gelin");
            //    Console.WriteLine("3- Kelle Paça");
            //    Console.WriteLine("4- Domates");
            //    Console.WriteLine("5- Tarhana");
            //    Console.WriteLine("------- Çorbalar -------");

            //    Console.WriteLine();


            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------- Kebaplar -------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Tavuk");
            //    Console.WriteLine("2- Adana");
            //    Console.WriteLine("3- Urfa");
            //    Console.WriteLine("4- İskender");
            //    Console.WriteLine("5- İnegöl Köfte");
            //    Console.WriteLine("------- Kebaplar -------");

            //    Console.WriteLine();


            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------- İçecekler -------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Limonata");
            //    Console.WriteLine("3- Ayran");
            //    Console.WriteLine("4- Su");
            //    Console.WriteLine("5- Meyve suyu");
            //    Console.WriteLine("------- İçecekler -------");

            //    Console.WriteLine();


            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------- Tatlılar -------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Triliçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");
            //    Console.WriteLine("4- İrmik helvası");
            //    Console.WriteLine("5- Baklava");
            //    Console.WriteLine("------- Tatlılar -------");

            //    Console.WriteLine();


            //}

            //else
            //{
            //    Console.WriteLine("lütfen 1 ile 5 arasında bir seçim yapınız!");


            //}


            #endregion

            #region  SWITCH - CASE

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int montNumber = int.Parse(Console.ReadLine());

            //switch (montNumber)
            //{
            //    case 1: Console.Write("OCAK"); break;
            //    case 2: Console.Write("ŞUBAT"); break;
            //    case 3: Console.Write("MAMRT"); break;
            //    case 4: Console.Write("NİSAN"); break;
            //    case 5: Console.Write("MAYIS"); break;
            //    case 6: Console.Write("HAZİRAN"); break;
            //    case 7: Console.Write("TEMMUZ"); break;
            //    case 8: Console.Write("AĞUSTOS"); break;
            //    case 9: Console.Write("EYLÜL"); break;
            //    case 10: Console.Write("EKİM"); break;
            //    case 11: Console.Write("KASIM"); break;
            //    case 12: Console.Write("ARALIK"); break;
            //    default: Console.Write("hatalu veri giriişi yaptın!!!"); break;
            //}

            // switch case hesap makinası UYGULAMA!!

            int number1, number2, result;       // değikenleri tanımladım!
            char symbol;

            Console.Write("1. sayıyı giriniz: ");       // kullanıcı için not yazdım
            number1 = int.Parse(Console.ReadLine());        // kullanıcının girdiği değeri int türüne çevirdim ve number1 değişkenine atadım!


            Console.Write("2. sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
            symbol = char.Parse(Console.ReadLine());


            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("toplama işlem sonucu: " + result); break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("çıkarma işlem sonucu: " + result); break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("çarpma işlem sonucu: " + result); break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("bölme işlem sonucu: " + result); break;

                default: Console.WriteLine("hatalı bir işlem yaptın!!"); break;

            }



            #endregion


            Console.Read();         // I wrote it so that the terminal window closes immediately.


        }
    }
}
