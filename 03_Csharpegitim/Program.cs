﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Csharpegitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "tüekiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.Write("hatalı bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "sonuç orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "sonuç iyi";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = "Sonuç Çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "manisa" | city == "bursa" | city == "ankara")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoşgeldiniz");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("1. Sayının 2. Sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());


            //if(number%2==0)
            //{
            //    Console.Write("Sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir");
            //}

            #endregion

            #region Char Değişkenler İle Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("**** C# Eğitim Kampı Restoran ****");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını Görmek İstediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Ana Yemekler------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Köri Soslu Tavuk Tabağı");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fırında Somon");
            //    Console.WriteLine("4- Patlıcan Musakka");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Çorbalar------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Ezogelin Çorbası");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Pizzalar------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Akdeniz Pizza");
            //    Console.WriteLine("2- Maragaritha Pizza");
            //    Console.WriteLine("3- Tavuklu Pizza");
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------İçecekler------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Ayran");
            //    Console.WriteLine("3- Su");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------------Tatlılar------------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Triliçe");
            //    Console.WriteLine("2- Kazandibi");
            //    Console.WriteLine("3- Sütlaç");

            //}
            #endregion

            #region Switch Case


            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat"); break;
            //    case 3:Console.Write("Mart"); break;
            //    case 4:Console.Write("Nisan"); break;
            //    case 5:Console.Write("Mayıs"); break;
            //    case 6:Console.Write("Haziran"); break;
            //    case 7:Console.Write("Temmuz"); break;
            //    case 8:Console.Write("Ağustos"); break;
            //    case 9:Console.Write("Eylül"); break;
            //    case 10:Console.Write("Ekim"); break;
            //    case 11:Console.Write("Kasım"); break;
            //    case 12:Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Yapmak İstediğiniz işlemi Griniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch(symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //}
            #endregion

            Console.Read();
        }
    }
}
