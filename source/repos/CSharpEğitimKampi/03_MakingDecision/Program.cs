using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If
            //Console.Write("Lütfen şifreyi giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd")
            //{
            //    Console.WriteLine("Sifre dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sifre yanlis");
            //}
            //string capital, country;
            //Console.Write("Baskent giriniz:");
            //capital = Console.ReadLine();
            //Console.Write("Ulkeyi giriniz:");
            //country = Console.ReadLine();
            //if(capital=="baku"&country=="azerbaycan")
            //    Console.Write("veriler dogrulandi");
            //else
            //        Console.Write("hatali bilgi");

            //Console.Write("Sayi giriniz:");
            //int number=int.Parse(Console.ReadLine());
            //if(number == 0 )

            //    Console.Write("Sayi dogru");
            //else
            //    Console.WriteLine("Hatali sayi");

            //int exam1, exam2, exam3;
            //double average;
            //string result;
            //Console.Write("Sinav1:");
            //exam1=int.Parse(Console.ReadLine());

            //Console.Write("Sinav2:");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sinav3:");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Ortalamaniz"+average);
            //if (average < 50)
            //    Console.WriteLine("Cok kotu");
            //else if (average > 50 && average < 61)
            //    Console.WriteLine("Kotu");
            //else if (average >= 61 && average < 71)
            //    Console.WriteLine("Idare eder");
            //else if (average >= 71 && average < 81)
            //    Console.WriteLine("Iyi");
            //else if(average>=81&& average<91)
            //    Console.WriteLine("Cok iyi");
            //else
            //    Console.WriteLine("Mukemmel");

            #endregion
            #region Char Degiskenlerle Karar Yapilari
            //Console.Write("Lütfen takım sembölünü giriniz:");
            //char team=char.Parse(Console.ReadLine().ToLower());

            //switch (team)
            //{
            //    case 'g':
            //        Console.WriteLine("Galatasaray");
            //        break;
            //    case 'f':
            //        Console.WriteLine("Fenerbahçe");
            //        break;
            //    case 'b':
            //        Console.WriteLine("Beşiktaş");
            //        break;
            //    default:
            //        Console.WriteLine("Yanlis sembol");
            //        break;
            //}
            #endregion

            #region Ornek Proje Uygulamasi
            //Console.WriteLine("***** C# Egitim Kampi Restoran ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Corbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-Icecekler");
            //Console.WriteLine("5-Tatlilar");
            //Console.WriteLine("-------------------------------------------");

            //Console.Write("Detayini gormek istediginiz menu secin:");
            //string menuItem=Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------- Ana Yemekler -------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kori Soslu Tavuk");
            //    Console.WriteLine("2-Kizartma Tabagi");
            //    Console.WriteLine("1-Fasulye Pilav");
            //    Console.WriteLine("1-Firinda Somon");
            //    Console.WriteLine("1-Patlican Musakka");
            //    Console.WriteLine();

            //    Console.WriteLine("------- Ana Yemekler -------");
            //    //Console.WriteLine();

            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------- Corbalar -------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Corbasi");
            //    Console.WriteLine("2-Ezogelin Corbasi");
            //    Console.WriteLine();
            //    Console.WriteLine("------- Corbalar -------");

            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------- Pizzalar -------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sosisli Pizza");
            //    Console.WriteLine("2-Margarita");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("------- Pizzalar -------");

            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------- Icecekler -------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine();
            //    Console.WriteLine("------- Icecekler -------");

            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------- Tatlilar -------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trilice");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sutlac");
            //    Console.WriteLine();
            //    Console.WriteLine("------- Tatlilar -------");

            //}
            #endregion

            #region Switch Case
            //Console.Write("Lutfen ay girisi yapiniz:");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Yanvar");
            //        break;
            //    case 2:
            //        Console.WriteLine("Fevral");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Aprel");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;
            //    case 6:
            //        Console.WriteLine("Iyun");
            //        break;
            //    case 7:
            //        Console.WriteLine("Iyul");
            //        break;
            //    case 8:
            //        Console.WriteLine("Avqust");
            //        break;
            //    case 9:
            //        Console.WriteLine("Sentyabr");
            //        break;
            //    case 10:
            //        Console.WriteLine("Oktyabr");
            //        break;
            //    case 11:
            //        Console.WriteLine("Noyabr");
            //        break;
            //    case 12:
            //        Console.WriteLine("Dekabr");
            //        break;

            //    default:
            //        Console.WriteLine("Bele bir ay yoxdur.");
            //        break;
            //}
            #endregion

            #region Switch Case Hesap Makinesi
            Console.WriteLine("***** Hesap Makinesi *****");
            Console.WriteLine();
            Console.Write("Lutfen 1.sayiyi girin:");
            int number1=int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Lutfen 2.sayiyi girin:");
            int number2 = int.Parse(Console.ReadLine());


            #endregion
            Console.Read();

        }
    }
}
