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

            ////example1 
            //int i;
            //for (i = 1; i <= 5; i++) 
            //{
            //    Console.WriteLine("C# eğitim kampı");
            //}

            ////example2
            //for (int i =1; i<=20; i++)
            //{
            //    Console.WriteLine(i);

            //}

            //example3

            for (int i=3; i<=50; i+=3)
            {
                Console.WriteLine(i);

            }

            #endregion

            Console.Read();
        }
    }
}
