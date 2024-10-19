using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods

            // ()
            // geriye değer döndürmeyen metotlar --> void metotlar
            // Customer --> Listele, ekle, sil, güncelle gibi veri tabanı işlemleri

            //// metot tanımlama!!
            //void CustomerList()     // geriye değer döndürmeyen bir metot tanımladım
            //{
            //    Console.WriteLine("Hasan dağ");
            //    Console.WriteLine("Yunus tokka");
            //    Console.WriteLine("Faruk Çınar");
            //    Console.WriteLine("şakşakçı");
            //    Console.WriteLine("sezgin kaplan");
            //}

            //CustomerList();         // tanımladığım metodu burada çağırıyorum private bir metot
            //CustomerList();         // ikinci kez çağırdım


            // example 1 geriye değer döndürmeyen metot
            //void Sum()      // metot tanımladım 
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine("x + y toplamı: " + z);
            //}

            //Sum();

            // veri tabanı işlemlerinde metotları çok efektif bir şekilde kullanacağız!!!


            #endregion

            #region Geriye değer döndürmeyen String PARAMETRELİ metotlar,

            // example 2
            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("hasan dağ");

            //// example 3
            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);

            //}

            //CustomerCard("hasan", "dağ");
            //CustomerCard("selvi", "sever");




            #endregion

            #region Geriye değer döndürmeyen INT PARAMETRELİ metotlar,

            //void Sum(int number1, int number2, int number3)  // geriye değer döndürmeyen parametreli metot oluşturdum
            //{
            //    int result = number1 + number2 + number3;
            //    // result = number1 + number2 + number3;
            //    Console.WriteLine(result);

            //}

            //Sum(3,2,1);

            #endregion

            #region Geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";

            //}

            //CustomerName();

            // example 22

            string StudentCard()
            {
                string name = "hasan";
                string surName = "dağ";

                return name + " " + surName;
            }

            StudentCard();      // ekrana bişey yazdırmıyor , yazdırmak  için aşağıdaki satır

            //Console.WriteLine(StudentCard());



            #endregion

            #region Geriye değer döndüren string PARAMETRELİ Metotlar

            // example 33 -->  önemli bir örnek!!
            //string CountryCard(string countryName, string capital, string flagColor)      // metot tanımladım
            //{
            //    string cardInfo = "Ülke: " +  countryName + " - başkent: " + capital + " - bayrak: " + flagColor;    
            //    return cardInfo;

            //}

            //string x, y, z;
            //Console.Write("ülke adını giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("bayrak rengi giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Ukrayna", "Kiev", "sarı-mavi"));  // değerleri buradan da girebiliriz,




            #endregion

            #region Geriye değer döndüren INT PARAMETRELİ metotlar
            //// example 44
            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;

            //}

            //Console.WriteLine(Sum(45, 98));     //return değeri ekrana yazdırılmadığı için bu şejkilde ileriliyoruz
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));

            // example 55 önemli bak!! 
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " adlı öğrenci sınavı geçti" +" ortalama: " + result;

                }
                else
                {
                    return student + " adlı öğrenci BAŞARISIZ oldu" + " ortalama: " + result;

                }

            }

            Console.WriteLine(ExamResult("hasan", 65, 85, 95));
            Console.WriteLine(ExamResult("mehmet", 22, 33, 44));

            #endregion

            Console.Read();     // terminal penceresi hemen kapanmasın diye yazıyoruz

        }
    }
}
