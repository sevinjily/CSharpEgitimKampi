using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler 
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("-----Elma Birim Fiyati:"+applePrice+"TL");
            //Console.WriteLine("-----Portakal Birim Fiyati:"+orangePrice+"TL");
            //Console.WriteLine("-----Çilek Birim Fiyati:"+ strawberryPrice+"TL");
            //Console.WriteLine("-----Patates Birim Fiyati:"+potatoPrice+"TL");
            //Console.WriteLine("-----Domates Birim Fiyati:"+tomatoPrice+"TL");

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawTotalPrice = strawGram * strawberryPrice;
            //double potatoTotalPrice=potatoGram * potatoPrice;
            //double tomatoTotalPrice=tomatoGram * tomatoPrice;


            //Console.WriteLine("Alınan ürün: Elma -"+"Birim Fiyat:"+applePrice+"-Gramaj:"+appleGram+" - Toplam tutar:"+appleTotalPrice);
            //Console.WriteLine("Alınan ürün: Portakal -"+"Birim Fiyat:"+orangePrice+"-Gramaj:"+orangeGram+" - Toplam tutar:"+orangeTotalPrice);
            //Console.WriteLine("Alınan ürün: Cilek -"+"Birim Fiyat:"+strawberryPrice+"-Gramaj:"+strawGram+" - Toplam tutar:"+strawTotalPrice);
            //Console.WriteLine("Alınan ürün: Patates -"+"Birim Fiyat:"+potatoPrice+"-Gramaj:"+potatoGram+" - Toplam tutar:"+potatoTotalPrice);
            //Console.WriteLine("Alınan ürün: Domates -"+"Birim Fiyat:"+tomatoPrice+"-Gramaj:"+tomatoGram+" - Toplam tutar:"+tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alisveris Toplam Tutar:"+shoppingTotalPrice+"TL");
            #endregion


            #region Char degiskenler
            // char symbol= 'A';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girisleri String Degiskenleri

            //Console.WriteLine("***** CSharp Hava Yollari Yolcu Bilgisi *****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            // passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadi:");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Ilce bilgisi:");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Sehir Bilgisi:");
            //passengerCity = Console.ReadLine(); 
            //Console.Write("Yolcu Yaş:");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik No:");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No:" + passengerIdentityNumber+" - Yolcu Ad Soyad :"+passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);
            #endregion

            #region Klavyeden Tam Sayi Girisleri ve Donusumler 

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lutfen aldiginiz ayakkabi sayisini giriniz:");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz bilgisayar sayisini giriniz:");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz sandalye sayisini giriniz:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lutfen aldiginiz televizyon sayisini giriniz:");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoesCount*shoesPrice+computerCount*computerPrice+chairPrice*chairCount+tvPrice*tvCount;
            //Console.WriteLine();
            //Console.Write("Toplam odemeniz gereken tutar:"+totalPrice);


            #endregion

            #region Klavyeden Ondalikli Sayi Islemleri

            //double exam1, exam2, exam3,result;
            //Console.Write("Lutfen 1.Sinav notunuzu giriniz:");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lutfen 2.Sinav notunuzu giriniz:");
            //exam2= double.Parse(Console.ReadLine());

            //Console.Write("Lutfen 3.Sinav notunuzu giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            // result=(exam1+exam2 + exam3)/3;

            //Console.WriteLine("Sinav ortalamaniz:" + result);

            #endregion

            #region Klavyeden Karatker Girisleri

            //char gender;
            //Console.Write("Lutfen cinsiyetinizi seciniz:");
            //gender=char.Parse(Console.ReadLine());
            //Console.WriteLine("Sectiginiz cinsiyet:"+gender);
            #endregion

            Console.Read();

        }
    }
}
